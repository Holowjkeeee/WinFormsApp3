using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public enum MeasureType { cel, far, ran, kelv };
    public class Tempreture
    {
        private double value;
        private MeasureType type;
        public Tempreture(double value, string type)
        { this.value = value;
            this.type = type;
        }
        public string Verbose()
        {
            return String.Format("{0}{1}", this.value, this.type); 
            }
    }
}
