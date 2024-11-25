namespace DemoConcurrencia
{
    partial class FrmPatronSingleton
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
            btnAsignar = new Button();
            btnRecuperar = new Button();
            LblCadenaDeConexion = new Label();
            TxtCadenaDeConexion = new TextBox();
            LblCadenaDeConexionRecuperada = new TextBox();
            SuspendLayout();
            // 
            // btnAsignar
            // 
            btnAsignar.BackColor = Color.FromArgb(192, 255, 255);
            btnAsignar.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            btnAsignar.Location = new Point(76, 176);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(141, 70);
            btnAsignar.TabIndex = 0;
            btnAsignar.Text = "Asignar Cadena de Conexion";
            btnAsignar.UseVisualStyleBackColor = false;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnRecuperar
            // 
            btnRecuperar.BackColor = Color.FromArgb(255, 224, 192);
            btnRecuperar.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            btnRecuperar.Location = new Point(76, 279);
            btnRecuperar.Name = "btnRecuperar";
            btnRecuperar.Size = new Size(141, 71);
            btnRecuperar.TabIndex = 1;
            btnRecuperar.Text = "Obtener cadena de conexion";
            btnRecuperar.UseVisualStyleBackColor = false;
            btnRecuperar.Click += btnRecuperar_Click;
            // 
            // LblCadenaDeConexion
            // 
            LblCadenaDeConexion.AutoSize = true;
            LblCadenaDeConexion.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold);
            LblCadenaDeConexion.Location = new Point(82, 45);
            LblCadenaDeConexion.Name = "LblCadenaDeConexion";
            LblCadenaDeConexion.Size = new Size(158, 19);
            LblCadenaDeConexion.TabIndex = 2;
            LblCadenaDeConexion.Text = "Cadena de Conexion";
            // 
            // TxtCadenaDeConexion
            // 
            TxtCadenaDeConexion.Location = new Point(82, 98);
            TxtCadenaDeConexion.Name = "TxtCadenaDeConexion";
            TxtCadenaDeConexion.Size = new Size(561, 27);
            TxtCadenaDeConexion.TabIndex = 3;
            // 
            // LblCadenaDeConexionRecuperada
            // 
            LblCadenaDeConexionRecuperada.Location = new Point(284, 355);
            LblCadenaDeConexionRecuperada.Name = "LblCadenaDeConexionRecuperada";
            LblCadenaDeConexionRecuperada.Size = new Size(29, 27);
            LblCadenaDeConexionRecuperada.TabIndex = 4;
            // 
            // FrmPatronSingleton
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 424);
            Controls.Add(LblCadenaDeConexionRecuperada);
            Controls.Add(TxtCadenaDeConexion);
            Controls.Add(LblCadenaDeConexion);
            Controls.Add(btnRecuperar);
            Controls.Add(btnAsignar);
            Name = "FrmPatronSingleton";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Demostracion del Patron Singleton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAsignar;
        private Button btnRecuperar;
        private Label LblCadenaDeConexion;
        private TextBox TxtCadenaDeConexion;
        private TextBox LblCadenaDeConexionRecuperada;
    }
}