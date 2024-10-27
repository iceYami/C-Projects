using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 0;

        Console.Write("Inserta el número de elementos de Fibonacci a calcular: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out n) && n >= 0)
        {
           
            int[] fibonacci = new int[n];
            if (n > 0) fibonacci[0] = 0; 

            if (n > 1) fibonacci[1] = 1; 

            for (int i = 2; i < n; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2]; 
            }

            Console.WriteLine("Secuencia de Fibonacci:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(fibonacci[i] + " ");
            }
            Console.WriteLine(); 

            Console.WriteLine("Secuencia de Fibonacci invertida:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(fibonacci[i] + " ");
            }
            Console.WriteLine(); 
        }

        Console.WriteLine("Escribe 'exit' para salir:");
        string exitCommand = Console.ReadLine();

        if (exitCommand.ToLower() == "exit")
        {
            return; 
        }
    }
}
