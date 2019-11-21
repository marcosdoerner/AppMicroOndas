using AppMicroOndas.Entidades.Modelos;
using AppMicroOndas.Negocio.Interface;
using AppMicroOndas.Negocio.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppMicroOndas
{
    public partial class FormEstender : Form
    {

        private readonly IProgramaAquecimentoService _programaService;
        private ProgramaAquecimentoModel _programa;


        public event EventHandler EstenderEvent;


        public FormEstender(ProgramaAquecimentoModel programa)
        {
            InitializeComponent();
            _programaService = new ProgramaAquecimentoService();
            _programa = (ProgramaAquecimentoModel)programa.Clone();
            txtNome.Text = programa.Nome;
            txtDescricao.Text = programa.Instrucao;
            numTempo.Value = programa.Tempo;
            numPotencia.Value = programa.Potencia;
            txtCaracter.Text = programa.Caracter;
            txtTags.Text = string.Join(", ", programa.AlimentoCompativel);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                _programa.Nome = txtNome.Text;
                _programa.Instrucao = txtDescricao.Text;
                _programa.TempoTxt = numTempo.Value.ToString();
                _programa.PotenciaTxt = numPotencia.Value.ToString();
                _programa.Caracter = txtCaracter.Text;
                var tags = txtTags.Text.Split(',');
                tags.ToList().ForEach(tag =>
                {
                    tag = tag.ToLower().Trim();
                });
                tags = tags.Where(p => !string.IsNullOrEmpty(p)).ToArray();
                this._programa.AlimentoCompativel = tags;
                this._programaService.ValidaCustomizado(this._programa);
                this.EstenderEvent(this._programa, EventArgs.Empty);
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
    }
}
