using AppMicroOndas.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.Interface
{
    public interface IFuncionalidades
    {
        MicroOndasDTO IniciarMicroOndas(int tempo, int potencia, string prato);
        MicroOndasDTO InicioRapido(string prato);

        IList<ProgramaAquecimentoDTO> ListarProgramasAquecimento();
        ProgramaAquecimentoDTO BuscarProgramaAquecimento(Guid idPrograma);
//        ProgramaAquecimentoDTO PesquisarProgramaAquecimento(string prato);

    }
}
