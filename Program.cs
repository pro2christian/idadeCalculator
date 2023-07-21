class App
{
    static void Main(string[] args)
    {
        Pessoa p = new Pessoa();
        
        Console.WriteLine("Digite seu Nome:");
        p.Nome = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Digite o ano do seu nascimento:");
        p.AnoNascimento = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        p.exibirDados();

    }
}

