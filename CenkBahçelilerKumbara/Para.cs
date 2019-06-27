using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenkBahçelilerKumbara
{
    public abstract class Para
    {
        public double Hacim { get; set; }
        public double hYukseklik { get; set; }
        public double En { get; set; }
        public double Boy { get; set; }
        public double Cap { get; set; }
        public abstract double HacimHesapla();
    }
}
