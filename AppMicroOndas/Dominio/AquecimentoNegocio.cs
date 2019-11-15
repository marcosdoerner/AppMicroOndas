using AppMicroOndas.Interface;
using AppMicroOndas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.Dominio
{
    public class AquecimentoNegocio : MicroOndasModel, IProgramaAquecimento
    {

        public AquecimentoNegocio()
        {

        }

        public AquecimentoNegocio(Guid id, string nome, int potencia, int tempo)
        {
            Id = id;
            Tempo = tempo;
            Potencia = potencia;
            Nome = nome;

            ValidarPrograma();
        }

        public AquecimentoNegocio BuscarPorPrograma(Guid idPrograma, IList<AquecimentoNegocio> lista)
        {
            return lista.Where(x => x.Id == idPrograma).FirstOrDefault();
        }

        public IList<AquecimentoNegocio> IncluirPrograma(AquecimentoNegocio aquecimento, IList<AquecimentoNegocio> lista)
        {
            if (aquecimento.Id == Guid.Empty)
                aquecimento.Id = Guid.NewGuid();
            if (lista.Count() == 0)
                lista = CarregarListaAquecimento().ToList();
            lista.Add(aquecimento);
            return lista;

        }

        public IList<AquecimentoNegocio> ListarTodosProgramasAquecimento(IList<AquecimentoNegocio> lista)
        {
            if (lista.Count() == 0)
                lista = CarregarListaAquecimento().ToList();
            return lista.ToList();
        }

        private IList<AquecimentoNegocio> CarregarListaAquecimento()
        {
            var lista = new List<AquecimentoNegocio>
            {
                new AquecimentoNegocio(Guid.NewGuid(), "Macarrão Instantaneo", 2, 30),
                new AquecimentoNegocio(Guid.NewGuid(), "Frango", 4, 45),
                new AquecimentoNegocio(Guid.NewGuid(), "Lasanha", 6, 70),
                new AquecimentoNegocio(Guid.NewGuid(), "Ovo", 8, 90),
                new AquecimentoNegocio(Guid.NewGuid(), "Carne Bovina", 3, 100)
            };

            return lista;
        }

        private void ValidarPrograma()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                Mensagem = "O nome do programa não pode ficar em branco.";
                Valido = false;
                return;
            }

            ValidacoesModel();
        }

    }
}
