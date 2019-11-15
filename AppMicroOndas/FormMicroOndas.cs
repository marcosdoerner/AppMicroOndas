using AppMicroOndas.DTO;
using AppMicroOndas.Enums;
using AppMicroOndas.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMicroOndas
{
    public partial class FormMicroOndas : Form
    {
        int tempoExecucao;
        private IFuncionalidades _funcionalidades;
        private IList<ProgramaAquecimentoDTO> listaAquecimentos;
        bool carga;
        public FormMicroOndas()
        {
            InitializeComponent();

            InicializarMicroondas();
        }

        private void InicializarMicroondas()
        {
            _funcionalidades = new FuncionalidadesMicroOndas();

            LimparDados();
            CriarListaProgramasAquecimento();
        }

        private void CriarListaProgramasAquecimento()
        {
            carga = true;
            var listaAquecimentos = _funcionalidades.ListarProgramasAquecimento().ToList();
            cmbPrograma.DataSource = null;
            cmbPrograma.DataSource = listaAquecimentos;
            cmbPrograma.ValueMember = "Id";
            cmbPrograma.DisplayMember = "Nome";
            cmbPrograma.SelectedIndex = -1;
            carga = false;

        }

        private void button_ligar_Click(object sender, EventArgs e)
        {
            int tempo;
            int potencia;

            if (string.IsNullOrEmpty(txtPrato.Text))
            {
                lblMensagem.Text = "É obrigatório o preenchimento do prato.";
                return;
            }

                

            if (!int.TryParse(txtTempo.Text, out tempo))
            {
                lblMensagem.Text = "É obrigatório o preenchimento do campo Tempo.";
                return;
            }

            if (!int.TryParse(txtPotencia.Text, out potencia))
            {
                lblMensagem.Text = "É obrigatório o preenchimento do campo Potência.";
                return;
            }

            var iniciarMicroOndas = _funcionalidades.IniciarMicroOndas(tempo, potencia, txtPrato.Text );

            if (iniciarMicroOndas.Valido)
            {
                IniciarCronometro(iniciarMicroOndas.Tempo);
            }
            else 
            {
                lblMensagem.Text = iniciarMicroOndas.Mensagem;
            }
        }

        private void IniciarCronometro(int tempo)
        {
            tempoExecucao = tempo;
            lblPonto.Text = txtPrato.Text;
            cronometro.Start();
        }

        private void cronometro_Tick(object sender, EventArgs e)
        {
            tempoExecucao--;

            lblMensagem.Text = Convert.ToString(tempoExecucao);
            lblPonto.Visible = true;

            var potencia = Convert.ToInt16(txtPotencia.Text);
            var pontoIncremento = new string('.', potencia);

            lblPonto.Text += pontoIncremento;

            if (tempoExecucao == 0)
            {
                cronometro.Stop();
                MessageBox.Show("Aquecida.");
                LimparDados();
            }
        }

        private void LimparDados()
        {
            txtTempo.Text = string.Empty;
            txtPotencia.Text = ((int)PadraoEnum.PotenciaPadrao).ToString();
            lblMensagem.Text = string.Empty;
            lblPonto.Text = string.Empty;
            tempoExecucao = 0;

        }

        private void InicioRapido(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrato.Text))
            {
                lblMensagem.Text = "É obrigatório o preenchimento do prato.";
                return;
            }

            var inicioRapido = _funcionalidades.InicioRapido(txtPrato.Text);

            txtTempo.Text = inicioRapido.Tempo.ToString();
            txtPotencia.Text = inicioRapido.Potencia.ToString();

            IniciarCronometro(inicioRapido.Tempo);

        }

        private void cmbPrograma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!carga && cmbPrograma.SelectedIndex != -1)
            {
                var idPrograma = cmbPrograma.SelectedValue;
                var programa = _funcionalidades.BuscarProgramaAquecimento(Guid.Parse(idPrograma.ToString()));

                txtPotencia.Text = programa.Potencia.ToString();
                txtPrato.Text = programa.Nome;
                txtTempo.Text = programa.Tempo.ToString();
            }
        }
    }
}
