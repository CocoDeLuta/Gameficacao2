
    
    foreach(var item in Enum.GetValues(typeof(Teste)))
    {
        Console.WriteLine(item);
    }

    Console.WriteLine((int)Teste.Camisas);



public enum Teste{
        Acessorios,
        Camisas,
        Sapatos,
        Meias,
        Calças,
    }