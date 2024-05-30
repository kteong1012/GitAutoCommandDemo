using System.Text;

namespace toolkit_cherrypick_tool
{
    public class TextBoxWriter : TextWriter
    {
        private RichTextBox _textBox;

        public TextBoxWriter(RichTextBox textBox)
        {
            _textBox = textBox;
        }

        public override void Write(char value)
        {
            _textBox.Text += value;
        }

        public override Encoding Encoding => Encoding.UTF8;

        public override void WriteLine(string value)
        {
            _textBox.Text += value + "\n";
        }

        public override void Write(string value)
        {
            _textBox.Text += value;
        }

        public override void WriteLine()
        {
            _textBox.Text += "\n";
        }

        public override void WriteLine(char value)
        {
            _textBox.Text += value + "\n";
        }

        public override void WriteLine(char[] buffer, int index, int count)
        {
            _textBox.Text += new string(buffer, index, count) + "\n";
        }

        public override void Write(char[] buffer, int index, int count)
        {
            _textBox.Text += new string(buffer, index, count);
        }

        public override void Write(string format, object arg0)
        {
            _textBox.Text += string.Format(format, arg0);
        }

        public override void Write(string format, object arg0, object arg1)
        {
            _textBox.Text += string.Format(format, arg0, arg1);
        }

        public override void Write(string format, object arg0, object arg1, object arg2)
        {
            _textBox.Text += string.Format(format, arg0, arg1, arg2);
        }

        public override void Write(string format, params object[] arg)
        {
            _textBox.Text += string.Format(format, arg);
        }

        public override void WriteLine(string format, object arg0)
        {
            _textBox.Text += string.Format(format, arg0) + "\n";
        }

        public override void WriteLine(string format, object arg0, object arg1)
        {
            _textBox.Text += string.Format(format, arg0, arg1) + "\n";
        }

        public override void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            _textBox.Text += string.Format(format, arg0, arg1, arg2) + "\n";
        }

        public override void WriteLine(string format, params object[] arg)
        {
            _textBox.Text += string.Format(format, arg) + "\n";
        }

        public override void Write(bool value)
        {
            _textBox.Text += value;
        }

        public override void WriteLine(bool value)
        {
            _textBox.Text += value + "\n";
        }

        public override void Write(int value)
        {
            _textBox.Text += value;
        }

        public override void WriteLine(int value)
        {
            _textBox.Text += value + "\n";
        }

        public override void Write(uint value)
        {
            _textBox.Text += value;
        }

        public override void WriteLine(uint value)
        {
            _textBox.Text += value + "\n";
        }

        public override void Write(long value)
        {
            _textBox.Text += value;
        }

        public override void WriteLine(long value)
        {
            _textBox.Text += value + "\n";
        }

        public override void Write(ulong value)
        {
            _textBox.Text += value;
        }

        public override void WriteLine(ulong value)
        {
            _textBox.Text += value + "\n";
        }

        public override void Write(float value)
        {
            _textBox.Text += value;
        }

        public override void WriteLine(float value)
        {
            _textBox.Text += value + "\n";
        }

        public override void Write(double value)
        {
            _textBox.Text += value;
        }

        public override void WriteLine(double value)
        {
            _textBox.Text += value + "\n";
        }

        public override void Write(decimal value)
        {
            _textBox.Text += value;
        }

        public override void WriteLine(decimal value)
        {
            _textBox.Text += value + "\n";
        }

        public override void Write(object value)
        {
            _textBox.Text += value;
        }

        public override void WriteLine(object value)
        {
            _textBox.Text += value + "\n";
        }
    }
}
