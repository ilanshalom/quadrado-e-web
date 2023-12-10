namespace Quadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float dado = Convert.ToSingle(textBox1.Text);
            float quad = dado * dado;
            label2.Text = "O quadrado vale " + quad;
        }
    }
}