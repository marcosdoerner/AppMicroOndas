using AppMicroOndas.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.Negocio.Interface
{
    public interface IProgramaAquecimentoService
    {
        void Valida(MicroOndasModel microondas);
        void ValidaCustomizado(ProgramaAquecimentoModel programa);
        void ValidaCompativel(MicroOndasModel microondas, ProgramaAquecimentoModel programa);
        List<ProgramaAquecimentoModel> BuscaCompativel(MicroOndasModel microondas);
        List<ProgramaAquecimentoModel> BuscaTodos();
        void AdicionaCustomizado(ProgramaAquecimentoModel programa);
        void DeletaCustomizado(ProgramaAquecimentoModel programa);

    }
}
