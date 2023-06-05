
List<PecaSuperior> pecasSuperiores = new List<PecaSuperior>();
List<PecaInferior> pecasInferiores = new List<PecaInferior>();

//Apresentação inicial do programa
Console.Clear();
Console.WriteLine("Bem vindo ao sistema de vendas de nossa loja!");
Console.WriteLine("Para começar, escolha uma das opções abaixo:");
Console.WriteLine("");

//Menu principal
int opcao = 0;
while (opcao == 0)
{
    Ciano();
    Console.WriteLine("--MENU PRINCIPAL--");
    Branco();
    Console.WriteLine("Digite uma opção:");
    Console.WriteLine("");
    Console.WriteLine("1 - Menu de Produtos");
    Console.WriteLine("2 - Menu de Vendas");
    Console.WriteLine("3 - Sair do Programa");


    if(int.TryParse(Console.ReadLine(), out opcao) == false)
    {
        OpcaoInvalida();
    }else
    {
        switch (opcao)
        {
            case 1:
                //MenuProdutos();
                Console.WriteLine("Menu de produtos");
                opcao = 0;
                break;
            case 2:
                //MenuVendas();
                Console.WriteLine("Menu de vendas");
                opcao = 0;
                break;
            case 3:
            Console.WriteLine("Saindo do programa...");
                opcao = 1;
                break;
            default:
                //OpcaoInvalida();
                break;
        }
    }
}

void OpcaoInvalida(){
    Vermelho();
    Console.WriteLine("Opção inválida");
    Branco();
    Console.WriteLine("Pressione qualquer tecla para continuar");
    Console.ReadKey();
    opcao = 0;
}

void Ciano(){
    Console.ForegroundColor = ConsoleColor.Cyan;
}

void Branco(){
    Console.ForegroundColor = ConsoleColor.White;
}

void Vermelho(){
    Console.ForegroundColor = ConsoleColor.Red;
}
