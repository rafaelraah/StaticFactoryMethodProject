using System;

namespace StaticFactoryMethodProject
{
    public class GeradorIntAleatorio
    {
        int min;
        int max;

        const int VALOR_MINIMO = 0;
        const int VALOR_MAXIMO = int.MaxValue;

        private GeradorIntAleatorio(int min, int max)
        {
            this.min = Math.Min(min, max);
            this.max = Math.Max(min, max);
        }
        public static GeradorIntAleatorio getInstanceEntre(int min, int max)
        {
            return new GeradorIntAleatorio(min, max);
        }
        public static GeradorIntAleatorio getInstanceMaiorQue(int min)
        {
            return new GeradorIntAleatorio(min, VALOR_MAXIMO);
        }
        public static GeradorIntAleatorio getInstanceMenorQue(int max)
        {
            return new GeradorIntAleatorio(VALOR_MINIMO, max);
        }
    }
}