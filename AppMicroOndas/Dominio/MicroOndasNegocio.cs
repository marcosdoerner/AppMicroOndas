using AppMicroOndas.Enums;
using AppMicroOndas.Interface;
using AppMicroOndas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.Dominio
{
    public class MicroOndasNegocio : MicroOndasModel, IMicroOndas
    {
        public MicroOndasNegocio()
        {

        }

        public MicroOndasNegocio(int tempo, int potencia, string prato)
        {
            Tempo = tempo;
            Potencia = potencia;
            Prato = prato;

            ValidacoesModel();
        }

        public MicroOndasNegocio InicioRapido(string prato)
        {
            return new MicroOndasNegocio((int)PadraoEnum.InicioRapidoTempo, (int)PadraoEnum.InicioRapidoPodencia, prato);
        }

        public MicroOndasNegocio Ligar(int tempo, int potencia, string prato)
        {
            return new MicroOndasNegocio(tempo, potencia, prato);

        }
    }
}
