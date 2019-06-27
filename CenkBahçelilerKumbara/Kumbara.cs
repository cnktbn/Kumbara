using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenkBahçelilerKumbara
{
    public class Kumbara : IKırılabilirlik, ISallanabilirlik, IYapistirilabilirlik
    {
        public double KumbaraHacim { get; set; }
        public List<BozukPara> BozukParaKumbaraListesi = new List<BozukPara>();
        public List<Para> KumbaraListesi = new List<Para>();
        public double Paralarinhacmi { get; set; }
        public bool KirildiMi { get; set; }
        public bool SallandiMi { get; set; }
        public bool YapistiMi { get; set; }
        public Kumbara()
        {
            KirildiMi = false;
            SallandiMi = false;
        }
        public double Salla(double hacim)
        {
            double sayi = hacim * 0.25;
            return sayi;
        }



    }
}
