namespace VistaForm
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
            this.gbpDatosAlumno = new System.Windows.Forms.GroupBox();
            this.gbpDatosCurso = new System.Windows.Forms.GroupBox();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAnioCurso = new System.Windows.Forms.NumericUpDown();
            this.cmbDivisionCurso = new System.Windows.Forms.ComboBox();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.txtApellidoProfe = new System.Windows.Forms.TextBox();
            this.txtDocumentoProfe = new System.Windows.Forms.TextBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.lblDivision = new System.Windows.Forms.Label();
            this.gbpDatosAlumno.SuspendLayout();
            this.gbpDatosCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // gbpDatosAlumno
            // 
            this.gbpDatosAlumno.Controls.Add(this.lblDivision);
            this.gbpDatosAlumno.Controls.Add(this.cmbDivision);
            this.gbpDatosAlumno.Controls.Add(this.nudAnio);
            this.gbpDatosAlumno.Controls.Add(this.txtDocumento);
            this.gbpDatosAlumno.Controls.Add(this.txtApellido);
            this.gbpDatosAlumno.Controls.Add(this.txtNombre);
            this.gbpDatosAlumno.Controls.Add(this.lblAnio);
            this.gbpDatosAlumno.Controls.Add(this.lblDocumento);
            this.gbpDatosAlumno.Controls.Add(this.lblApellido);
            this.gbpDatosAlumno.Controls.Add(this.lblNombre);
            this.gbpDatosAlumno.Controls.Add(this.btnAgregar);
            this.gbpDatosAlumno.Location = new System.Drawing.Point(425, 31);
            this.gbpDatosAlumno.Name = "gbpDatosAlumno";
            this.gbpDatosAlumno.Size = new System.Drawing.Size(326, 227);
            this.gbpDatosAlumno.TabIndex = 1;
            this.gbpDatosAlumno.TabStop = false;
            this.gbpDatosAlumno.Text = "Datos Alumno";
            // 
            // gbpDatosCurso
            // 
            this.gbpDatosCurso.Controls.Add(this.dtpFechaIngreso);
            this.gbpDatosCurso.Controls.Add(this.txtDocumentoProfe);
            this.gbpDatosCurso.Controls.Add(this.txtApellidoProfe);
            this.gbpDatosCurso.Controls.Add(this.txtNombreCurso);
            this.gbpDatosCurso.Controls.Add(this.cmbDivisionCurso);
            this.gbpDatosCurso.Controls.Add(this.nudAnioCurso);
            this.gbpDatosCurso.Controls.Add(this.label6);
            this.gbpDatosCurso.Controls.Add(this.label5);
            this.gbpDatosCurso.Controls.Add(this.label4);
            this.gbpDatosCurso.Controls.Add(this.label3);
            this.gbpDatosCurso.Controls.Add(this.label2);
            this.gbpDatosCurso.Controls.Add(this.label1);
            this.gbpDatosCurso.Controls.Add(this.btnMostrar);
            this.gbpDatosCurso.Controls.Add(this.btnCrear);
            this.gbpDatosCurso.Location = new System.Drawing.Point(38, 31);
            this.gbpDatosCurso.Name = "gbpDatosCurso";
            this.gbpDatosCurso.Size = new System.Drawing.Size(326, 247);
            this.gbpDatosCurso.TabIndex = 2;
            this.gbpDatosCurso.TabStop = false;
            this.gbpDatosCurso.Text = "DatosCurso";
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(38, 284);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(713, 154);
            this.rtbDatos.TabIndex = 3;
            this.rtbDatos.Text = "";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(22, 203);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(103, 38);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear Curso";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(172, 203);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(103, 38);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(203, 183);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 38);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Division";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "DNI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ingreso";
            // 
            // nudAnioCurso
            // 
            this.nudAnioCurso.Location = new System.Drawing.Point(138, 31);
            this.nudAnioCurso.Name = "nudAnioCurso";
            this.nudAnioCurso.Size = new System.Drawing.Size(155, 20);
            this.nudAnioCurso.TabIndex = 8;
            // 
            // cmbDivisionCurso
            // 
            this.cmbDivisionCurso.FormattingEnabled = true;
            this.cmbDivisionCurso.Location = new System.Drawing.Point(138, 58);
            this.cmbDivisionCurso.Name = "cmbDivisionCurso";
            this.cmbDivisionCurso.Size = new System.Drawing.Size(155, 21);
            this.cmbDivisionCurso.TabIndex = 9;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(138, 86);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(155, 20);
            this.txtNombreCurso.TabIndex = 10;
            // 
            // txtApellidoProfe
            // 
            this.txtApellidoProfe.Location = new System.Drawing.Point(138, 112);
            this.txtApellidoProfe.Name = "txtApellidoProfe";
            this.txtApellidoProfe.Size = new System.Drawing.Size(155, 20);
            this.txtApellidoProfe.TabIndex = 11;
            // 
            // txtDocumentoProfe
            // 
            this.txtDocumentoProfe.Location = new System.Drawing.Point(138, 138);
            this.txtDocumentoProfe.Name = "txtDocumentoProfe";
            this.txtDocumentoProfe.Size = new System.Drawing.Size(155, 20);
            this.txtDocumentoProfe.TabIndex = 12;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(138, 165);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(155, 20);
            this.dtpFechaIngreso.TabIndex = 13;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(59, 41);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(59, 69);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(59, 96);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(39, 13);
            this.lblDocumento.TabIndex = 5;
            this.lblDocumento.Text = "Legajo";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(59, 121);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 6;
            this.lblAnio.Text = "Año";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(151, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(151, 66);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(155, 20);
            this.txtApellido.TabIndex = 12;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(151, 93);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(155, 20);
            this.txtDocumento.TabIndex = 13;
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(151, 119);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(155, 20);
            this.nudAnio.TabIndex = 14;
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(151, 145);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(155, 21);
            this.cmbDivision.TabIndex = 15;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(59, 148);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 16;
            this.lblDivision.Text = "Division";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.gbpDatosCurso);
            this.Controls.Add(this.gbpDatosAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbpDatosAlumno.ResumeLayout(false);
            this.gbpDatosAlumno.PerformLayout();
            this.gbpDatosCurso.ResumeLayout(false);
            this.gbpDatosCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox gbpDatosAlumno;
    private System.Windows.Forms.Label lblDivision;
    private System.Windows.Forms.ComboBox cmbDivision;
    private System.Windows.Forms.NumericUpDown nudAnio;
    private System.Windows.Forms.TextBox txtDocumento;
    private System.Windows.Forms.TextBox txtApellido;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.Label lblAnio;
    private System.Windows.Forms.Label lblDocumento;
    private System.Windows.Forms.Label lblApellido;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.GroupBox gbpDatosCurso;
    private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
    private System.Windows.Forms.TextBox txtDocumentoProfe;
    private System.Windows.Forms.TextBox txtApellidoProfe;
    private System.Windows.Forms.TextBox txtNombreCurso;
    private System.Windows.Forms.ComboBox cmbDivisionCurso;
    private System.Windows.Forms.NumericUpDown nudAnioCurso;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnMostrar;
    private System.Windows.Forms.Button btnCrear;
    private System.Windows.Forms.RichTextBox rtbDatos;
  }
}

