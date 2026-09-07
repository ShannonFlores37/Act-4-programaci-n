namespace Act_4_programación
{
    partial class Form1
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
            lblTitulo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblPropiedades = new Label();
            rbtnConsulta = new RadioButton();
            rbtnQueja = new RadioButton();
            rbtnSugerencia = new RadioButton();
            grpbx1 = new GroupBox();
            cbxRespuesta = new CheckBox();
            btnEnviar = new Button();
            lblConfirmacion = new Label();
            txtbConfirmacion = new TextBox();
            lllbl = new LinkLabel();
            grpbx1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Gadugi", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(187, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(403, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Formulario de contacto";
            lblTitulo.Click += label1_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(49, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(577, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblPropiedades
            // 
            lblPropiedades.AutoSize = true;
            lblPropiedades.Location = new Point(49, 125);
            lblPropiedades.Name = "lblPropiedades";
            lblPropiedades.Size = new Size(109, 15);
            lblPropiedades.TabIndex = 3;
            lblPropiedades.Text = "Motivo de consulta";
            // 
            // rbtnConsulta
            // 
            rbtnConsulta.AutoSize = true;
            rbtnConsulta.Location = new Point(6, 22);
            rbtnConsulta.Name = "rbtnConsulta";
            rbtnConsulta.Size = new Size(72, 19);
            rbtnConsulta.TabIndex = 4;
            rbtnConsulta.TabStop = true;
            rbtnConsulta.Text = "Consulta";
            rbtnConsulta.UseVisualStyleBackColor = true;
            // 
            // rbtnQueja
            // 
            rbtnQueja.AutoSize = true;
            rbtnQueja.Location = new Point(6, 47);
            rbtnQueja.Name = "rbtnQueja";
            rbtnQueja.Size = new Size(56, 19);
            rbtnQueja.TabIndex = 5;
            rbtnQueja.TabStop = true;
            rbtnQueja.Text = "Queja";
            rbtnQueja.UseVisualStyleBackColor = true;
            // 
            // rbtnSugerencia
            // 
            rbtnSugerencia.AutoSize = true;
            rbtnSugerencia.Location = new Point(6, 72);
            rbtnSugerencia.Name = "rbtnSugerencia";
            rbtnSugerencia.Size = new Size(83, 19);
            rbtnSugerencia.TabIndex = 6;
            rbtnSugerencia.TabStop = true;
            rbtnSugerencia.Text = "Sugerencia";
            rbtnSugerencia.UseVisualStyleBackColor = true;
            // 
            // grpbx1
            // 
            grpbx1.Controls.Add(rbtnConsulta);
            grpbx1.Controls.Add(rbtnSugerencia);
            grpbx1.Controls.Add(rbtnQueja);
            grpbx1.Location = new Point(49, 154);
            grpbx1.Name = "grpbx1";
            grpbx1.Size = new Size(200, 100);
            grpbx1.TabIndex = 7;
            grpbx1.TabStop = false;
            grpbx1.Text = "Escoja uno:";
            // 
            // cbxRespuesta
            // 
            cbxRespuesta.AutoSize = true;
            cbxRespuesta.Location = new Point(50, 259);
            cbxRespuesta.Name = "cbxRespuesta";
            cbxRespuesta.Size = new Size(147, 19);
            cbxRespuesta.TabIndex = 8;
            cbxRespuesta.Text = "Deseo recibir respuesta";
            cbxRespuesta.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(46, 292);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(141, 25);
            btnEnviar.TabIndex = 9;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.Location = new Point(47, 321);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new Size(80, 15);
            lblConfirmacion.TabIndex = 10;
            lblConfirmacion.Text = "Confirmación";
            // 
            // txtbConfirmacion
            // 
            txtbConfirmacion.Location = new Point(49, 343);
            txtbConfirmacion.Multiline = true;
            txtbConfirmacion.Name = "txtbConfirmacion";
            txtbConfirmacion.ReadOnly = true;
            txtbConfirmacion.Size = new Size(702, 52);
            txtbConfirmacion.TabIndex = 11;
            // 
            // lllbl
            // 
            lllbl.AutoSize = true;
            lllbl.Location = new Point(311, 411);
            lllbl.Name = "lllbl";
            lllbl.Size = new Size(139, 15);
            lllbl.TabIndex = 12;
            lllbl.TabStop = true;
            lllbl.Text = "Ver politica de privacidad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lllbl);
            Controls.Add(txtbConfirmacion);
            Controls.Add(lblConfirmacion);
            Controls.Add(btnEnviar);
            Controls.Add(cbxRespuesta);
            Controls.Add(grpbx1);
            Controls.Add(lblPropiedades);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            grpbx1.ResumeLayout(false);
            grpbx1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblPropiedades;
        private RadioButton rbtnConsulta;
        private RadioButton rbtnQueja;
        private RadioButton rbtnSugerencia;
        private GroupBox grpbx1;
        private CheckBox cbxRespuesta;
        private Button btnEnviar;
        private Label lblConfirmacion;
        private TextBox txtbConfirmacion;
        private LinkLabel lllbl;
    }
}
