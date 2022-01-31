
namespace Ejemplo3Guia1LabPED
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtespaciado = new System.Windows.Forms.TextBox();
            this.cmbcolor = new System.Windows.Forms.ComboBox();
            this.btndibujar = new System.Windows.Forms.Button();
            this.areadibujo = new System.Windows.Forms.PictureBox();
            this.txttermina = new System.Windows.Forms.TextBox();
            this.txtinicio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.areadibujo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espaciado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(82, 29);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(112, 23);
            this.txtcantidad.TabIndex = 3;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            // 
            // txtespaciado
            // 
            this.txtespaciado.Location = new System.Drawing.Point(88, 64);
            this.txtespaciado.Margin = new System.Windows.Forms.Padding(2);
            this.txtespaciado.Name = "txtespaciado";
            this.txtespaciado.Size = new System.Drawing.Size(106, 23);
            this.txtespaciado.TabIndex = 4;
            // 
            // cmbcolor
            // 
            this.cmbcolor.FormattingEnabled = true;
            this.cmbcolor.Items.AddRange(new object[] {
            "Amarillo",
            "Rojo",
            "Azul",
            "Negro"});
            this.cmbcolor.Location = new System.Drawing.Point(83, 100);
            this.cmbcolor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbcolor.Name = "cmbcolor";
            this.cmbcolor.Size = new System.Drawing.Size(111, 23);
            this.cmbcolor.TabIndex = 5;
            // 
            // btndibujar
            // 
            this.btndibujar.Location = new System.Drawing.Point(20, 217);
            this.btndibujar.Margin = new System.Windows.Forms.Padding(2);
            this.btndibujar.Name = "btndibujar";
            this.btndibujar.Size = new System.Drawing.Size(174, 23);
            this.btndibujar.TabIndex = 6;
            this.btndibujar.Text = "Dibujar líneas";
            this.btndibujar.UseVisualStyleBackColor = true;
            this.btndibujar.Click += new System.EventHandler(this.btndibujar_Click);
            // 
            // areadibujo
            // 
            this.areadibujo.Location = new System.Drawing.Point(209, 14);
            this.areadibujo.Margin = new System.Windows.Forms.Padding(2);
            this.areadibujo.Name = "areadibujo";
            this.areadibujo.Size = new System.Drawing.Size(294, 252);
            this.areadibujo.TabIndex = 7;
            this.areadibujo.TabStop = false;
            this.areadibujo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txttermina
            // 
            this.txttermina.Location = new System.Drawing.Point(88, 179);
            this.txttermina.Margin = new System.Windows.Forms.Padding(2);
            this.txttermina.Name = "txttermina";
            this.txttermina.Size = new System.Drawing.Size(106, 23);
            this.txttermina.TabIndex = 11;
            // 
            // txtinicio
            // 
            this.txtinicio.Location = new System.Drawing.Point(82, 144);
            this.txtinicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtinicio.Name = "txtinicio";
            this.txtinicio.Size = new System.Drawing.Size(112, 23);
            this.txtinicio.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Punto termina";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Punto inicia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 281);
            this.Controls.Add(this.txttermina);
            this.Controls.Add(this.txtinicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.areadibujo);
            this.Controls.Add(this.btndibujar);
            this.Controls.Add(this.cmbcolor);
            this.Controls.Add(this.txtespaciado);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.areadibujo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtespaciado;
        private System.Windows.Forms.ComboBox cmbcolor;
        private System.Windows.Forms.Button btndibujar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox areadibujo;
        private System.Windows.Forms.TextBox txttermina;
        private System.Windows.Forms.TextBox txtinicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

