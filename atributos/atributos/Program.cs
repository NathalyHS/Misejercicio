using System;

class Program
{

    static void Main(string[] args)

    {
        aprendiz apsena = new aprendiz();
        apsena.Nombres = "Nathalia";
        apsena.apellidos = "Hernandez Santos";
        apsena.Direccion = "cll A 23 # 45 ";
        saludo(apsena); 
    }
    private static void saludo(aprendiz apsena)
    {
        Console.WriteLine("bienvenido, sr(a )" + apsena.Nombres);
        Console.WriteLine(apsena.apellidos);
         Console.WriteLine(apsena.Direccion);
        Console.ReadLine();
    }
}

