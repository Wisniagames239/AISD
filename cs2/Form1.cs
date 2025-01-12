namespace cs2
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
            int[] tab;
            try
            {
                tab = wejscie.Split(' ').Select(int.Parse).ToArray();
            }
            catch
            {
                MessageBox.Show("Proszê podaæ liczby oddzielone spacj¹ ");
                return;
            };
            int[] posortowana = insertSort(tab);
            label2.Text = "Posortowane: " + string.Join(" ", tab);
            label2.Visible = true;

        }
        int[] insertSort(int[] tab)
        {
            int a;
            for(int i =1; i < tab.Length; i++)
            {
                for(int j = i;j>0;j--)
                {
                    if (tab[j - 1] > tab[j] )
                    {
                        a = tab[j];
                        tab[j] = tab[j - 1];
                        tab[j-1] = a;
                    }
                }
            }
            return tab;
        }
    }
}
