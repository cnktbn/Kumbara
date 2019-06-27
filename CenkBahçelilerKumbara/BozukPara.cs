using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenkBahçelilerKumbara
{
    public class BozukPara : Para
    {
        public const double Onkurus = 0.10;
        public const double YirmibesKurus = 0.25;
        public const double ElliKurus = 0.5;
        public const double BirLira = 1;
        public const double Pi = 3.14;
        public double Deger { get; set; }
        public override double HacimHesapla()
        {
            double hacim = Pi * hYukseklik * (Cap / 2) * (Cap / 2);
            return hacim;
        }
    }
}
