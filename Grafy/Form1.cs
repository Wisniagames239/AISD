namespace Grafy
{
    public partial class Form1 : Form
    {
        private Graf graf;
        public Form1()
        {
            InitializeComponent();
            graf = new Graf();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                NodeG newNode = new NodeG(value);
                graf.dodaj(newNode, new List<NodeG>()); // Dodajemy wêze³ bez s¹siadów
                UpdateNodeList();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Proszê wprowadziæ poprawn¹ liczbê.");
            }
        }
        private void UpdateNodeList()
        {
            listBox1.Items.Clear(); // Czyœcimy ListBox przed dodaniem nowych elementów
            foreach (var node in graf.nodes)
            {
                listBox1.Items.Add(node); // Dodajemy ka¿dy wêze³ do ListBox
            }
        }
    }
}
