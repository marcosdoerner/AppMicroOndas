using AppMicroOndas.Entidades.Modelos;
using AppMicroOndas.Enums;
using AppMicroOndas.Negocio.Interface;
using AppMicroOndas.Negocio.Services;
using System;
using System.Windows.Forms;

namespace AppMicroOndas
{
    public partial class FormMicroOndas : Form
    {

        private readonly IMicroOndasService _microOndasService;
        private readonly IProgramaAquecimentoService _programaService;
            
        public FormMicroOndas()
        {
            InitializeComponent();
            _microOndasService = new MicroOndasService();
            _microOndasService = new MicroOndasService(txtMonitor);
            _programaService = new ProgramaAquecimentoService();
            _microOndasService.ConcluidoEvent += _microOndasService_ConcluidoEvent;
            _microOndasService.ErroEvent += _microOndasService_ErroEvent;
            btnVerTodos_Click(null, null);
        }

        private void button_ligar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void Iniciar(string caracter = ".", ProgramaAquecimentoModel programa = null)
        {
            try
            {
                var microondas = new MicroOndasModel()
                {
                    Prato = txtPrato.Text,
                    TempoTxt = txtTempo.Text,
                    PotenciaTxt = txtPotencia.Text,
                    Caracter = caracter
                };

                if (programa != null)
                    _programaService.ValidaCompativel(microondas, programa);

                _microOndasService.Inicia(microondas);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void LimparDados()
        {
            txtTempo.Text = string.Empty;
            txtPotencia.Text = ((int)PadraoEnum.PotenciaPadrao).ToString();
        }

        private void InicioRapido(object sender, EventArgs e)
        {
            txtPotencia.Text = ((int)PadraoEnum.InicioRapidoPodencia).ToString();
            txtTempo.Text  = ((int)PadraoEnum.InicioRapidoTempo).ToString();
            Iniciar();
        }

        private void _microOndasService_ErroEvent(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void _microOndasService_ConcluidoEvent(object sender, EventArgs e)
        {
            var result = _microOndasService.BuscaResultado();
            _microOndasService.SetaResultado(result + sender.ToString());
        }

        private void button_pausar_Click(object sender, EventArgs e)
        {
            _microOndasService.Pausa();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            _microOndasService.Cancela();
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            var lista = _programaService.BuscaTodos();
            dgProgramas.DataSource = lista;
        }

        private void btnFiltrarCompativeis_Click(object sender, EventArgs e)
        {
            try
            {
                var lista = _programaService.BuscaCompativel(new MicroOndasModel()
                {
                    Prato = txtPrato.Text
                });

                dgProgramas.DataSource = lista;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnCustomAdd_Click(object sender, EventArgs e)
        {
            if (dgProgramas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um programa na lista abaixo.");
                return;
            }

            var item = (ProgramaAquecimentoModel)dgProgramas.SelectedRows[0].DataBoundItem;

            var form = Application.OpenForms["FormEstender"];
            if (form != null)
                form.BringToFront();
            else
            {
                FormEstender formEstender = new FormEstender(item);
                formEstender.EstenderEvent += FormEstender_EstenderEvent;
                formEstender.Show();
            }

        }

        private void FormEstender_EstenderEvent(object sender, EventArgs e)
        {
            try
            {
                var programa = (ProgramaAquecimentoModel)sender;
                _programaService.AdicionaCustomizado(programa);
                btnVerTodos_Click(null, null);
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);
            }
        }


        private void btnIniciarPrograma_Click(object sender, EventArgs e)
        {
            if (dgProgramas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um programa na lista abaixo.");
                return;
            }

            var item = (ProgramaAquecimentoModel)dgProgramas.SelectedRows[0].DataBoundItem;

            txtTempo.Text = item.Tempo.ToString();
            txtPotencia.Text = item.Potencia.ToString();
            Iniciar(item.Caracter, item);

        }

        private void btnCustomDel_Click(object sender, EventArgs e)
        {
            if (dgProgramas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um programa na lista abaixo.");
                return;
            }

            var item = (ProgramaAquecimentoModel)dgProgramas.SelectedRows[0].DataBoundItem;

            if (!item.Estendido)
            {
                MessageBox.Show("Selecione um programa na lista abaixo.");
                return;
            }

            _programaService.DeletaCustomizado(item);
            btnVerTodos_Click(null, null);
        }
    }
}
