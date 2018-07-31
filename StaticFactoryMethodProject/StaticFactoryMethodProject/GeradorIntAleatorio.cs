using System;

namespace StaticFactoryMethodProject
{
    public class GeradorIntAleatorio
    {
        int min;
        int max;
        private GeradorIntAleatorio(int min, int max)
        {
            this.min = Math.Min(min, max);
            this.max = Math.Max(min, max);
        }
        public static GeradorIntAleatorio getInstanceEntre(int min, int max)
        {
            return new GeradorIntAleatorio(min, max);
        }
    }
}