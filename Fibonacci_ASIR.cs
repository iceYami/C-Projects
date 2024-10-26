class Program

{
static void Main()

    {int n;
    do

     {Console.Write("Introduce un número entero entre 7 y 22: ");
      n = Convert.ToInt32(Console.ReadLine());} while (n < 7 || n > 22);

        int a = 0, b = 1;
        Console.WriteLine("Secuencia de Fibonacci:");

        for (int i = 0; i < n; i++)

        {Console.Write(a + " ");
            int temp = a;
            a = b;
            b = temp + b;}

        Console.WriteLine();

        Console.WriteLine("Fibonacci reverse:");

        for (int i = n - 1; i >= 0; i--)
        {Console.Write((i == 0 ? 0 : (i == 1 ? 1 : (b - a))) + " ");
            int temp = a;
            a = b;
            b = temp + b;}

        Console.WriteLine();}
