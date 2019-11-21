using AppMicroOndas.Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMicroOndas.Negocio.Interface
{
    public interface IMicroOndasService
    {
        bool Valida(MicroOndasModel microondas, bool simples = false);
        void Inicia(MicroOndasModel microondas);
        void Cancela();
        void Pausa();
        string BuscaResultado();
        string BuscaResultadoLinha1();
        void SetaResultado(string result);
        void SetaMicroondas(MicroOndasModel microondas);

        event EventHandler ConcluidoEvent;
        event EventHandler ErroEvent;

    }
}
