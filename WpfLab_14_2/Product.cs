using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab_14_2
{
    public enum Categories
    {
        Food,
        DomesticAppliances
    }
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageSourse { get; set; }
        public Categories Category { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
