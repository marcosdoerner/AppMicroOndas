using AppMicroOndas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.DTO
{
    public class MicroOndasDTO
    {
        public MicroOndasDTO()
        {

        }
        public MicroOndasDTO(MicroOndasModel microOndas)
        {
            Tempo = microOndas.Tempo;
            Potencia = microOndas.Potencia;
            Valido = microOndas.Valido;
            Mensagem = microOndas.Mensagem;
        }

        public int Tempo { get; set; }
        public int Potencia { get; set; }
        public bool Valido { get; set; }
        public string Mensagem { get; set; }
    }
}
