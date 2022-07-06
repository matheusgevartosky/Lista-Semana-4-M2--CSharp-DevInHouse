namespace ConsoleApp2;

public static class MetodosDeExtensao
{
    public static string mostraMensagem(this bool a)
    {
        if (a)
            return "Verdadeiro";
        else
            return "falso";
    }

    public static int multiplica(this int a)
    {
        return  a * a;
    }

    public static decimal multiplica(this decimal a)
    {
        return a * a;
    }

    public static int multiplica(this int a, int b, int c)
    {
        return a * b * c;
    }
    
    public static int multiplica(this int a, int b, int c , int d = 1)
    {
        return a * b * c * d;
    }
    
}