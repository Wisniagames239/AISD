using System.Xml.Linq;

namespace drzewa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BST drzewo = new BST();

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
            drzewo.Add(n);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string wyraz = drzewo.test(0);
            textBox2.Text = wyraz;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string wyraz = drzewo.test(1);
            textBox2.Text = wyraz;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string wyraz = drzewo.test(2);
            textBox2.Text = wyraz;
        }

        private void button5_Click(object sender, EventArgs e)
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
            NodeT node = drzewo.Znajdz(n);
            if(node == null)
            {
                MessageBox.Show("Nie ma takiego wezla");
            }
            drzewo.RemoveElement(node);
        }
    }
}
