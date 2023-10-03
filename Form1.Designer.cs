namespace _3O_Practica05_ProgramacionAvanzada
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblTelefono = new Label();
            lblEstatura = new Label();
            lblEdad = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtEstatura = new TextBox();
            txtEdad = new TextBox();
            gpGenero = new GroupBox();
            rbtnMujer = new RadioButton();
            rbtnHombre = new RadioButton();
            btnGuardar = new Button();
            btnCancelar = new Button();
            gpGenero.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(85, 60);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre :";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(85, 107);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(73, 20);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido :";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(85, 151);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(74, 20);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Telefono :";
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Location = new Point(86, 207);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(73, 20);
            lblEstatura.TabIndex = 3;
            lblEstatura.Text = "Estatura : ";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(96, 251);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(50, 20);
            lblEdad.TabIndex = 4;
            lblEdad.Text = "Edad :";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(165, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(181, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(165, 104);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(181, 27);
            txtApellido.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(165, 151);
            txtTelefono.MaxLength = 10;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(181, 27);
            txtTelefono.TabIndex = 7;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // txtEstatura
            // 
            txtEstatura.Location = new Point(165, 204);
            txtEstatura.Name = "txtEstatura";
            txtEstatura.Size = new Size(181, 27);
            txtEstatura.TabIndex = 8;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(165, 251);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(181, 27);
            txtEdad.TabIndex = 9;
            // 
            // gpGenero
            // 
            gpGenero.Controls.Add(rbtnMujer);
            gpGenero.Controls.Add(rbtnHombre);
            gpGenero.Location = new Point(417, 72);
            gpGenero.Name = "gpGenero";
            gpGenero.Size = new Size(335, 125);
            gpGenero.TabIndex = 10;
            gpGenero.TabStop = false;
            gpGenero.Text = "Genero";
            // 
            // rbtnMujer
            // 
            rbtnMujer.AutoSize = true;
            rbtnMujer.Location = new Point(237, 44);
            rbtnMujer.Name = "rbtnMujer";
            rbtnMujer.Size = new Size(68, 24);
            rbtnMujer.TabIndex = 1;
            rbtnMujer.TabStop = true;
            rbtnMujer.Text = "Mujer";
            rbtnMujer.UseVisualStyleBackColor = true;
            // 
            // rbtnHombre
            // 
            rbtnHombre.AutoSize = true;
            rbtnHombre.Location = new Point(49, 44);
            rbtnHombre.Name = "rbtnHombre";
            rbtnHombre.Size = new Size(85, 24);
            rbtnHombre.TabIndex = 0;
            rbtnHombre.TabStop = true;
            rbtnHombre.Text = "Hombre";
            rbtnHombre.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(165, 345);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(170, 78);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(396, 345);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(170, 78);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(gpGenero);
            Controls.Add(txtEdad);
            Controls.Add(txtEstatura);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblEdad);
            Controls.Add(lblEstatura);
            Controls.Add(lblTelefono);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "Form1";
            gpGenero.ResumeLayout(false);
            gpGenero.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblTelefono;
        private Label lblEstatura;
        private Label lblEdad;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtEstatura;
        private TextBox txtEdad;
        private GroupBox gpGenero;
        private RadioButton rbtnMujer;
        private RadioButton rbtnHombre;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}