using AppMicroOndas.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.Interface
{
    public interface IMicroOndas
    {
        MicroOndasNegocio Ligar(int tempo, int potencia, string prato);
        MicroOndasNegocio InicioRapido(string prato);
    }
}
