using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cisla
{
    public static class Vypocty
    {
        /// <summary>
        /// Vypocet největšího společného dělitele dvou přirozených čísel Euklidovým algoritmem
        /// </summary>
        /// <param name="x">přirozené číslo</param>
        /// <param name="y">přirozené číslo</param>
        /// <returns>největší společný dělitel</returns>
        /// <exception cref="ArgumentOutOfRangeException">vstupní parametry musí být větší než nula</exception>
        public static int NSD(int x, int y)
        {
            if (x < 1 || y < 1)
                throw new ArgumentOutOfRangeException("NSD pocita jen pro prirozena cisla");

            if (x == 1 || y == 1)
                return 1;

            if (x < y)
            {
                (x, y) = (y, x);
            }

            do
            {
                int temp = x % y;
                x = y;
                y = temp;
            } while (y != 0) ;
            
            return x;
        }
    }
}
