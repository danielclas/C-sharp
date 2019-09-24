namespace Ejercicio_40
{
    partial class Llamador
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
            this.textBoxNroDestino = new System.Windows.Forms.TextBox();
            this.groupBoxPanel = new System.Windows.Forms.GroupBox();
            this.buttonNumeral = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonAsterico = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonLlamar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.textBoxNroOrigen = new System.Windows.Forms.TextBox();
            this.comboBoxFranja = new System.Windows.Forms.ComboBox();
            this.groupBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNroDestino
            // 
            this.textBoxNroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNroDestino.Location = new System.Drawing.Point(23, 22);
            this.textBoxNroDestino.Name = "textBoxNroDestino";
            this.textBoxNroDestino.ReadOnly = true;
            this.textBoxNroDestino.Size = new System.Drawing.Size(385, 30);
            this.textBoxNroDestino.TabIndex = 0;
            this.textBoxNroDestino.Text = "Nro Destino";
            this.textBoxNroDestino.Click += new System.EventHandler(this.CambiarTextBoxDestino);
            this.textBoxNroDestino.TextChanged += new System.EventHandler(this.ControlarDestino);
            // 
            // groupBoxPanel
            // 
            this.groupBoxPanel.Controls.Add(this.buttonNumeral);
            this.groupBoxPanel.Controls.Add(this.button0);
            this.groupBoxPanel.Controls.Add(this.buttonAsterico);
            this.groupBoxPanel.Controls.Add(this.button9);
            this.groupBoxPanel.Controls.Add(this.button8);
            this.groupBoxPanel.Controls.Add(this.button7);
            this.groupBoxPanel.Controls.Add(this.button6);
            this.groupBoxPanel.Controls.Add(this.button5);
            this.groupBoxPanel.Controls.Add(this.button4);
            this.groupBoxPanel.Controls.Add(this.button3);
            this.groupBoxPanel.Controls.Add(this.button2);
            this.groupBoxPanel.Controls.Add(this.button1);
            this.groupBoxPanel.Location = new System.Drawing.Point(23, 76);
            this.groupBoxPanel.Name = "groupBoxPanel";
            this.groupBoxPanel.Size = new System.Drawing.Size(216, 258);
            this.groupBoxPanel.TabIndex = 1;
            this.groupBoxPanel.TabStop = false;
            this.groupBoxPanel.Text = "Panel";
            // 
            // buttonNumeral
            // 
            this.buttonNumeral.Location = new System.Drawing.Point(147, 202);
            this.buttonNumeral.Name = "buttonNumeral";
            this.buttonNumeral.Size = new System.Drawing.Size(53, 50);
            this.buttonNumeral.TabIndex = 11;
            this.buttonNumeral.Text = "#";
            this.buttonNumeral.UseVisualStyleBackColor = true;
            this.buttonNumeral.Click += new System.EventHandler(this.buttonNumeral_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(77, 202);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(53, 50);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonAsterico
            // 
            this.buttonAsterico.Location = new System.Drawing.Point(6, 202);
            this.buttonAsterico.Name = "buttonAsterico";
            this.buttonAsterico.Size = new System.Drawing.Size(53, 50);
            this.buttonAsterico.TabIndex = 9;
            this.buttonAsterico.Text = "*";
            this.buttonAsterico.UseVisualStyleBackColor = true;
            this.buttonAsterico.Click += new System.EventHandler(this.buttonAsterico_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(147, 146);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(53, 50);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(77, 146);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(53, 50);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 146);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 50);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(147, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 50);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(77, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 50);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(77, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonLlamar
            // 
            this.buttonLlamar.Location = new System.Drawing.Point(245, 115);
            this.buttonLlamar.Name = "buttonLlamar";
            this.buttonLlamar.Size = new System.Drawing.Size(163, 45);
            this.buttonLlamar.TabIndex = 2;
            this.buttonLlamar.Text = "Llamar";
            this.buttonLlamar.UseVisualStyleBackColor = true;
            this.buttonLlamar.Click += new System.EventHandler(this.buttonLlamar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(245, 171);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(163, 45);
            this.buttonLimpiar.TabIndex = 3;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(245, 278);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(163, 45);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // textBoxNroOrigen
            // 
            this.textBoxNroOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNroOrigen.Location = new System.Drawing.Point(245, 229);
            this.textBoxNroOrigen.Name = "textBoxNroOrigen";
            this.textBoxNroOrigen.ReadOnly = true;
            this.textBoxNroOrigen.Size = new System.Drawing.Size(163, 30);
            this.textBoxNroOrigen.TabIndex = 5;
            this.textBoxNroOrigen.Text = "Nro Origen";
            this.textBoxNroOrigen.Click += new System.EventHandler(this.CambiarTextBoxOrigen);
            // 
            // comboBoxFranja
            // 
            this.comboBoxFranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFranja.FormattingEnabled = true;
            this.comboBoxFranja.Location = new System.Drawing.Point(29, 355);
            this.comboBoxFranja.Name = "comboBoxFranja";
            this.comboBoxFranja.Size = new System.Drawing.Size(379, 33);
            this.comboBoxFranja.TabIndex = 6;
            this.comboBoxFranja.Text = "Franja";
            this.comboBoxFranja.TextChanged += new System.EventHandler(this.ControlarDestino);
            // 
            // Llamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 418);
            this.Controls.Add(this.comboBoxFranja);
            this.Controls.Add(this.textBoxNroOrigen);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonLlamar);
            this.Controls.Add(this.groupBoxPanel);
            this.Controls.Add(this.textBoxNroDestino);
            this.Name = "Llamador";
            this.Text = "Llamador";
            this.groupBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNroDestino;
        private System.Windows.Forms.GroupBox groupBoxPanel;
        private System.Windows.Forms.Button buttonNumeral;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonAsterico;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonLlamar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TextBox textBoxNroOrigen;
        private System.Windows.Forms.ComboBox comboBoxFranja;
    }
}