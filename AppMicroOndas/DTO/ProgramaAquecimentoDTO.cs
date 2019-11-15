using AppMicroOndas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.DTO
{
    public class ProgramaAquecimentoDTO : MicroOndasDTO
    {
        public ProgramaAquecimentoDTO(MicroOndasModel microOndas)
        {
            Id = microOndas.Id;
            Nome = microOndas.Nome;
            Tempo = microOndas.Tempo;
            Potencia = microOndas.Potencia;
            Valido = microOndas.Valido;
            Mensagem = microOndas.Mensagem;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        
    }
}
