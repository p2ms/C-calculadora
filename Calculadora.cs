using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace des23
{
    class Program
    {
        static void Main(string[] args)
        {
            string ope, resp;
            int num1, num2, resul;
            
            do
            {
                Console.Write("Digite um numero: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite a operação(+,-,*,/): ");
                ope = Console.ReadLine();
                Console.Write("Digite outro numero: ");
                num2 = int.Parse(Console.ReadLine());

                if (ope == "+")
                {
                    resul = num1 + num2;
                    Console.WriteLine(resul);
                }
                if (ope == "-")
                {
                    resul = num1 - num2;
                    Console.WriteLine(resul);
                }
                if (ope == "*")
                {
                    resul = num1 * num2;
                    Console.WriteLine(resul);
                }
                if(ope == "/" && num2 == 0)
                {
                    Console.WriteLine("Não é possivel dividir por zero");
                }
                else if (ope == "/")
                {
                    resul = num1 / num2;
                    Console.WriteLine(resul);
                }
                Console.ReadKey();
                Console.WriteLine("Deseja sair? [s/n]");
                resp = Console.ReadLine();
                Console.Clear();
            } while (resp != "s" && resp != "S");
        }
    }
}
