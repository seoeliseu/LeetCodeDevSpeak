using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasSimples
{
    public class MaiorESegundoMaiorElemento
    {
        public static void ExecutarAlgoritmo() 
        { 
            var listaInteiros = new List<int> { 12, 233, 4, 233, 400 };

            var maior = listaInteiros.First();
            var segundoMaior = listaInteiros.First();
            foreach (var item in listaInteiros)
            {
               if (item > maior)
                {
                    segundoMaior = maior;
                    maior = item;
                }
               else if (item > segundoMaior && item != maior)
                {
                    segundoMaior = item;
                }
            }

            Console.WriteLine($"Maior: {maior}");
            Console.WriteLine($"Segundo Maior: {segundoMaior}");

            Console.ReadKey();
        }
    }
}
