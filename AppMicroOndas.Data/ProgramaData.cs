using AppMicroOndas.Data.Interface;
using AppMicroOndas.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.Data
{
    public class ProgramaData : IProgramaData
    {
        public List<ProgramaAquecimentoModel> BuscaTodos()
        {
            List<ProgramaAquecimentoModel> result = new List<ProgramaAquecimentoModel>();
            result.AddRange(ProgramasPreDefinidos.ProgramaLista);
            return result;
        }

        public void AdicionaCustomizado(ProgramaAquecimentoModel programa)
        {
            programa.Estendido = true;
            ProgramasPreDefinidos.ProgramaLista.Add(programa);
        }

        public void DeletaCustomizado(Guid id)
        {
            var programa = ProgramasPreDefinidos.ProgramaLista.FirstOrDefault(p => p.Id == id);
            ProgramasPreDefinidos.ProgramaLista.Remove(programa);
        }
    }
}
