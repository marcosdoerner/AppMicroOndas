using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.Model
{
    public class MicroOndasModel
    {
        public int Tempo { get; set; }
        public int Potencia { get; set; }
        public string Prato { get; set; }
        public bool Valido { get; protected set; }
        public string Mensagem { get; protected set; }

        public Guid Id { get; set; }
        public string Nome { get; set; }

        internal void ValidacoesModel()
        {
            Valido = false;
            if (Tempo < 1 || Tempo > 120)
            {
                Mensagem = "O Tempo de aquecimento deve ser de 1 a 120 segundos (2 minutos).";
                return;
            }

            if (Potencia < 1 || Potencia > 10)
            {
                Mensagem = "A Potência deve ser de 1 a 10.";
                return;
            }

            Valido = true;
        }
    }
}
