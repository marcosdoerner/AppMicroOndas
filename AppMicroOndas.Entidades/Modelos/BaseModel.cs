using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.Entidades.Modelos
{
    public class BaseModel
    {
        public string TempoTxt { get; set; }
        public string PotenciaTxt { get; set; }
        public int Tempo { get { return int.Parse(TempoTxt); } }
        public int Potencia { get { return int.Parse(PotenciaTxt); } }
        public string Caracter { get; set; }

    }
}
