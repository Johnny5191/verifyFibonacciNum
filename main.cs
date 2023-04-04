using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c = 1;
        while (c < num)
        {
            a = b;
            b = c;
            c = a + b;
        }

        if (c == num)
        {
            Console.WriteLine("{0} pertence à sequência de Fibonacci.", num);
        }
        else
        {
            Console.WriteLine("{0} não pertence à sequência de Fibonacci.", num);
        }
    }
}