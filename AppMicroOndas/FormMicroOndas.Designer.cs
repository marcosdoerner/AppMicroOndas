namespace AppMicroOndas
{
    partial class FormMicroOndas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrato = new System.Windows.Forms.TextBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.lblPotencia = new System.Windows.Forms.Label();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_pausar = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_ligar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMonitor = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCustomDel = new System.Windows.Forms.Button();
            this.btnCustomAdd = new System.Windows.Forms.Button();
            this.dgProgramas = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instrucao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Potencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estendido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIniciarPrograma = new System.Windows.Forms.Button();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnFiltrarCompativeis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProgramas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPrato);
            this.groupBox1.Controls.Add(this.lblTempo);
            this.groupBox1.Controls.Add(this.lblPotencia);
            this.groupBox1.Controls.Add(this.txtTempo);
            this.groupBox1.Controls.Add(this.txtPotencia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 107);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Prato";
            // 
            // txtPrato
            // 
            this.txtPrato.Location = new System.Drawing.Point(63, 17);
            this.txtPrato.MaxLength = 0;
            this.txtPrato.Name = "txtPrato";
            this.txtPrato.Size = new System.Drawing.Size(293, 20);
            this.txtPrato.TabIndex = 20;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(13, 50);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(40, 13);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "Tempo";
            // 
            // lblPotencia
            // 
            this.lblPotencia.AutoSize = true;
            this.lblPotencia.Location = new System.Drawing.Point(7, 81);
            this.lblPotencia.Name = "lblPotencia";
            this.lblPotencia.Size = new System.Drawing.Size(49, 13);
            this.lblPotencia.TabIndex = 3;
            this.lblPotencia.Text = "Potência";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(63, 47);
            this.txtTempo.MaxLength = 3;
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(121, 20);
            this.txtTempo.TabIndex = 7;
            // 
            // txtPotencia
            // 
            this.txtPotencia.Location = new System.Drawing.Point(63, 78);
            this.txtPotencia.MaxLength = 2;
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(121, 20);
            this.txtPotencia.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Segundos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_pausar);
            this.groupBox2.Controls.Add(this.button_cancelar);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button_ligar);
            this.groupBox2.Location = new System.Drawing.Point(562, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 102);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funções";
            // 
            // button_pausar
            // 
            this.button_pausar.Location = new System.Drawing.Point(6, 45);
            this.button_pausar.Name = "button_pausar";
            this.button_pausar.Size = new System.Drawing.Size(90, 23);
            this.button_pausar.TabIndex = 11;
            this.button_pausar.Text = "Pausar";
            this.button_pausar.UseVisualStyleBackColor = true;
            this.button_pausar.Click += new System.EventHandler(this.button_pausar_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(102, 45);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(90, 23);
            this.button_cancelar.TabIndex = 12;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Início Rápido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.InicioRapido);
            // 
            // button_ligar
            // 
            this.button_ligar.Location = new System.Drawing.Point(6, 19);
            this.button_ligar.Name = "button_ligar";
            this.button_ligar.Size = new System.Drawing.Size(90, 23);
            this.button_ligar.TabIndex = 0;
            this.button_ligar.Text = "Iniciar";
            this.button_ligar.UseVisualStyleBackColor = true;
            this.button_ligar.Click += new System.EventHandler(this.button_ligar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMonitor);
            this.groupBox3.Location = new System.Drawing.Point(12, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 141);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monitor";
            // 
            // txtMonitor
            // 
            this.txtMonitor.Location = new System.Drawing.Point(6, 19);
            this.txtMonitor.Multiline = true;
            this.txtMonitor.Name = "txtMonitor";
            this.txtMonitor.Size = new System.Drawing.Size(764, 116);
            this.txtMonitor.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnCustomDel);
            this.groupBox4.Controls.Add(this.btnCustomAdd);
            this.groupBox4.Controls.Add(this.dgProgramas);
            this.groupBox4.Controls.Add(this.btnIniciarPrograma);
            this.groupBox4.Controls.Add(this.btnVerTodos);
            this.groupBox4.Controls.Add(this.btnFiltrarCompativeis);
            this.groupBox4.Location = new System.Drawing.Point(12, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 219);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Programas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Programas customizados";
            // 
            // btnCustomDel
            // 
            this.btnCustomDel.Location = new System.Drawing.Point(268, 29);
            this.btnCustomDel.Name = "btnCustomDel";
            this.btnCustomDel.Size = new System.Drawing.Size(57, 23);
            this.btnCustomDel.TabIndex = 22;
            this.btnCustomDel.Text = "Excluir";
            this.btnCustomDel.UseVisualStyleBackColor = true;
            this.btnCustomDel.Click += new System.EventHandler(this.btnCustomDel_Click);
            // 
            // btnCustomAdd
            // 
            this.btnCustomAdd.Location = new System.Drawing.Point(204, 29);
            this.btnCustomAdd.Name = "btnCustomAdd";
            this.btnCustomAdd.Size = new System.Drawing.Size(63, 23);
            this.btnCustomAdd.TabIndex = 21;
            this.btnCustomAdd.Text = "Estender";
            this.btnCustomAdd.UseVisualStyleBackColor = true;
            this.btnCustomAdd.Click += new System.EventHandler(this.btnCustomAdd_Click);
            // 
            // dgProgramas
            // 
            this.dgProgramas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProgramas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Instrucao,
            this.Tempo,
            this.Potencia,
            this.Estendido});
            this.dgProgramas.Location = new System.Drawing.Point(6, 59);
            this.dgProgramas.Name = "dgProgramas";
            this.dgProgramas.ReadOnly = true;
            this.dgProgramas.Size = new System.Drawing.Size(747, 154);
            this.dgProgramas.TabIndex = 20;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Instrucao
            // 
            this.Instrucao.DataPropertyName = "Instrucao";
            this.Instrucao.HeaderText = "Instrução";
            this.Instrucao.Name = "Instrucao";
            this.Instrucao.ReadOnly = true;
            // 
            // Tempo
            // 
            this.Tempo.DataPropertyName = "Tempo";
            this.Tempo.HeaderText = "Tempo";
            this.Tempo.Name = "Tempo";
            this.Tempo.ReadOnly = true;
            // 
            // Potencia
            // 
            this.Potencia.DataPropertyName = "Potencia";
            this.Potencia.HeaderText = "Potencia";
            this.Potencia.Name = "Potencia";
            this.Potencia.ReadOnly = true;
            // 
            // Estendido
            // 
            this.Estendido.DataPropertyName = "CustomLabel";
            this.Estendido.HeaderText = "Estendido";
            this.Estendido.Name = "Estendido";
            this.Estendido.ReadOnly = true;
            // 
            // btnIniciarPrograma
            // 
            this.btnIniciarPrograma.Location = new System.Drawing.Point(644, 29);
            this.btnIniciarPrograma.Name = "btnIniciarPrograma";
            this.btnIniciarPrograma.Size = new System.Drawing.Size(109, 23);
            this.btnIniciarPrograma.TabIndex = 18;
            this.btnIniciarPrograma.Text = "Iniciar Programa";
            this.btnIniciarPrograma.UseVisualStyleBackColor = true;
            this.btnIniciarPrograma.Click += new System.EventHandler(this.btnIniciarPrograma_Click);
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Location = new System.Drawing.Point(121, 29);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(68, 23);
            this.btnVerTodos.TabIndex = 19;
            this.btnVerTodos.Text = "Ver todos";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // btnFiltrarCompativeis
            // 
            this.btnFiltrarCompativeis.Location = new System.Drawing.Point(6, 29);
            this.btnFiltrarCompativeis.Name = "btnFiltrarCompativeis";
            this.btnFiltrarCompativeis.Size = new System.Drawing.Size(113, 23);
            this.btnFiltrarCompativeis.TabIndex = 18;
            this.btnFiltrarCompativeis.Text = "Filtrar compatíveis";
            this.btnFiltrarCompativeis.UseVisualStyleBackColor = true;
            this.btnFiltrarCompativeis.Click += new System.EventHandler(this.btnFiltrarCompativeis_Click);
            // 
            // FormMicroOndas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMicroOndas";
            this.Text = "MicroOndas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProgramas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_ligar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblPotencia;
        private System.Windows.Forms.TextBox txtPotencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrato;
        private System.Windows.Forms.Button button_pausar;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.TextBox txtMonitor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCustomDel;
        private System.Windows.Forms.Button btnCustomAdd;
        private System.Windows.Forms.DataGridView dgProgramas;
        private System.Windows.Forms.Button btnIniciarPrograma;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnFiltrarCompativeis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instrucao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Potencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estendido;
    }
}

