using AppMicroOndas.Entidades.Enums;
using AppMicroOndas.Entidades.Modelos;
using AppMicroOndas.Negocio.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMicroOndas.Negocio.Services
{
    public class MicroOndasService : IMicroOndasService
    {

        private Timer _timerMicroOndas;
        private int _tempoExecucao;
        private MicroOndasModel _microOndasModel;
        private TextBox _dadosResultado;

        public event EventHandler ConcluidoEvent;
        public event EventHandler ErroEvent;

        public MicroOndasService()
        {
            Inicializa();
        }

        public MicroOndasService(TextBox monitor)
        {
            _dadosResultado = monitor;
            Inicializa();
        }

        private void Inicializa()
        {
            this._tempoExecucao = 0;
            this._timerMicroOndas = new Timer
            {
                Interval = 1000,
                Enabled = true
            };
            this._timerMicroOndas.Stop();
            this._timerMicroOndas.Tick += cronometro_Tick;
        }

        private void cronometro_Tick(object sender, EventArgs e)
        {
            var result = BuscaResultado();
            result += "".PadRight(_microOndasModel.Potencia, char.Parse(_microOndasModel.Caracter));
            SetaResultado(result);
            _tempoExecucao--;
            if (_tempoExecucao == 0)
            {
                _timerMicroOndas.Stop();
                _tempoExecucao = 0;
                ConcluidoEvent("aquecida", EventArgs.Empty);
            }
        }


        public string BuscaResultado()
        {
            if (_microOndasModel.EhArquivo)
            {
                return BuscaResultadoLinha2();
            }
            else
            {
                if (_dadosResultado != null)
                    return _dadosResultado.Text;

                return null;
            }

        }

        public void Cancela()
        {
            _microOndasModel.Status = StatusEnum.Cancelado;
            _timerMicroOndas.Stop();
            SetaResultado("cancelado");
        }

        public void Inicia(MicroOndasModel microondas)
        {
            SetaMicroondas(microondas);

            //validar entradas
            if (!Valida(microondas))
                return;

            //se não for aquivo seta a bandeja no resultado
            if (!this._microOndasModel.EhArquivo)
                this.SetaResultado(microondas.Prato);
            else
                this.SetaResultado(this.BuscaResultadoLinha1());

            _tempoExecucao = microondas.Tempo;
            _microOndasModel.Status = StatusEnum.Executando;
            this._timerMicroOndas.Start();

        }

        public void Pausa()
        {
            if (_microOndasModel.Status == StatusEnum.Executando)
            {
                _microOndasModel.Status = StatusEnum.Pausado;
                _timerMicroOndas.Stop();
                var result = this.BuscaResultado();
                this.SetaResultado(result + "pausado");
            }
            else if (_microOndasModel.Status == StatusEnum.Pausado)
            {
                _microOndasModel.Status = StatusEnum.Executando;
                var result = this.BuscaResultado();
                //result = result.Substring(0, result.Count() - 7);
                //this.SetaResultado(result);
                _timerMicroOndas.Start();
            }

        }

        public void SetaMicroondas(MicroOndasModel microondas)
        {
            _microOndasModel = microondas;

            if (_microOndasModel.EhArquivo)
            {
                SetaResultado(string.Empty);
            }

        }

        public void SetaResultado(string result)
        {
            if (_microOndasModel.EhArquivo)
            {
                string[] lines = new string[] { BuscaResultadoLinha1(), result };
                File.WriteAllLines(_microOndasModel.Prato, lines);
                if (_dadosResultado != null && !string.IsNullOrEmpty(result))
                    _dadosResultado.Text = "Ver arquivo!";
            }
            else
            {
                if (_dadosResultado != null)
                    _dadosResultado.Text = result;
            }

        }

        public bool Valida(MicroOndasModel microondas, bool simples = false)
        {

            if (string.IsNullOrEmpty(microondas.Prato))
            {
                ErroEvent("É obrigatório o preenchimento do prato.", EventArgs.Empty);
                return false;
            }

            if (microondas.EhArquivo)
            {
                if (!File.Exists(microondas.Prato))
                {
                    ErroEvent("Arquivo não encontrado no caminho definido no prato.", EventArgs.Empty);
                    return false;
                }

                var alimentoBandeja = BuscaResultadoLinha1();
                if (string.IsNullOrEmpty(alimentoBandeja.Trim()))
                {
                    ErroEvent("Arquivo vazio.", EventArgs.Empty);
                    return false;
                }
            }

            return true;
        }

        public string BuscaResultadoLinha1()
        {
            if (_microOndasModel.EhArquivo)
            {
                var lines = File.ReadAllLines(_microOndasModel.Prato);
                return lines[0];
            }
            return string.Empty;
        }

        public string BuscaResultadoLinha2()
        {
            if (_microOndasModel.EhArquivo)
            {
                var lines = File.ReadAllLines(_microOndasModel.Prato);
                return lines[1];
            }
            return string.Empty;
        }
    }
}
