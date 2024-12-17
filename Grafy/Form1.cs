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
                graf.dodaj(newNode, new List<NodeG>()); // Dodajemy w�ze� bez s�siad�w
                UpdateNodeList();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Prosz� wprowadzi� poprawn� liczb�.");
            }
        }
        private void UpdateNodeList()
        {
            listBox1.Items.Clear(); // Czy�cimy ListBox przed dodaniem nowych element�w
            foreach (var node in graf.nodes)
            {
                listBox1.Items.Add(node); // Dodajemy ka�dy w�ze� do ListBox
            }
        }
    }
}
