using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.Entidades.Modelos
{
    public class ProgramaAquecimentoModel : BaseModel, ICloneable
    {
        public ProgramaAquecimentoModel()
        {
            Id = Guid.NewGuid();
            Estendido = false;
        }

        public object Clone()
        {
            var clone = this.MemberwiseClone();
            this.Id = Guid.NewGuid();
            return clone;
        }


        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Instrucao { get; set; }
        public string[] AlimentoCompativel { get; set; }
        public bool Estendido { get; set; }

        public string TipoPrograma { get { return Estendido ? "Sim" : string.Empty; } }

    }
}
