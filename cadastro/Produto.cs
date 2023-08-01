public class Produto
{
    public string Codigo { get; set; }

    public string Descricao { get; set; }

    public double Preco { get; set; }

    public double Lucro { get; set; }

    public double Valor { get; set; }

    public Produto()
    {

    }
    public Produto(string Codigo, string Descricao, double Preco, double Lucro, double valor)
    {
        this.Codigo = Codigo;
        this.Descricao = Descricao;
        this.Preco = Preco;
        this.Lucro = Lucro;
        this. Valor = Valor;

    }
}