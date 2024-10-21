using System;
using System.Diagnostics;
namespace sortowania
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] tab = new int[0];
        Stopwatch stopwatch = new Stopwatch();
        //Konwertowanie stringa na int[]
        private void button1_Click(object sender, EventArgs e)
        {
            string wyraz = textBox1.Text.TrimEnd();
            try
            {
                tab = wyraz.Split(" ").Select(int.Parse).ToArray();
            }
            catch
            {
                MessageBox.Show("Proszê wpisaæ liczby ca³kowite dodatnie oddzielone spacj¹");
                return;
            }
            wyswietlpoczatek(tab);

        }
        //bubblesort
        private void button3_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();
            int n = tab.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int pom = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = pom;
                    }
                }

            }
            stopwatch.Stop();
            label5.Text = $"Czas: {stopwatch.ElapsedMilliseconds} ms";
            label5.Visible = true;
            wyswietlkoniec(tab);
        }
        //mergesort
        private void button7_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();
            sortSort(tab, 0, tab.Length - 1);
            stopwatch.Stop();
            label5.Text = $"Czas: {stopwatch.ElapsedMilliseconds} ms";
            label5.Visible = true;
            wyswietlkoniec(tab);
        }
        void sortSort(int[] tab, int l, int r)
        {
            if (l < r)
            {
                int q = (l + r) / 2;
                sortSort(tab, l, q);
                sortSort(tab, q + 1, r);
                scale(tab, l, q, r);



            }


        }
        void scale(int[] tab, int l, int q, int r)
        {
            int ldl = q - l + 1;
            int rdl = r - q;
            int[] temp1 = new int[ldl];
            int[] temp2 = new int[rdl];
            int i, j;
            for (i = 0; i < ldl; ++i)
                temp1[i] = tab[l + i];
            for (j = 0; j < rdl; ++j)
                temp2[j] = tab[q + 1 + j];
            i = 0;
            j = 0;
            int k = l;
            for (k = l; i < ldl && j < rdl; k++)
            {
                if (temp1[i] <= temp2[j])
                {
                    tab[k] = temp1[i++];
                }
                else
                {
                    tab[k] = temp2[j++];
                }
            }
            while (i < ldl)
            {
                tab[k] = temp1[i++];
                k++;
            }
            while (j < rdl)
            {
                tab[k] = temp2[j++];
                k++;
            }
        }
        //insertion sort
        private void button4_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();
            int a;
            for (int i = 1; i < tab.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (tab[j - 1] > tab[j])
                    {
                        a = tab[j];
                        tab[j] = tab[j - 1];
                        tab[j - 1] = a;
                    }
                }
            }
            stopwatch.Stop();
            label5.Text = $"Czas: {stopwatch.ElapsedMilliseconds} ms";
            label5.Visible = true;
            wyswietlkoniec(tab);
        }
        //randomowe liczby
        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int n = (int)numericUpDown1.Value;
            int[] newtab = new int[n];
            for (int i = 0; i < n; i++)
            {
                newtab[i] = random.Next(1, 20000);
            }
            tab = newtab;
            wyswietlpoczatek(tab);
        }
        void wyswietlkoniec(int[] tab)
        {
            int[] newtab;
            string koniec;
            if (tab.Length <= 15)
            {
                newtab = tab;
                koniec = string.Join(" ", newtab);
            }
            else
            {
                newtab = new int[15];
                for (int i = 0; i < 15; i++)
                {
                    newtab[i] = tab[i];
                }
                koniec = string.Join(" ", newtab) + "...";
            }
            label4.Text = "Posortowane: " + koniec;
            label4.Visible = true;

        }
        void wyswietlpoczatek(int[] tab)
        {
            int[] newtab;
            string koniec;
            if (tab.Length <= 15)
            {
                newtab = tab;
                koniec = string.Join(" ", newtab);
            }
            else
            {
                newtab = new int[15];
                for (int i = 0; i < 15; i++)
                {
                    newtab[i] = tab[i];
                }
                koniec = string.Join(" ", newtab) + "...";
            }
            label3.Text = "Twoje liczby: " + koniec;
            label3.Visible = true;

        }
        //quicksort
        private void button6_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();
            QuickSort(tab, 0, tab.Length - 1);
            stopwatch.Stop();
            label5.Text = $"Czas: {stopwatch.ElapsedMilliseconds} ms";
            label5.Visible = true;
            wyswietlkoniec(tab);
        }
        void QuickSort(int[] tab, int start, int stop)
        {
            if (start < stop)
            {
                int pivotValue = tab[(start + stop) / 2];
                int i = start;
                int j = stop;

                while (i <= j)
                {
                    while (tab[i] < pivotValue)
                    {
                        i++;
                    }
                    while (tab[j] > pivotValue)
                    {
                        j--;
                    }
                    if (i <= j)
                    {
                        int temp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = temp;
                        i++;
                        j--;
                    }
                }
                if (start < j)
                {
                    QuickSort(tab, start, j);
                }
                if (i < stop)
                {
                    QuickSort(tab, i, stop);
                }
            }
        }
        //selectionsort
        private void button5_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();
            int min, tempvalue;
            for (int i = 0; i < tab.Length; i++)
            {
                min = i;
                for (int j = i; j < tab.Length; j++)
                {
                    if (tab[j] < tab[min])
                    {
                        min = j;
                    }

                }
                tempvalue = tab[min];
                tab[min] = tab[i];
                tab[i] = tempvalue;
            }
            stopwatch.Stop();
            label5.Text = $"Czas: {stopwatch.ElapsedMilliseconds} ms";
            label5.Visible = true;
            wyswietlkoniec(tab);
        }
        //counting sort
        private void button8_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            stopwatch.Start();

            int max = tab[0];
            foreach (int i in tab)
            {
                if (i > max) { max = i; }
            }

            int[] count = new int[max + 1];
            int[] output = new int[tab.Length];
            for (int i = 0; i < count.Length; i++) { count[i] = 0; }
            foreach (int i in tab)
            {
                count[i]++;
            }
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = tab.Length - 1; i >= 0; i--)
            {
                output[count[tab[i]] - 1] = tab[i];
                count[tab[i]]--; 
            }

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = output[i];
            }

            wyswietlkoniec(tab);



            stopwatch.Stop();
            label5.Text = $"Czas: {stopwatch.ElapsedMilliseconds} ms";
            label5.Visible = true;
            wyswietlkoniec(tab);
        }
    }
}
