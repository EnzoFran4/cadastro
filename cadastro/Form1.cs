namespace cadastro
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {





            Produto produto1 = new Produto();



            produto1.Codigo = tx_codigo.Text;
            produto1.Descricao = tx_descricao.Text;
            produto1.Preco = Convert.ToDouble(tx_preco.Text);
            produto1.Lucro = Convert.ToDouble(tx_lucro.Text);


            produto1.Valor = produto1.Preco + (produto1.Preco * produto1.Lucro / 100);

            MessageBox.Show(produto1.Codigo + " " + produto1.Descricao + " " + produto1.Preco + " " + produto1.Lucro);

            tx_valor.Text = Convert.ToString(produto1.Valor);

            produtos.Add(produto1);

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1 .DataSource = produtos;









        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_codigo.Clear();
            tx_descricao.Clear();
            tx_preco.Clear();
            tx_lucro.Clear();
            tx_valor.Clear();
        }

        private void tx_valor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}