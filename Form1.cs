using System.Diagnostics;
using System.Text;

namespace toolkit_cherrypick_tool
{
    public partial class Form1 : Form
    {
        private List<string> _selectedBranches = new List<string>();

        private string _cacheRepositoryPathFile = Path.Combine(Directory.GetCurrentDirectory(), "obj", "repository_path.cache");

        public Form1()
        {
            InitializeComponent();

            ReadRepositoryPathFromCache();

            RegisterLogCallback();

            LoadBranchConfigs();
        }

        private void ReadRepositoryPathFromCache()
        {
            if (File.Exists(_cacheRepositoryPathFile))
            {
                textBox_RepositoryPath.Text = File.ReadAllText(_cacheRepositoryPathFile);
            }
        }

        private void RegisterLogCallback()
        {
            // register callback to console output
            richTextBox_Log.Text = "";
            Console.SetOut(new TextBoxWriter(richTextBox_Log));
        }

        private void LoadBranchConfigs()
        {
            var configFilePath = Path.Combine(Directory.GetCurrentDirectory(), "branch_configs.conf");
            if (!File.Exists(configFilePath))
            {
                Console.WriteLine($"branch_configs.conf not found: {configFilePath}");
                return;
            }

            // read lines in branch_configs.conf
            var branches = File.ReadAllLines(configFilePath);

            // add branches as checkboxes to panel, and layout as vertical
            var y = 0;
            foreach (var branch in branches)
            {
                var checkBox = new CheckBox();
                checkBox.Text = branch;
                checkBox.AutoSize = true;
                checkBox.Location = new Point(0, y);
                checkBox.CheckedChanged += OnCheckBoxChecked;
                checkBox.Checked = true;
                y += checkBox.Height;
                panel_Branches.Controls.Add(checkBox);
            }

        }

        private void OnCheckBoxChecked(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                _selectedBranches.Add(checkBox.Text);
            }
            else
            {
                _selectedBranches.Remove(checkBox.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Log_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button_CherryPick_Click(object sender, EventArgs e)
        {
            // Check if commit id is valid
            if (string.IsNullOrEmpty(textBox_CommitId.Text))
            {
                Console.WriteLine("Commit ID is empty");
                return;
            }

            // Check if branches are selected
            if (_selectedBranches.Count == 0)
            {
                Console.WriteLine("No branches selected");
                return;
            }

            // Check if repository path is valid
            if (string.IsNullOrEmpty(textBox_RepositoryPath.Text))
            {
                Console.WriteLine("Repository path is empty");
                return;
            }
            else if (!Directory.Exists(textBox_RepositoryPath.Text))
            {
                Console.WriteLine($"Repository path does not exist: {textBox_RepositoryPath.Text}");
                return;
            }
            else
            {
                CacheRepositoryPathFile();
            }
            try
            {
                // Cherry pick commit id to selected branches
                foreach (var branch in _selectedBranches)
                {
                    // git checkout branch
                    if (!await RunGitCommand($"checkout {branch}"))
                    {
                        Console.WriteLine($"Failed to checkout branch: {branch}");
                        return;
                    }

                    // git pull
                    if (!await RunGitCommand("pull"))
                    {
                        Console.WriteLine($"Failed to pull branch: {branch}");
                        return;
                    }

                    // git cherry-pick commit id
                    if (!await RunGitCommand($"cherry-pick {textBox_CommitId.Text}"))
                    {
                        Console.WriteLine($"Failed to cherry-pick commit: {textBox_CommitId.Text}");
                        return;
                    }

                    // git push
                    if (!await RunGitCommand("push"))
                    {
                        Console.WriteLine($"Failed to push branch: {branch}");
                        return;
                    }
                }
            }
            finally
            {
                // git checkout master
                await RunGitCommand("checkout master");
            }
        }

        private void CacheRepositoryPathFile()
        {
            var path = textBox_RepositoryPath.Text;
            if (string.IsNullOrEmpty(path))
            {
                return;
            }
            var fileInfo = new FileInfo(_cacheRepositoryPathFile);
            if (!fileInfo.Directory.Exists)
            {
                fileInfo.Directory.Create();
            }
            File.WriteAllText(_cacheRepositoryPathFile, path);
        }

        private async Task<bool> RunGitCommand(string arguments)
        {
            var process = new Process();
            process.StartInfo.FileName = "git";
            process.StartInfo.Arguments = arguments;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WorkingDirectory = textBox_RepositoryPath.Text;
            process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
            process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            process.Start();
            await process.WaitForExitAsync();

            Console.Write(process.StandardOutput.ReadToEnd());
            Console.Write(process.StandardError.ReadToEnd());

            return process.ExitCode == 0;
        }

        private async void button_ClearLog_Click(object sender, EventArgs e)
        {
            richTextBox_Log.Text = "";
            await RunGitCommand("log --grep=\"测试工具\"");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_RepositoryPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_ExploreDirectory_Click(object sender, EventArgs e)
        {
            // select repository path
            var dialog = new FolderBrowserDialog();
            dialog.Description = "Select repository path";
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;
            dialog.ShowNewFolderButton = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBox_RepositoryPath.Text = dialog.SelectedPath;
            }
        }
    }
}
