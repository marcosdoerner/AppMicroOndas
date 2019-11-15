using AppMicroOndas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.Interface
{
    public interface IProgramaAquecimento
    {
        AquecimentoNegocio BuscarPorPrograma(Guid idPrograma, IList<AquecimentoNegocio> lista);
        IList<AquecimentoNegocio> ListarTodosProgramasAquecimento(IList<AquecimentoNegocio> lista);
        IList<AquecimentoNegocio> IncluirPrograma(AquecimentoNegocio aquecimento, IList<AquecimentoNegocio> lista);
        
    }
}
