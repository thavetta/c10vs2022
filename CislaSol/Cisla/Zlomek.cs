using System;
using System.Diagnostics;

namespace Cisla
{
    public record struct Zlomek
    {
        private readonly int citatel;
        private readonly int jmenovatel;

        public Zlomek(int citatel, int jmenovatel)
        {
            //Jmenovatel nesmi byt nula
            if (jmenovatel == 0)
                throw new ArgumentNullException("jmenovatel nemuze byt nula");

            //Pokud je citatel nula, je hodnota jmenovatele libovolna nenulova, proto dam vzdy 1
            if (citatel == 0)
            {
                this.citatel = 0;
                this.jmenovatel = 1;
                return;
            }

            //pokud je jmenovatel zaporny, prevedu ho na kladny, aby zaporny byl jen citatel
            if (jmenovatel < 0)
            {
                citatel = -citatel;
                jmenovatel = -jmenovatel;
            }

            //prevod zlomku na zakladni tvar
            var nsd = Vypocty.NSD(Math.Abs(citatel), jmenovatel);

            this.citatel = citatel / nsd;
            this.jmenovatel = jmenovatel / nsd;
        }

        public int Citatel => citatel;

        public int Jmenovatel => jmenovatel;
        
        //public override string ToString()
        //{
        //    return $"[{citatel}/{jmenovatel}]";
        //}
        
        public static Zlomek operator +(Zlomek z1, Zlomek z2)
        {
            int citatel = z1.citatel*z2.jmenovatel + z1.jmenovatel*z2.citatel;
            int jmenovatel = z1.jmenovatel * z2.jmenovatel;
            return new Zlomek(citatel, jmenovatel);
        }
        public static Zlomek operator -(Zlomek z1, Zlomek z2)
        {
            int citatel = z1.citatel * z2.jmenovatel - z1.jmenovatel * z2.citatel;
            int jmenovatel = z1.jmenovatel * z2.jmenovatel;
            return new Zlomek(citatel, jmenovatel);
        }

        public static Zlomek operator *(Zlomek z1, Zlomek z2)
        {
            int citatel = z1.citatel * z2.citatel;
            int jmenovatel = z1.jmenovatel * z2.jmenovatel;
            return new Zlomek(citatel, jmenovatel);
        }

        public static Zlomek operator /(Zlomek z1, Zlomek z2)
        {
            if (z2.citatel == 0)
                throw new DivideByZeroException();

            int citatel = z1.citatel * z2.jmenovatel;
            int jmenovatel = z1.jmenovatel * z2.citatel;
            return new Zlomek(citatel, jmenovatel);
        }

        public static  implicit operator Zlomek(int cislo)
        {
            return new Zlomek(cislo, 1);
        }

        public static explicit operator int(Zlomek z)
        {
            return z.citatel / z.jmenovatel;
        }
    }
}