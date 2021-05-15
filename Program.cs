using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--Bhaskara--\n");
            Console.ResetColor();

            double a;
            double b;
            double c;
            double x1;
            double x2;
            double delta;

            Console.WriteLine("Calcule as raízes de uma equação de segundo grau, utilizando o método de Bhaskara.");
            Console.WriteLine("Para isso, insira as seguintes informações: \n");

            Console.Write("Valor de 'a'..: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            a = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.Write("Valor de 'b'..: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            b = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.Write("Valor de 'c'..: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            c = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            delta = (b*b) - (4 * a * c);
            
            if (a == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nIsso não é uma equeção de segundo grau!\n");
                Console.ResetColor();
            }
            if (delta <0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nA equação não possuí raízes reais!\n");
                Console.ResetColor();
            }
            else 
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a );
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nSeu resultado é..: x1 = {x1:N2} e x2 = {x2:N2}.\n");
                Console.ResetColor();
            }
            
            



        }
    }
}
