namespace EDAT_JD2025_P01
{
    partial class frmNumerosAleatorios
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
            btnGenerarDatosAleatorios_Click = new Button();
            txtNumero = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new ComboBox();
            rbMasculino = new RadioButton();
            rbFemenino = new RadioButton();
            chkSeguroMedico = new CheckBox();
            txtSueldo = new TextBox();
            cbGrupo = new ComboBox();
            SuspendLayout();
            // 
            // btnGenerarDatosAleatorios_Click
            // 
            btnGenerarDatosAleatorios_Click.Location = new Point(201, 386);
            btnGenerarDatosAleatorios_Click.Name = "btnGenerarDatosAleatorios_Click";
            btnGenerarDatosAleatorios_Click.Size = new Size(191, 29);
            btnGenerarDatosAleatorios_Click.TabIndex = 0;
            btnGenerarDatosAleatorios_Click.Text = "Generar datos aleatorios";
            btnGenerarDatosAleatorios_Click.UseVisualStyleBackColor = true;
            btnGenerarDatosAleatorios_Click.Click += btnMostrarMensage_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(125, 58);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(125, 27);
            txtNumero.TabIndex = 1;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(231, 139);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(300, 27);
            dtpFechaNacimiento.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 3;
            label1.Text = "Datos del Empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 58);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 4;
            label2.Text = "Numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 101);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 139);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 6;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(96, 228);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 7;
            label5.Text = "Grupo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(92, 264);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 8;
            label6.Text = "Sueldo";
            // 
            // txtNombre
            // 
            txtNombre.FormattingEnabled = true;
            txtNombre.Location = new Point(125, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 28);
            txtNombre.TabIndex = 9;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(128, 171);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(97, 24);
            rbMasculino.TabIndex = 10;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.Location = new Point(129, 200);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(95, 24);
            rbFemenino.TabIndex = 11;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
            // 
            // chkSeguroMedico
            // 
            chkSeguroMedico.AutoSize = true;
            chkSeguroMedico.Location = new Point(153, 309);
            chkSeguroMedico.Name = "chkSeguroMedico";
            chkSeguroMedico.Size = new Size(132, 24);
            chkSeguroMedico.TabIndex = 12;
            chkSeguroMedico.Text = "Seguro medico";
            chkSeguroMedico.UseVisualStyleBackColor = true;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(160, 261);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(125, 27);
            txtSueldo.TabIndex = 13;
            // 
            // cbGrupo
            // 
            cbGrupo.FormattingEnabled = true;
            cbGrupo.Location = new Point(160, 228);
            cbGrupo.Name = "cbGrupo";
            cbGrupo.Size = new Size(125, 28);
            cbGrupo.TabIndex = 14;
            // 
            // frmNumerosAleatorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 450);
            Controls.Add(cbGrupo);
            Controls.Add(txtSueldo);
            Controls.Add(chkSeguroMedico);
            Controls.Add(rbFemenino);
            Controls.Add(rbMasculino);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtNumero);
            Controls.Add(btnGenerarDatosAleatorios_Click);
            Name = "frmNumerosAleatorios";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerarDatosAleatorios_Click;
        private TextBox txtNumero;
        private DateTimePicker dtpFechaNacimiento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox txtNombre;
        private RadioButton rbMasculino;
        private RadioButton rbFemenino;
        private CheckBox chkSeguroMedico;
        private TextBox txtSueldo;
        private ComboBox cbGrupo;
    }
}
