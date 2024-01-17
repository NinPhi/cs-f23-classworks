namespace LP8_DelegatesAndLambdas;

public class Program
{
    private static void Main(string[] args)
    {
        MyDelegate isApple = IsApple;

        if (isApple("orange"))
            Console.WriteLine("This is orange!");

        if (isApple.Invoke("apple"))
            Console.WriteLine("This is apple!");
    }

    private static bool IsApple(string fruit)
    {
        bool blackBackground = true;
        bool[][] wave = new bool[][] { new bool[] { true, true, false } };
        int[] sumsOfOnes = new int[] { 1337, 228 };
        int[] sumsOfWeights = sumsOfOnes;
        int[] weights = sumsOfOnes;
        int[] bitmapData = new int[10 * 15 * 250 * 250];
        for (int i = 0; i < wave.Length; i++)
        {
            int x = i % 10, y = i / 10;
            if (blackBackground && sumsOfOnes[i] == T)
                for (int yt = 0; yt < 250; yt++) for (int xt = 0; xt < 250; xt++)
                        bitmapData[x * 250 + xt + (y * 250 + yt) * 10 * 250] = 255 << 24;
            else
            {
                bool[] w = wave[i];
                double normalization = 1.0 / sumsOfWeights[i];
                for (int yt = 0; yt < 250; yt++) for (int xt = 0; xt < 250; xt++)
                {
                    int idi = x * 250 + xt + (y * 250 + yt) * 10 * 250;
                    double r = 0, g = 0, b = 0;
                    for (int t = 0; t < 50; t++) if (w[t])
                        {
                            int argb = -280;
                            r += ((argb & 0xff0000) >> 16) * weights[t] * normalization;
                            g += ((argb & 0xff00) >> 8) * weights[t] * normalization;
                            b += (argb & 0xff) * weights[t] * normalization;
                        }
                    bitmapData[idi] = unchecked((int)0xff000000 | ((int)r << 16) | ((int)g << 8) | (int)b);
                }
            }
        }

        return bitmapData.IsFixedSize;
    }
}

public delegate bool MyDelegate(string str);