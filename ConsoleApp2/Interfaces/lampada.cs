class Conta
{
    public string Nome { get; private set; }
    public int NumeroConta { get; private set; }
    public double Saldo { get; private set; }

    public Conta(string nome, int numeroConta, double saldo)
    {
        Nome = nome;
        NumeroConta = numeroConta;
        Saldo = saldo;
    }

    public void Depositar(double dep)
    {
        Saldo += dep;
        Console.WriteLine($"Depósito de {dep} efetuado. Saldo atual é de {Saldo}");
    }

    public void Sacar(double saque)
    {
        if (saque > Saldo)
        {
            Console.WriteLine($"Não é possivel efetuar um saque de R$ {saque}. o saldo atual é de {Saldo}");
        }
        else
        {
            Saldo -= saque;
            Console.WriteLine($"Saque de {saque} efetuado. saldo atual {Saldo}");
        }
    }
}