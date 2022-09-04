using System.Text;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enum.TryParse( comboBox1.Text , out CheckCrypt ToDo);

            var line = textBox1.Text;
            line = line.Trim();
            line = CheckLine(line);
            var key = CheckKey();
            
            switch ((int)ToDo)
            {
                case 1:
                    label3.Text = EncodeLine(line,key);
                    break;
                case 2:
                    label3.Text = DecodeLine(line, key);
                    break;
                default:
                    label3.Text = line;
                    break;
            }

        }

        private int CheckKey()
        {
            try
            {
                var key = Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                return 0;
            }
            return Convert.ToInt32(textBox2.Text);

        }

        private string EncodeLine(string lineToDecode, int key)
        {
            var line = new StringBuilder();
            line.Append(lineToDecode);
            var keyLine = new Code(key);

            for (int i = 0; i < line.Length; i++)
            {
                line[i] = keyLine.EncodeChar(line[i]);
            }
            return line.ToString();
        }

        private string DecodeLine(string lineToDecode, int key)
        {
            var line = new StringBuilder();
            line.Append(lineToDecode);
            var keyLine = new Code(key);

            for (int i = 0; i < line.Length; i++)
            {
                line[i] = keyLine.DecodeChar(line[i]);
            }
            return line.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private string CheckLine(string line) => string.IsNullOrEmpty(line) ? "Empty" : line;
    }
    enum CheckCrypt
    {
        None = 0,
        Encrypt = 1,
        Decrypt = 2,
    }
}