namespace prySp3LobatoCeleste
{
    partial class frmAutoTest
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxRegistro = new System.Windows.Forms.GroupBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblDominio = new System.Windows.Forms.Label();
            this.lblAñoFabricacion = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtDominio = new System.Windows.Forms.TextBox();
            this.numAñoFabricación = new System.Windows.Forms.NumericUpDown();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.gboxEstadisticas = new System.Windows.Forms.GroupBox();
            this.lblCantidadTurnos = new System.Windows.Forms.Label();
            this.lblAñoMasAntiguo = new System.Windows.Forms.Label();
            this.lblCantidadDominio = new System.Windows.Forms.Label();
            this.txtCantidadDominio = new System.Windows.Forms.TextBox();
            this.txtAñoMasAntiguo = new System.Windows.Forms.TextBox();
            this.txtCantidadTurnos = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gboxRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAñoFabricación)).BeginInit();
            this.gboxEstadisticas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxRegistro
            // 
            this.gboxRegistro.Controls.Add(this.txtTitular);
            this.gboxRegistro.Controls.Add(this.numAñoFabricación);
            this.gboxRegistro.Controls.Add(this.txtDominio);
            this.gboxRegistro.Controls.Add(this.txtNumero);
            this.gboxRegistro.Controls.Add(this.lblNumero);
            this.gboxRegistro.Controls.Add(this.lblDominio);
            this.gboxRegistro.Controls.Add(this.lblAñoFabricacion);
            this.gboxRegistro.Controls.Add(this.lblTitular);
            this.gboxRegistro.Location = new System.Drawing.Point(41, 25);
            this.gboxRegistro.Name = "gboxRegistro";
            this.gboxRegistro.Size = new System.Drawing.Size(548, 201);
            this.gboxRegistro.TabIndex = 0;
            this.gboxRegistro.TabStop = false;
            this.gboxRegistro.Text = " Auto Test";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(17, 34);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(86, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Numero de turno";
            // 
            // lblDominio
            // 
            this.lblDominio.AutoSize = true;
            this.lblDominio.Location = new System.Drawing.Point(17, 84);
            this.lblDominio.Name = "lblDominio";
            this.lblDominio.Size = new System.Drawing.Size(45, 13);
            this.lblDominio.TabIndex = 2;
            this.lblDominio.Text = "Dominio";
            // 
            // lblAñoFabricacion
            // 
            this.lblAñoFabricacion.AutoSize = true;
            this.lblAñoFabricacion.Location = new System.Drawing.Point(17, 120);
            this.lblAñoFabricacion.Name = "lblAñoFabricacion";
            this.lblAñoFabricacion.Size = new System.Drawing.Size(96, 13);
            this.lblAñoFabricacion.TabIndex = 3;
            this.lblAñoFabricacion.Text = "Año de fabricación";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(17, 161);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(36, 13);
            this.lblTitular.TabIndex = 4;
            this.lblTitular.Text = "Titular";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(152, 34);
            this.txtNumero.MaxLength = 5;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(68, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // txtDominio
            // 
            this.txtDominio.Location = new System.Drawing.Point(152, 77);
            this.txtDominio.MaxLength = 7;
            this.txtDominio.Name = "txtDominio";
            this.txtDominio.Size = new System.Drawing.Size(100, 20);
            this.txtDominio.TabIndex = 6;
            // 
            // numAñoFabricación
            // 
            this.numAñoFabricación.Location = new System.Drawing.Point(152, 113);
            this.numAñoFabricación.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.numAñoFabricación.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.numAñoFabricación.Name = "numAñoFabricación";
            this.numAñoFabricación.Size = new System.Drawing.Size(74, 20);
            this.numAñoFabricación.TabIndex = 7;
            this.numAñoFabricación.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // txtTitular
            // 
            this.txtTitular.Location = new System.Drawing.Point(152, 154);
            this.txtTitular.MaxLength = 30;
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(316, 20);
            this.txtTitular.TabIndex = 8;
            // 
            // gboxEstadisticas
            // 
            this.gboxEstadisticas.Controls.Add(this.txtCantidadTurnos);
            this.gboxEstadisticas.Controls.Add(this.txtAñoMasAntiguo);
            this.gboxEstadisticas.Controls.Add(this.txtCantidadDominio);
            this.gboxEstadisticas.Controls.Add(this.lblCantidadDominio);
            this.gboxEstadisticas.Controls.Add(this.lblAñoMasAntiguo);
            this.gboxEstadisticas.Controls.Add(this.lblCantidadTurnos);
            this.gboxEstadisticas.Location = new System.Drawing.Point(41, 246);
            this.gboxEstadisticas.Name = "gboxEstadisticas";
            this.gboxEstadisticas.Size = new System.Drawing.Size(548, 153);
            this.gboxEstadisticas.TabIndex = 1;
            this.gboxEstadisticas.TabStop = false;
            this.gboxEstadisticas.Text = "Estad";
            // 
            // lblCantidadTurnos
            // 
            this.lblCantidadTurnos.AutoSize = true;
            this.lblCantidadTurnos.Location = new System.Drawing.Point(17, 36);
            this.lblCantidadTurnos.Name = "lblCantidadTurnos";
            this.lblCantidadTurnos.Size = new System.Drawing.Size(96, 13);
            this.lblCantidadTurnos.TabIndex = 0;
            this.lblCantidadTurnos.Text = "Cantidad de turnos";
            // 
            // lblAñoMasAntiguo
            // 
            this.lblAñoMasAntiguo.AutoSize = true;
            this.lblAñoMasAntiguo.Location = new System.Drawing.Point(17, 78);
            this.lblAñoMasAntiguo.Name = "lblAñoMasAntiguo";
            this.lblAñoMasAntiguo.Size = new System.Drawing.Size(103, 13);
            this.lblAñoMasAntiguo.TabIndex = 1;
            this.lblAñoMasAntiguo.Text = "Año del mas antiguo";
            // 
            // lblCantidadDominio
            // 
            this.lblCantidadDominio.AutoSize = true;
            this.lblCantidadDominio.Location = new System.Drawing.Point(17, 119);
            this.lblCantidadDominio.Name = "lblCantidadDominio";
            this.lblCantidadDominio.Size = new System.Drawing.Size(186, 13);
            this.lblCantidadDominio.TabIndex = 2;
            this.lblCantidadDominio.Text = "Cantidad con dominio de 6 carácteres";
            // 
            // txtCantidadDominio
            // 
            this.txtCantidadDominio.Location = new System.Drawing.Point(243, 112);
            this.txtCantidadDominio.Name = "txtCantidadDominio";
            this.txtCantidadDominio.ReadOnly = true;
            this.txtCantidadDominio.Size = new System.Drawing.Size(75, 20);
            this.txtCantidadDominio.TabIndex = 3;
            // 
            // txtAñoMasAntiguo
            // 
            this.txtAñoMasAntiguo.Location = new System.Drawing.Point(243, 71);
            this.txtAñoMasAntiguo.Name = "txtAñoMasAntiguo";
            this.txtAñoMasAntiguo.ReadOnly = true;
            this.txtAñoMasAntiguo.Size = new System.Drawing.Size(75, 20);
            this.txtAñoMasAntiguo.TabIndex = 4;
            // 
            // txtCantidadTurnos
            // 
            this.txtCantidadTurnos.Location = new System.Drawing.Point(243, 29);
            this.txtCantidadTurnos.Name = "txtCantidadTurnos";
            this.txtCantidadTurnos.ReadOnly = true;
            this.txtCantidadTurnos.Size = new System.Drawing.Size(75, 20);
            this.txtCantidadTurnos.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(631, 59);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "&Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(631, 118);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(631, 272);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "&Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // frmAutoTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 416);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.gboxEstadisticas);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gboxRegistro);
            this.Name = "frmAutoTest";
            this.Text = "Auto Test";
            this.gboxRegistro.ResumeLayout(false);
            this.gboxRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAñoFabricación)).EndInit();
            this.gboxEstadisticas.ResumeLayout(false);
            this.gboxEstadisticas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxRegistro;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.NumericUpDown numAñoFabricación;
        private System.Windows.Forms.TextBox txtDominio;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblDominio;
        private System.Windows.Forms.Label lblAñoFabricacion;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.GroupBox gboxEstadisticas;
        private System.Windows.Forms.TextBox txtCantidadTurnos;
        private System.Windows.Forms.TextBox txtAñoMasAntiguo;
        private System.Windows.Forms.TextBox txtCantidadDominio;
        private System.Windows.Forms.Label lblCantidadDominio;
        private System.Windows.Forms.Label lblAñoMasAntiguo;
        private System.Windows.Forms.Label lblCantidadTurnos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
    }
}

