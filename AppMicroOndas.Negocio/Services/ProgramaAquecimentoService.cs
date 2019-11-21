using AppMicroOndas.Data;
using AppMicroOndas.Data.Interface;
using AppMicroOndas.Entidades.Modelos;
using AppMicroOndas.Negocio.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.Negocio.Services
{
    public class ProgramaAquecimentoService : IProgramaAquecimentoService
    {

        private readonly IMicroOndasService _microOndasService;
        private readonly IProgramaData _data;

        public ProgramaAquecimentoService()
        {
            _microOndasService = new MicroOndasService();
            _data = new ProgramaData();
        }

        public void Valida(MicroOndasModel microondas)
        {
            if (string.IsNullOrEmpty(microondas.Prato))
            {
                throw new Exception("É obrigatório o preenchimento do prato.");
            }

            //verifica se é arquivo de texto e se arquivo existe
            if (microondas.EhArquivo)
            {
                if (!File.Exists(microondas.Prato))
                {
                    throw new Exception("Arquivo não encontrado no caminho definido no prato.");
                }

                var alimentoBandeja = _microOndasService.BuscaResultadoLinha1();
                if (string.IsNullOrEmpty(alimentoBandeja.Trim()))
                {
                    throw new Exception("Arquivo vazio.");
                }
            }

        }

        public void ValidaCustomizado(ProgramaAquecimentoModel programa)
        {
            if (string.IsNullOrEmpty(programa.Nome))
            {
                throw new Exception("Informe o nome do programa.");
            }

            if (programa.Tempo == 0)
            {
                throw new Exception("Informe o tempo de cozimento (1 seg a 120 seg).");
            }

            if (programa.Tempo > 120 || programa.Tempo < 1)
            {
                throw new Exception("Informe o tempo de cozimento (1 seg a 120 seg).");
            }

            if (programa.Potencia > 10 || programa.Potencia < 1)
            {
                throw new Exception("A potência está fora do intervalo permitido (1 a 10).");
            }

            if (programa.AlimentoCompativel == null || programa.AlimentoCompativel.Length == 0)
            {
                throw new Exception("Informe pelo menos uma alimento compativel.");
            }

            if (string.IsNullOrEmpty(programa.Caracter))
            {
                throw new Exception("Informe a pontuação a ser usada pelo programa.");
            }
        }

        public List<ProgramaAquecimentoModel> BuscaCompativel(MicroOndasModel microondas)
        {
            this._microOndasService.SetaMicroondas(microondas);
            this.Valida(microondas);

            List<ProgramaAquecimentoModel> returnList = new List<ProgramaAquecimentoModel>();

            var querySearch = microondas.EhArquivo ? _microOndasService.BuscaResultadoLinha1() : microondas.Prato;

            var searchList = querySearch.ToLower().Split(' ');
            searchList.ToList().ForEach(search =>
            {
                returnList.AddRange(_data.BuscaTodos().Where(p => p.AlimentoCompativel.Any(t => t == search)));
            });

            return returnList;
        }

        public void ValidaCompativel(MicroOndasModel microondas, ProgramaAquecimentoModel programa)
        {
            this._microOndasService.SetaMicroondas(microondas);
            this.Valida(microondas);
            bool compativel = false;

            var querySearch = microondas.EhArquivo ? _microOndasService.BuscaResultadoLinha1() : microondas.Prato;

            var searchList = querySearch.ToLower().Split(' ');
            searchList.ToList().ForEach(search =>
            {
                if (programa.AlimentoCompativel.Any(t => t == search))
                    compativel = true;
            });

            if (!compativel)
            {
                throw new Exception("O alimento informado não é compatível com o programa escolhido.");
            }
        }

        public List<ProgramaAquecimentoModel> BuscaTodos()
        {
            return _data.BuscaTodos();
        }

        public void AdicionaCustomizado(ProgramaAquecimentoModel programa)
        {
            _data.AdicionaCustomizado(programa);
        }

        public void DeletaCustomizado(ProgramaAquecimentoModel programa)
        {
            _data.DeletaCustomizado(programa.Id);
        }

    }
}
