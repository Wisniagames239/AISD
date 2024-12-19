using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace grafy2
{
    public partial class Form1 : Form
    {
        Graf1 drzewo;
        Graf1 pom;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string wyraz = textBox1.Text.TrimEnd();
            int[] tab = new int[2];
            try
            {
                tab = wyraz.Split("-").Select(int.Parse).ToArray();
            }
            catch
            {
                MessageBox.Show("Proszê wpisaæ liczby ca³kowite dodatnie oddzielone spacj¹");
                return;
            }
            Edge edge = new Edge(new NodeG1(tab[0]),new NodeG1(tab[1]),1);
            if (drzewo == null)
            {
                drzewo = new Graf1(edge);
            }
            else if(drzewo.ileNowychWezlow(edge)==2)
            {
                
            }
        }
    }
}
