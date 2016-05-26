using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVXWYZ";

        static void Main(string[] args)
        {
            Console.WriteLine("Digite a letra para formar diamante");
            var letra = Console.ReadLine().ToUpper();
            var casas = alfabeto.Substring(0, alfabeto.IndexOf(letra) + 1).Length;

            for (int i = 0; i < casas; i++)
            {
                ProcessarDiamante(casas, i);
            }

            for (int i = casas - 2; i >= 0; i--)
            {
                ProcessarDiamante(casas, i);
            }

            Console.ReadLine();
        }

        private static void ProcessarDiamante(int casas, int i)
        {
            var texto = alfabeto.ToArray()[i].ToString();
            if (i == 1)
            {
                texto = texto + " " + texto;
            }
            else
                if (i > 1)
                {
                    var espacos = " ";
                    for (int x = 2; x <= i; x++)
                    {
                        espacos += "  ";
                    }
                    texto = texto + "" + espacos + "" + texto;
                }

            exibirMensagem(casas, i, texto);
        }

        private static void exibirMensagem(int casas, int i, string texto)
        {
            var espacos = "";
            for (int x = 0; x < casas - (i + 1); x++)
            {
                espacos += " ";
            }
            Console.WriteLine(espacos + "" + texto);
        }
    }
}
