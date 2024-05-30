using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaBinaria
{
    internal class Program
    {
    public static void Main(string[] args)
        {
            int[] lista = { 1,3,5,7,12};

            Console.WriteLine(BuscaBinaria(lista,7));
            Console.ReadKey();
        }

        static object BuscaBinaria(int[] pesquisa, int numero)
        {
            int comeco = 0;
            int fim = pesquisa.Length - 1;

            while(comeco <= fim)
            {
            int meio = (comeco + fim) / 2;
            int chute = pesquisa[meio];
            if(chute == numero)
                {
                    return meio;
                }
            if(chute > numero)
                {
                    fim = meio - 1;
                }
                else
                {
                    comeco = meio + 1;   
                }
            }
            return "Indice: Nao Valido";
        }
    }
}
