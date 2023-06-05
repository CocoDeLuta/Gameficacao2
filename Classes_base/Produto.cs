public class Produto{

    public string nome { get; set; }
    public double preco { get; set; }

    public enum CategoriaProduto{
        Acessorios,
        Camisas,
        Sapatos,
        Meias,
        Calças,
    }

    public CategoriaProduto categoria { get; set; }
    
}