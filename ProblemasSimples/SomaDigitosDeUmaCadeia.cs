namespace ProblemasSimples
{
    public class SomaDigitosDeUmaCadeia
    {
        public static void ExecutarAlgoritmo()
        {
            var x = SomaDigitos2(34353453);
            Console.WriteLine(Solution.PeakIndexInMountainArray3(new int[] {0,1,0}));
            Console.ReadKey();
        }

        public static int SomaDigitos(int numero)
        {
            var numeroString = numero.ToString();

            int somatorio = 0;
            for (int i = 0; i < numeroString.Length; i++)
            {
                var y = Math.Abs(int.Parse(numeroString[i].ToString()));
                somatorio += y;
            }

            return somatorio;
        }

        public static int SomaDigitos2(int numero)
        {
            int somatorio = 0;
            while (numero > 0)
            {
                somatorio += numero % 10;
                numero /= 10;
            }

            return somatorio;
        }

        public class Solution
        {
            public int PeakIndexInMountainArray1(int[] arr)
            {
                var indexPeak = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > arr[indexPeak])
                        indexPeak = i;
                }

                return indexPeak;
            }
            public static int PeakIndexInMountainArray3(int[] arr)
{
    int left = 0;
    int right = arr.Length - 1;

    while (left < right)
    {
        int mid = left + (right - left) / 2;

        // Estamos na parte crescente da montanha
        if (arr[mid] < arr[mid + 1])
        {
            left = mid + 1;
        }
        else // Estamos na parte decrescente ou no pico
        {
            right = mid;
        }
    }

    // left == right é o índice do pico
    return left;
}


            public int PeakIndexInMountainArray2(int[] arr)
            {
                var indexPeak = 0;
                var indexMin = 0;
                var indexMax = arr.Length - 1;

                while (indexMin < indexMax)
                {
                    if (arr[indexPeak] < arr[indexMin])
                        indexPeak = indexMin;

                    if (arr[indexPeak] < arr[indexMax])
                        indexPeak = indexMax;
                }

                return indexPeak;
            }

        }
    }
}
