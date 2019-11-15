using AppMicroOndas.Dominio;
using AppMicroOndas.DTO;
using AppMicroOndas.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas
{
    public class FuncionalidadesMicroOndas : IFuncionalidades
    {
        private readonly IProgramaAquecimento _programaAquecimento;
        private readonly IMicroOndas _microOndas;
        private IList<AquecimentoNegocio> lista;

        public FuncionalidadesMicroOndas()
        {
            lista = new List<AquecimentoNegocio>();

            _microOndas = new MicroOndasNegocio();
            _programaAquecimento = new AquecimentoNegocio();
        }

        public ProgramaAquecimentoDTO BuscarProgramaAquecimento(Guid idPrograma)
        {
            return new ProgramaAquecimentoDTO(_programaAquecimento.BuscarPorPrograma(idPrograma, lista));
        }

        public MicroOndasDTO IniciarMicroOndas(int tempo, int potencia, string prato)
        {
            return new MicroOndasDTO(_microOndas.Ligar(tempo, potencia, prato));
        }

        public MicroOndasDTO InicioRapido(string prato)
        {
            return new MicroOndasDTO(_microOndas.InicioRapido(prato));
        }

        public IList<ProgramaAquecimentoDTO> ListarProgramasAquecimento()
        {
            lista = _programaAquecimento.ListarTodosProgramasAquecimento(lista);
            return lista.Select(x => new ProgramaAquecimentoDTO(x)).ToList();
        }
    }
}
