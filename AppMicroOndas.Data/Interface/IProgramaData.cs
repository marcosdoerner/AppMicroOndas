using AppMicroOndas.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.Data.Interface
{
    public interface IProgramaData
    {
        List<ProgramaAquecimentoModel> BuscaTodos();
        void AdicionaCustomizado(ProgramaAquecimentoModel programa);
        void DeletaCustomizado(Guid id);
    }
}
