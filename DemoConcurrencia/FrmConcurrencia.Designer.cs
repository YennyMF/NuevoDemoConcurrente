namespace DemoConcurrencia
{
    partial class FrmConcurrencia
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            btnCancelarHilo = new Button();
            btnIniciarHilos = new Button();
            btnIniciarTarea = new Button();
            btnSecuencial = new Button();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnCancelarHilo);
            splitContainer1.Panel1.Controls.Add(btnIniciarHilos);
            splitContainer1.Panel1.Controls.Add(btnIniciarTarea);
            splitContainer1.Panel1.Controls.Add(btnSecuencial);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(758, 514);
            splitContainer1.SplitterDistance = 250;
            splitContainer1.TabIndex = 0;
            // 
            // btnCancelarHilo
            // 
            btnCancelarHilo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelarHilo.BackColor = Color.FromArgb(255, 192, 255);
            btnCancelarHilo.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            btnCancelarHilo.Location = new Point(55, 315);
            btnCancelarHilo.Name = "btnCancelarHilo";
            btnCancelarHilo.Size = new Size(136, 29);
            btnCancelarHilo.TabIndex = 3;
            btnCancelarHilo.Text = "Cancelar Hilo";
            btnCancelarHilo.UseVisualStyleBackColor = false;
            btnCancelarHilo.Click += btnCancelarHilo_Click;
            // 
            // btnIniciarHilos
            // 
            btnIniciarHilos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnIniciarHilos.BackColor = Color.FromArgb(255, 192, 192);
            btnIniciarHilos.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            btnIniciarHilos.Location = new Point(61, 151);
            btnIniciarHilos.Name = "btnIniciarHilos";
            btnIniciarHilos.Size = new Size(118, 29);
            btnIniciarHilos.TabIndex = 2;
            btnIniciarHilos.Text = "Iniciar Hilo";
            btnIniciarHilos.UseVisualStyleBackColor = false;
            btnIniciarHilos.Click += btnIniciarHilos_Click;
            // 
            // btnIniciarTarea
            // 
            btnIniciarTarea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnIniciarTarea.BackColor = Color.FromArgb(192, 255, 255);
            btnIniciarTarea.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            btnIniciarTarea.Location = new Point(55, 242);
            btnIniciarTarea.Name = "btnIniciarTarea";
            btnIniciarTarea.Size = new Size(124, 29);
            btnIniciarTarea.TabIndex = 1;
            btnIniciarTarea.Text = "Iniciar Tarea";
            btnIniciarTarea.UseVisualStyleBackColor = false;
            btnIniciarTarea.Click += btnIniciarTarea_Click;
            // 
            // btnSecuencial
            // 
            btnSecuencial.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSecuencial.BackColor = Color.FromArgb(192, 192, 255);
            btnSecuencial.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            btnSecuencial.Location = new Point(36, 69);
            btnSecuencial.Name = "btnSecuencial";
            btnSecuencial.Size = new Size(161, 29);
            btnSecuencial.TabIndex = 0;
            btnSecuencial.Text = "Iniciar Secuencial";
            btnSecuencial.UseVisualStyleBackColor = false;
            btnSecuencial.Click += btnSecuencial_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(504, 514);
            TxtResultado.TabIndex = 0;
            // 
            // FrmConcurrencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 514);
            Controls.Add(splitContainer1);
            Name = "FrmConcurrencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demostración De Concurrencia";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnIniciarHilos;
        private Button btnIniciarTarea;
        private Button btnSecuencial;
        private TextBox TxtResultado;
        private Button btnCancelarHilo;
    }
}
