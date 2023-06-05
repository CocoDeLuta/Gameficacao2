public abstract class Acessorios : Produto
{
    public abstract string cor { get; set; }
    public abstract string tamanho { get; set; }
    public Acessorios(string nome, double preco, CategoriaProduto cat)
    {
        this.nome = nome;
        this.preco = preco;
        this.categoria = cat;
    }

}