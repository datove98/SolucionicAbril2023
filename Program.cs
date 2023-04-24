
using System;
using System.Text.RegularExpressions;



Console.WriteLine("Ingrese el valor maximo de la serie de Fibonacci");

int valorMaximo = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el numero de valor que se mostraran de la serie de Fibonacci");

int valorMostrar = int.Parse(Console.ReadLine());

Fibonacci fibonacci = new Fibonacci();

fibonacci.ObtenerFibonacci(valorMaximo, valorMostrar);

Console.ReadKey();




public class Fibonacci
{
    public void ObtenerFibonacci(int valorMaximo, int valoresMostrar)
    {
        int valorFibonacci = 0;
        int valorInicial = 1;
        List<int> arrValoresMostrar = new List<int>();
        while (valorFibonacci <= valorMaximo)
        {
            Console.Write(valorFibonacci + " ");
            arrValoresMostrar.Add(valorFibonacci);
            int temporal = valorFibonacci;
            valorFibonacci = valorInicial;
            valorInicial = temporal + valorFibonacci;
        }

        Console.Write("\n");
        
        arrValoresMostrar.Reverse();

        for (int i = valoresMostrar; i > 0; i--)
        {
            Console.Write( " " + arrValoresMostrar[i - 1]);
        }

    }
} 





























//while (true)
//{

//    try
//    {
//        Console.WriteLine("Introduzca el primer numero entero");
//        var cadena = Console.ReadLine();
//        int num = Convert.ToInt32(cadena);
//        Console.WriteLine("El fatorial de " + num + " es: " + Prueba.ObtenerFactorial(num));
//        Console.ReadKey();

//    }
//    catch (Exception e)
//    {
//        Console.WriteLine("Ingresar un numeor entero " + e.Message);
//    }
//}

//Regex Regex = new Regex("^[0-9]*$");

//if (Regex.IsMatch(cadena))
//{
//    int num = Convert.ToInt32(cadena);
//    Console.WriteLine("El fatorial de " + num + " es: " + Prueba.ObtenerFactorial(num));
//}


//public class Prueba
//{
//    public static int ObtenerFactorial(int num)
//    {
//        Console.WriteLine("numero: " + num);
//        int valor = 0;
//        if (num == 1) return 1;
//        Console.WriteLine("valor: " + valor);
        
//        return num * ObtenerFactorial(num - 1);

//    }
//}

