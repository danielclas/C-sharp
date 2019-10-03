namespace ComiqueriaApp
{
    partial class ModificarProductoForm
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecioACtual = new System.Windows.Forms.Label();
            this.lblNuevoPrecio = new System.Windows.Forms.Label();
            this.txtPrecioActual = new System.Windows.Forms.TextBox();
            this.txtNuevoPrecio = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(24, 42);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(448, 36);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrecioACtual
            // 
            this.lblPrecioACtual.Location = new System.Drawing.Point(24, 102);
            this.lblPrecioACtual.Name = "lblPrecioACtual";
            this.lblPrecioACtual.Size = new System.Drawing.Size(187, 24);
            this.lblPrecioACtual.TabIndex = 1;
            this.lblPrecioACtual.Text = "Precio actual:";
            // 
            // lblNuevoPrecio
            // 
            this.lblNuevoPrecio.Location = new System.Drawing.Point(24, 176);
            this.lblNuevoPrecio.Name = "lblNuevoPrecio";
            this.lblNuevoPrecio.Size = new System.Drawing.Size(187, 23);
            this.lblNuevoPrecio.TabIndex = 2;
            this.lblNuevoPrecio.Text = "Nuevo precio;";
            // 
            // txtPrecioActual
            // 
            this.txtPrecioActual.Location = new System.Drawing.Point(28, 129);
            this.txtPrecioActual.Name = "txtPrecioActual";
            this.txtPrecioActual.Size = new System.Drawing.Size(359, 26);
            this.txtPrecioActual.TabIndex = 3;
            this.txtPrecioActual.TextChanged += new System.EventHandler(this.txtPrecioActual_TextChanged);
            // 
            // txtNuevoPrecio
            // 
            this.txtNuevoPrecio.Location = new System.Drawing.Point(28, 202);
            this.txtNuevoPrecio.Name = "txtNuevoPrecio";
            this.txtNuevoPrecio.Size = new System.Drawing.Size(359, 26);
            this.txtNuevoPrecio.TabIndex = 4;
            this.txtNuevoPrecio.TextChanged += new System.EventHandler(this.txtNuevoPrecio_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(28, 281);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(127, 42);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(208, 281);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 42);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(24, 231);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(448, 36);
            this.lblError.TabIndex = 7;
            // 
            // ModificarProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 335);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtNuevoPrecio);
            this.Controls.Add(this.txtPrecioActual);
            this.Controls.Add(this.lblNuevoPrecio);
            this.Controls.Add(this.lblPrecioACtual);
            this.Controls.Add(this.lblDescripcion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificarProductoForm";
            this.Text = "Modificar Producto";
            this.Load += new System.EventHandler(this.ModificarProductoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecioACtual;
        private System.Windows.Forms.Label lblNuevoPrecio;
        private System.Windows.Forms.TextBox txtPrecioActual;
        private System.Windows.Forms.TextBox txtNuevoPrecio;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblError;
    }
}