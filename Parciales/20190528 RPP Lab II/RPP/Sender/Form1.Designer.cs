namespace Sender
{
    partial class Form1
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.richConsola = new System.Windows.Forms.RichTextBox();
            this.richMensaje = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richMensaje);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.comboBoxProductos);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblProducto);
            this.groupBox1.Controls.Add(this.lblMensaje);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Location = new System.Drawing.Point(32, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sender";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(117, 276);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(147, 51);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(311, 276);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(147, 51);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new System.Drawing.Point(65, 50);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(100, 23);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "Mensaje";
            // 
            // lblProducto
            // 
            this.lblProducto.Location = new System.Drawing.Point(65, 130);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(100, 23);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Producto";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(65, 188);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(171, 130);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(368, 28);
            this.comboBoxProductos.TabIndex = 5;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(172, 188);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(367, 26);
            this.textEmail.TabIndex = 6;
            // 
            // richConsola
            // 
            this.richConsola.Location = new System.Drawing.Point(32, 394);
            this.richConsola.Name = "richConsola";
            this.richConsola.Size = new System.Drawing.Size(559, 158);
            this.richConsola.TabIndex = 1;
            this.richConsola.Text = "";
            // 
            // richMensaje
            // 
            this.richMensaje.Location = new System.Drawing.Point(171, 25);
            this.richMensaje.Name = "richMensaje";
            this.richMensaje.Size = new System.Drawing.Size(368, 89);
            this.richMensaje.TabIndex = 7;
            this.richMensaje.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 564);
            this.Controls.Add(this.richConsola);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Daniel Clas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richMensaje;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RichTextBox richConsola;
    }
}

