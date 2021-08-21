using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Database
{
    public class Parametro
    {

        public string NombreParametro { get; set; }
        public dynamic Valorparametro { get; set; }

        public Parametro(string NombreParametro_,dynamic Valorparametro_)
        {
            NombreParametro = NombreParametro_;
            Valorparametro = Valorparametro_;
        }
    }
}
