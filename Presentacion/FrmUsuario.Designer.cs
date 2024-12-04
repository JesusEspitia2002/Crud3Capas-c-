namespace Presentacion
{
    partial class FrmUsuario
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
            TipBotones = new TableLayoutPanel();
            BtnInsertar = new Button();
            BtnEliminar = new Button();
            BtnActualizar = new Button();
            BtnConsultarDr = new Button();
            BtnCerrar = new Button();
            TipControles = new TableLayoutPanel();
            LblUsername = new Label();
            TxtUsername = new TextBox();
            LblPassword = new Label();
            TxtPassoword = new TextBox();
            LblVerificacion = new Label();
            TxtVerificacion = new TextBox();
            LblNombre = new Label();
            TxtNombre = new TextBox();
            LblEdad = new Label();
            TxtEdad = new TextBox();
            LblEstado = new Label();
            CmbEstado = new ComboBox();
            LblTipoUsuario = new Label();
            CmbTipoUsuario = new ComboBox();
            TipBotones.SuspendLayout();
            TipControles.SuspendLayout();
            SuspendLayout();
            // 
            // TipBotones
            // 
            TipBotones.ColumnCount = 6;
            TipBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            TipBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            TipBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            TipBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            TipBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            TipBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            TipBotones.Controls.Add(BtnInsertar, 0, 0);
            TipBotones.Controls.Add(BtnEliminar, 1, 0);
            TipBotones.Controls.Add(BtnActualizar, 2, 0);
            TipBotones.Controls.Add(BtnConsultarDr, 3, 0);
            TipBotones.Controls.Add(BtnCerrar, 4, 0);
            TipBotones.Location = new Point(29, 335);
            TipBotones.Name = "TipBotones";
            TipBotones.RowCount = 1;
            TipBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TipBotones.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TipBotones.Size = new Size(868, 103);
            TipBotones.TabIndex = 3;
            // 
            // BtnInsertar
            // 
            BtnInsertar.Location = new Point(3, 3);
            BtnInsertar.Name = "BtnInsertar";
            BtnInsertar.Size = new Size(117, 55);
            BtnInsertar.TabIndex = 0;
            BtnInsertar.Text = "Insertar";
            BtnInsertar.UseVisualStyleBackColor = true;
            BtnInsertar.Click += BtnInsertar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(147, 3);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(117, 55);
            BtnEliminar.TabIndex = 1;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(291, 3);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(117, 55);
            BtnActualizar.TabIndex = 2;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // BtnConsultarDr
            // 
            BtnConsultarDr.Location = new Point(435, 3);
            BtnConsultarDr.Name = "BtnConsultarDr";
            BtnConsultarDr.Size = new Size(117, 55);
            BtnConsultarDr.TabIndex = 3;
            BtnConsultarDr.Text = "Consultar Dr";
            BtnConsultarDr.UseVisualStyleBackColor = true;
            BtnConsultarDr.Click += BtnConsultarDr_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.Location = new Point(579, 3);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(117, 55);
            BtnCerrar.TabIndex = 5;
            BtnCerrar.Text = "Cerrar";
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // TipControles
            // 
            TipControles.ColumnCount = 2;
            TipControles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TipControles.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TipControles.Controls.Add(LblUsername, 0, 0);
            TipControles.Controls.Add(TxtUsername, 1, 0);
            TipControles.Controls.Add(LblPassword, 0, 1);
            TipControles.Controls.Add(TxtPassoword, 1, 1);
            TipControles.Controls.Add(LblVerificacion, 0, 2);
            TipControles.Controls.Add(TxtVerificacion, 1, 2);
            TipControles.Controls.Add(LblNombre, 0, 3);
            TipControles.Controls.Add(TxtNombre, 1, 3);
            TipControles.Controls.Add(LblEdad, 0, 4);
            TipControles.Controls.Add(TxtEdad, 1, 4);
            TipControles.Controls.Add(LblEstado, 0, 5);
            TipControles.Controls.Add(CmbEstado, 1, 5);
            TipControles.Controls.Add(LblTipoUsuario, 0, 6);
            TipControles.Controls.Add(CmbTipoUsuario, 1, 6);
            TipControles.Location = new Point(45, 39);
            TipControles.Name = "TipControles";
            TipControles.RowCount = 7;
            TipControles.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TipControles.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TipControles.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TipControles.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TipControles.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TipControles.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TipControles.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TipControles.Size = new Size(636, 256);
            TipControles.TabIndex = 2;
            TipControles.Paint += TipControles_Paint;
            // 
            // LblUsername
            // 
            LblUsername.AutoSize = true;
            LblUsername.Location = new Point(3, 0);
            LblUsername.Name = "LblUsername";
            LblUsername.Size = new Size(82, 20);
            LblUsername.TabIndex = 0;
            LblUsername.Text = "User Name";
            // 
            // TxtUsername
            // 
            TxtUsername.Location = new Point(321, 3);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.Size = new Size(125, 27);
            TxtUsername.TabIndex = 1;
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Location = new Point(3, 40);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(70, 20);
            LblPassword.TabIndex = 2;
            LblPassword.Text = "Password";
            // 
            // TxtPassoword
            // 
            TxtPassoword.Location = new Point(321, 43);
            TxtPassoword.Name = "TxtPassoword";
            TxtPassoword.Size = new Size(125, 27);
            TxtPassoword.TabIndex = 3;
            TxtPassoword.UseSystemPasswordChar = true;
            // 
            // LblVerificacion
            // 
            LblVerificacion.AutoSize = true;
            LblVerificacion.Location = new Point(3, 80);
            LblVerificacion.Name = "LblVerificacion";
            LblVerificacion.Size = new Size(86, 20);
            LblVerificacion.TabIndex = 4;
            LblVerificacion.Text = "Verificacion";
            // 
            // TxtVerificacion
            // 
            TxtVerificacion.Location = new Point(321, 83);
            TxtVerificacion.Name = "TxtVerificacion";
            TxtVerificacion.Size = new Size(125, 27);
            TxtVerificacion.TabIndex = 5;
            TxtVerificacion.UseSystemPasswordChar = true;
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Location = new Point(3, 120);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(64, 20);
            LblNombre.TabIndex = 6;
            LblNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(321, 123);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(125, 27);
            TxtNombre.TabIndex = 7;
            // 
            // LblEdad
            // 
            LblEdad.AutoSize = true;
            LblEdad.Location = new Point(3, 160);
            LblEdad.Name = "LblEdad";
            LblEdad.Size = new Size(43, 20);
            LblEdad.TabIndex = 8;
            LblEdad.Text = "Edad";
            // 
            // TxtEdad
            // 
            TxtEdad.Location = new Point(321, 163);
            TxtEdad.Name = "TxtEdad";
            TxtEdad.Size = new Size(125, 27);
            TxtEdad.TabIndex = 9;
            // 
            // LblEstado
            // 
            LblEstado.AutoSize = true;
            LblEstado.Location = new Point(3, 200);
            LblEstado.Name = "LblEstado";
            LblEstado.Size = new Size(54, 20);
            LblEstado.TabIndex = 10;
            LblEstado.Text = "Estado";
            // 
            // CmbEstado
            // 
            CmbEstado.FormattingEnabled = true;
            CmbEstado.Location = new Point(321, 203);
            CmbEstado.Name = "CmbEstado";
            CmbEstado.Size = new Size(151, 28);
            CmbEstado.TabIndex = 11;
            // 
            // LblTipoUsuario
            // 
            LblTipoUsuario.AutoSize = true;
            LblTipoUsuario.Location = new Point(3, 240);
            LblTipoUsuario.Name = "LblTipoUsuario";
            LblTipoUsuario.Size = new Size(91, 20);
            LblTipoUsuario.TabIndex = 12;
            LblTipoUsuario.Text = "Tipo usuario";
            // 
            // CmbTipoUsuario
            // 
            CmbTipoUsuario.FormattingEnabled = true;
            CmbTipoUsuario.Location = new Point(321, 243);
            CmbTipoUsuario.Name = "CmbTipoUsuario";
            CmbTipoUsuario.Size = new Size(151, 28);
            CmbTipoUsuario.TabIndex = 13;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 450);
            Controls.Add(TipBotones);
            Controls.Add(TipControles);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            Load += FrmUsuario_Load;
            TipBotones.ResumeLayout(false);
            TipControles.ResumeLayout(false);
            TipControles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TipBotones;
        private Button BtnInsertar;
        private Button BtnEliminar;
        private Button BtnActualizar;
        private Button BtnConsultarDr;
        private Button BtnCerrar;
        private TableLayoutPanel TipControles;
        private Label LblUsername;
        private TextBox TxtUsername;
        private Label LblPassword;
        private TextBox TxtPassoword;
        private Label LblVerificacion;
        private TextBox TxtVerificacion;
        private Label LblNombre;
        private TextBox TxtNombre;
        private Label LblEdad;
        private TextBox TxtEdad;
        private Label LblEstado;
        private ComboBox CmbEstado;
        private Label LblTipoUsuario;
        private ComboBox CmbTipoUsuario;
    }
}