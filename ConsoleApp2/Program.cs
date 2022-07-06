using ConsoleApp2;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite o Nome");
        string? nome = Console.ReadLine();
        Console.WriteLine(("Digite a idade do paciente"));
        int idade = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("Digite o peso");
        double peso = double.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine("Digite a altura");
        double altura = double.Parse(Console.ReadLine() ?? string.Empty);

        Pessoa pessoa = new Pessoa(nome, idade, peso, altura);
        if (pessoa == null) throw new ArgumentNullException(nameof(pessoa));

        pessoa.CalculaIMC();
    }
}