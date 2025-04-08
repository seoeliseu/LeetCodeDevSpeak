namespace ProblemasSimples
{
    public class PercorrerMatrizEspiralLeetCode
    {
        public static void ExecutarAlgoritmo()
        {
            var matriz = new int[3, 9]
            {
                {1, 2, 3, 4, 5, 6, 7, 8, 9},
                {4, 5, 6, 4, 5, 6, 7, 8, 9},
                {7, 8, 9, 4, 5, 6, 7, 8, 9}
            };
            var resultado = PercorrerMatrizEspiral(matriz);
            Console.WriteLine(string.Join(", ", resultado));
            Console.ReadKey();
        }
        public static List<int> PercorrerMatrizEspiral(int[,] matriz)
        {
            List<int> resultado = [];
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            int inicioLinha = 0;
            int fimLinha = linhas - 1;
            int inicioColuna = 0;
            int fimColuna = colunas - 1;

            while (inicioLinha <= fimLinha && inicioColuna <= fimColuna)
            {
                // Percorre a linha superior
                for (int i = inicioColuna; i <= fimColuna; i++)
                {
                    resultado.Add(matriz[inicioLinha, i]);
                }
                inicioLinha++;

                // Percorre a coluna direita
                for (int i = inicioLinha; i <= fimLinha; i++)
                {
                    resultado.Add(matriz[i, fimColuna]);
                }
                fimColuna--;

                // Verifica se ainda há linhas e colunas restantes
                if (inicioLinha <= fimLinha)
                {
                    // Percorre a linha inferior
                    for (int i = fimColuna; i >= inicioColuna; i--)
                    {
                        resultado.Add(matriz[fimLinha, i]);
                    }
                    fimLinha--;
                }
                if (inicioColuna <= fimColuna)
                {
                    // Percorre a coluna esquerda
                    for (int i = fimLinha; i >= inicioLinha; i--)
                    {
                        resultado.Add(matriz[i, inicioColuna]);
                    }
                    inicioColuna++;
                }
            }
            return resultado;
        }
    }
}
