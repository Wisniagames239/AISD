namespace Cw1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string wejscie = textBox1.Text;
            int[] lista;
            try
            {
                lista = wejscie.Split(',').Select(int.Parse).ToArray();
            }
            catch
            {
                MessageBox.Show("Proszê podaæ liczby oddzielone przecinkiem , ");
                return;
            }
            int[] lista2 = lista;
            segregowaniebabelkowo(lista);
            if(lista==lista2)
            {
                MessageBox.Show("Nie mia³em nic do roboty, dziêki :)");
            }
            napisout.Text = "Posortowane: " + string.Join(",", lista);
        }
        private void segregowaniebabelkowo(int[] lista)
        {
            int n = lista.Length;
            for(int i=0;i<n-1;i++)
            {
                for(int j=0;j<n-1;j++)
                {
                    if(lista[j]>lista[j+1])
                    {
                        int pom = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = pom;
                    }
                }
            }
        }
    }
}
