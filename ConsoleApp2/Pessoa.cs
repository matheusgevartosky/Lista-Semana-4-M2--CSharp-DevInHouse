namespace ConsoleApp2;

class Pessoa
{
    public string? Nome { get; private set; }
    public int Idade { get; private set; }
    public double Peso { get; private set; }
    public double Altura { get; private set; }
    public double IMC { get; private set; }

    public Pessoa(string? nome, int idade, double peso, double altura)
    {
        Nome = nome;
        Idade = idade;
        Peso = peso;
        Altura = altura;
    }


    public void CalculaIMC()
    {
        IMC = Peso / (Altura * Altura);

        if (IMC < 18.5)
        {
            Console.WriteLine($"O paciente {Nome} está ABAIXO DO PESO");
        }
        else if (IMC > 18.5 && IMC < 25)
        {
            Console.WriteLine($"O paciente {Nome} está com o peso correto");
        }
        else if (IMC > 25)
        {
            Console.WriteLine($"O paciente {Nome} está com sobre peso");
        }
    }
}