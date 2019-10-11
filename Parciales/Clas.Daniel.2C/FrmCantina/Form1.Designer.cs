namespace FrmCantina
{
  partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBebida = new System.Windows.Forms.GroupBox();
            this.radioAgua = new System.Windows.Forms.RadioButton();
            this.radioCerveza = new System.Windows.Forms.RadioButton();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.numContenido = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblTipoBotella = new System.Windows.Forms.Label();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.barra = new ControlCantina.Barra();
            this.groupBox1.SuspendLayout();
            this.groupBebida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBebida);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.lblMarca);
            this.groupBox1.Controls.Add(this.numCapacidad);
            this.groupBox1.Controls.Add(this.numContenido);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.lblTipoBotella);
            this.groupBox1.Controls.Add(this.cmbBotellaTipo);
            this.groupBox1.Location = new System.Drawing.Point(29, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(197, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contenido";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(109, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Capacidad";
            // 
            // groupBebida
            // 
            this.groupBebida.Controls.Add(this.radioAgua);
            this.groupBebida.Controls.Add(this.radioCerveza);
            this.groupBebida.Location = new System.Drawing.Point(6, 19);
            this.groupBebida.Name = "groupBebida";
            this.groupBebida.Size = new System.Drawing.Size(97, 67);
            this.groupBebida.TabIndex = 9;
            this.groupBebida.TabStop = false;
            // 
            // radioAgua
            // 
            this.radioAgua.AutoSize = true;
            this.radioAgua.Location = new System.Drawing.Point(6, 19);
            this.radioAgua.Name = "radioAgua";
            this.radioAgua.Size = new System.Drawing.Size(50, 17);
            this.radioAgua.TabIndex = 8;
            this.radioAgua.TabStop = true;
            this.radioAgua.Text = "Agua";
            this.radioAgua.UseVisualStyleBackColor = true;
            this.radioAgua.CheckedChanged += new System.EventHandler(this.radioAgua_CheckedChanged);
            // 
            // radioCerveza
            // 
            this.radioCerveza.AutoSize = true;
            this.radioCerveza.Location = new System.Drawing.Point(6, 33);
            this.radioCerveza.Name = "radioCerveza";
            this.radioCerveza.Size = new System.Drawing.Size(64, 17);
            this.radioCerveza.TabIndex = 7;
            this.radioCerveza.TabStop = true;
            this.radioCerveza.Text = "Cerveza";
            this.radioCerveza.UseVisualStyleBackColor = true;
            this.radioCerveza.CheckedChanged += new System.EventHandler(this.radioCerveza_CheckedChanged);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(109, 35);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(141, 20);
            this.txtMarca.TabIndex = 1;
            // 
            // lblMarca
            // 
            this.lblMarca.Location = new System.Drawing.Point(110, 10);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(124, 23);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            // 
            // numCapacidad
            // 
            this.numCapacidad.Location = new System.Drawing.Point(113, 81);
            this.numCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.ReadOnly = true;
            this.numCapacidad.Size = new System.Drawing.Size(81, 20);
            this.numCapacidad.TabIndex = 5;
            this.numCapacidad.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numContenido
            // 
            this.numContenido.Location = new System.Drawing.Point(200, 81);
            this.numContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numContenido.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numContenido.Name = "numContenido";
            this.numContenido.ReadOnly = true;
            this.numContenido.Size = new System.Drawing.Size(81, 20);
            this.numContenido.TabIndex = 4;
            this.numContenido.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(320, 63);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblTipoBotella
            // 
            this.lblTipoBotella.Location = new System.Drawing.Point(317, 10);
            this.lblTipoBotella.Name = "lblTipoBotella";
            this.lblTipoBotella.Size = new System.Drawing.Size(124, 23);
            this.lblTipoBotella.TabIndex = 2;
            this.lblTipoBotella.Text = "Botella Tipo";
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(320, 36);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBotellaTipo.TabIndex = 1;
            // 
            // barra
            // 
            this.barra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra.BackgroundImage")));
            this.barra.Location = new System.Drawing.Point(29, 6);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(551, 368);
            this.barra.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.barra);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Alumno Clas Daniel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBebida.ResumeLayout(false);
            this.groupBebida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numContenido)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtMarca;
    private System.Windows.Forms.Label lblMarca;
    private System.Windows.Forms.NumericUpDown numCapacidad;
    private System.Windows.Forms.NumericUpDown numContenido;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Label lblTipoBotella;
    private System.Windows.Forms.ComboBox cmbBotellaTipo;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.GroupBox groupBebida;
    private System.Windows.Forms.RadioButton radioAgua;
    private System.Windows.Forms.RadioButton radioCerveza;
    private ControlCantina.Barra barra;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
  }
}

