using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenkBahçelilerKumbara
{
    class KagitPara : Para, IKatlanabilirlik
    {
        public const int BesLira = 5;
        public const int OnLira = 10;
        public const int YirmiLira = 20;
        public const int ElliLira = 50;
        public const int YuzLira = 100;
        public const int ikiyuzLira = 200;
        public double Deger { get; set; }
        public bool KatlandiMi { get; set; }

        public override double HacimHesapla()
        {
            double hacim = hYukseklik * En * Boy;
            return hacim;
        }
    }
}
