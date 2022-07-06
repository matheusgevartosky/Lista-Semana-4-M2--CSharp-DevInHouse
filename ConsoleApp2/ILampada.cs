namespace ConsoleApp2;

public interface ILampada
{
    bool Status { get;   }
    int Voltagem { get;   }
    int Potencia { get;   }

    void SetStatus();
}