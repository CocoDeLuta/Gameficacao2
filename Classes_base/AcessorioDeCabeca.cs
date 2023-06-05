public class AcessorioDeCabeca : Acessorios
{
    public override string cor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override string tamanho { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public AcessorioDeCabeca(string nome, double preco, CategoriaProduto cat) : base(nome, preco, cat)
    {
        this.nome = nome;
        this.preco = preco;
        this.categoria = cat;
    }

}