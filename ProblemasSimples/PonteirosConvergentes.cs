using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemasSimples
{
    public class PonteirosConvergentes
    {
        public static void ExecutarAlgoritmo()
        {
            var ehPalindromo = VerificarPalindromo("eliseu");
            if (ehPalindromo)
            {
                Console.WriteLine("É palíndromo");
            }
            else
            {
                Console.WriteLine("Não é palíndromo");
            }
            
            Console.ReadKey();
        }

        private static bool VerificarPalindromo(string palavra)
        {
            var ponteiro1 = 0;
            var ponteiro2 = palavra.Length - 1;

            while (ponteiro1 <= ponteiro2)
            {
                Console.WriteLine($"ponteiro1: {palavra[ponteiro1]} - ponteiro2: {palavra[ponteiro2]}");
                if (palavra[ponteiro1] != palavra[ponteiro2])
                    return false;

                ponteiro1++;
                ponteiro2--;
            }

            return true;
        }
    }
}
