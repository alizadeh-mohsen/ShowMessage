namespace ShowMessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDispaly_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("World");

        }
    }
}