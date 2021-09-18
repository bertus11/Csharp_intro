using System;

namespace DIO
{
    class Program
    {
        static void Main()
        {
            int x, y;
            string operacao;

            Console.WriteLine("Qual operação deseja realizar?");
            Console.WriteLine("Digite [SOMA] para somar");
            Console.WriteLine("Digite [SUB] para subtrair");
            Console.WriteLine("Digite [MULTI] para multiplicar");
            Console.WriteLine("Digite [DIV] para dividir");
            operacao = Console.ReadLine();
            
            switch(operacao)
            {
                case "SOMA":
                Console.WriteLine("Insira um valor para X: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira um valor para Y: ");
                y = int.Parse(Console.ReadLine());
                Console.Write(x+y);
                break;
                case "SUB":
                Console.WriteLine("Insira um valor para X: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira um valor para Y: ");
                y = int.Parse(Console.ReadLine());
                Console.Write(x-y);
                break;
                case "MULTI":
                Console.WriteLine("Insira um valor para X: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira um valor para Y: ");
                y = int.Parse(Console.ReadLine());
                Console.Write(x*y);
                break;
                case "DIV":
                Console.WriteLine("Insira um valor para X: ");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Insira um valor para Y: ");
                y = int.Parse(Console.ReadLine());
                Console.Write(x/y);
                break;
            }

        }
    }
}
