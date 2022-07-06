namespace ConsoleApp2;

class Lampada : ILampada
{
    public bool Status { get; private set; }
    public int Potencia { get; private set; }
    public int Voltagem { get; private set; }

    public  void SetStatus()
    {
        Status = !Status;
    }

    public  void SetStatus(int pow, int v, bool status)
    {
        Potencia = pow;
        Voltagem = v;
        Status = status;
    }
}

