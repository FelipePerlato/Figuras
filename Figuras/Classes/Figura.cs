using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras.Classes.Enums;

namespace Figuras.Classes
{
    internal abstract class Figura
    {
        public Color Cor { get; set; }

      

        public Figura(Color cor)
        {
            Cor = cor;
        }

        public abstract  double Area();
   
    }
}
