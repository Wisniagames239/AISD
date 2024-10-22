namespace listy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List lista = new List();

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            try
            {
                n = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Proszê podaæ liczbê ca³kowit¹");
                return;
            }
            lista.AddLast(n);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string napis = lista.ToString();
            label1.Text = "Twoja lista: " + napis;
            label1.Visible = true;
        }
    }
}
