namespace toolkit_cherrypick_tool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_CherryPick = new Button();
            textBox_CommitId = new TextBox();
            label1 = new Label();
            panel_Branches = new Panel();
            button_ClearLog = new Button();
            label2 = new Label();
            textBox_RepositoryPath = new TextBox();
            button_OpenDirectoryBrowser = new Button();
            richTextBox_Log = new RichTextBox();
            SuspendLayout();
            // 
            // button_CherryPick
            // 
            button_CherryPick.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_CherryPick.Location = new Point(22, 348);
            button_CherryPick.Name = "button_CherryPick";
            button_CherryPick.Size = new Size(180, 40);
            button_CherryPick.TabIndex = 0;
            button_CherryPick.Text = "Cherry Pick";
            button_CherryPick.UseVisualStyleBackColor = true;
            button_CherryPick.Click += button_CherryPick_Click;
            // 
            // textBox_CommitId
            // 
            textBox_CommitId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox_CommitId.Location = new Point(154, 40);
            textBox_CommitId.Name = "textBox_CommitId";
            textBox_CommitId.Size = new Size(634, 23);
            textBox_CommitId.TabIndex = 1;
            textBox_CommitId.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 43);
            label1.Name = "label1";
            label1.Size = new Size(66, 17);
            label1.TabIndex = 2;
            label1.Text = "commit id";
            label1.Click += label1_Click;
            // 
            // panel_Branches
            // 
            panel_Branches.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel_Branches.Location = new Point(22, 69);
            panel_Branches.Name = "panel_Branches";
            panel_Branches.Size = new Size(180, 273);
            panel_Branches.TabIndex = 5;
            // 
            // button_ClearLog
            // 
            button_ClearLog.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button_ClearLog.Location = new Point(22, 394);
            button_ClearLog.Name = "button_ClearLog";
            button_ClearLog.Size = new Size(180, 44);
            button_ClearLog.TabIndex = 6;
            button_ClearLog.Text = "Clear Log";
            button_ClearLog.UseVisualStyleBackColor = true;
            button_ClearLog.Click += button_ClearLog_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 9);
            label2.Name = "label2";
            label2.Size = new Size(98, 17);
            label2.TabIndex = 7;
            label2.Text = "repository path";
            // 
            // textBox_RepositoryPath
            // 
            textBox_RepositoryPath.Location = new Point(154, 11);
            textBox_RepositoryPath.Name = "textBox_RepositoryPath";
            textBox_RepositoryPath.Size = new Size(556, 23);
            textBox_RepositoryPath.TabIndex = 8;
            textBox_RepositoryPath.TextChanged += textBox_RepositoryPath_TextChanged;
            // 
            // button_OpenDirectoryBrowser
            // 
            button_OpenDirectoryBrowser.Location = new Point(713, 11);
            button_OpenDirectoryBrowser.Name = "button_OpenDirectoryBrowser";
            button_OpenDirectoryBrowser.Size = new Size(75, 23);
            button_OpenDirectoryBrowser.TabIndex = 9;
            button_OpenDirectoryBrowser.Text = "选择目录";
            button_OpenDirectoryBrowser.UseVisualStyleBackColor = true;
            button_OpenDirectoryBrowser.Click += button_ExploreDirectory_Click;
            // 
            // richTextBox_Log
            // 
            richTextBox_Log.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox_Log.Font = new Font("Cascadia Mono", 10.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox_Log.Location = new Point(208, 69);
            richTextBox_Log.Name = "richTextBox_Log";
            richTextBox_Log.Size = new Size(580, 369);
            richTextBox_Log.TabIndex = 10;
            richTextBox_Log.Text = "测试文字 Test Text";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox_Log);
            Controls.Add(button_OpenDirectoryBrowser);
            Controls.Add(textBox_RepositoryPath);
            Controls.Add(label2);
            Controls.Add(button_ClearLog);
            Controls.Add(panel_Branches);
            Controls.Add(label1);
            Controls.Add(textBox_CommitId);
            Controls.Add(button_CherryPick);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_CherryPick;
        private TextBox textBox_CommitId;
        private Label label1;
        private Panel panel_Branches;
        private Button button_ClearLog;
        private Label label2;
        private TextBox textBox_RepositoryPath;
        private Button button_OpenDirectoryBrowser;
        private RichTextBox richTextBox_Log;
    }
}
