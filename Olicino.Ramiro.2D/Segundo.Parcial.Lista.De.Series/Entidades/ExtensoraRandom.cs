using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class ExtensoraRandom
    {
        private static Random random;

        static ExtensoraRandom()
        {
            random = new Random();
        }

        public static int GenerarRandom(this List<Serie> series)
        {
            return random.Next(0, series.Count);
        }
    }
}
