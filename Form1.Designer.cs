namespace CasoDesarrolloAle4
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
            this.lvFacturas = new System.Windows.Forms.ListView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtFechaFact = new System.Windows.Forms.TextBox();
            this.txtMontoFact = new System.Windows.Forms.TextBox();
            this.txtNumFact = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblTotalSub = new System.Windows.Forms.Label();
            this.lblTotalFact = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvFacturas
            // 
            this.lvFacturas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvFacturas.HideSelection = false;
            this.lvFacturas.Location = new System.Drawing.Point(135, 217);
            this.lvFacturas.Name = "lvFacturas";
            this.lvFacturas.Size = new System.Drawing.Size(573, 97);
            this.lvFacturas.TabIndex = 41;
            this.lvFacturas.UseCompatibleStateImageBehavior = false;
            this.lvFacturas.View = System.Windows.Forms.View.Details;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(577, 181);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 23);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(429, 181);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(131, 23);
            this.btnRegistrar.TabIndex = 39;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtFechaFact
            // 
            this.txtFechaFact.Location = new System.Drawing.Point(429, 115);
            this.txtFechaFact.Name = "txtFechaFact";
            this.txtFechaFact.Size = new System.Drawing.Size(131, 20);
            this.txtFechaFact.TabIndex = 38;
            // 
            // txtMontoFact
            // 
            this.txtMontoFact.Location = new System.Drawing.Point(175, 157);
            this.txtMontoFact.Name = "txtMontoFact";
            this.txtMontoFact.Size = new System.Drawing.Size(146, 20);
            this.txtMontoFact.TabIndex = 37;
            // 
            // txtNumFact
            // 
            this.txtNumFact.Location = new System.Drawing.Point(175, 119);
            this.txtNumFact.Name = "txtNumFact";
            this.txtNumFact.Size = new System.Drawing.Size(146, 20);
            this.txtNumFact.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(385, 20);
            this.textBox1.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(484, 361);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "COMISION ASIGNADA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(302, 361);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "TOTAL SUBTOTAL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(132, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "TOTAL FACTURAS";
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(484, 392);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(41, 13);
            this.lblComision.TabIndex = 31;
            this.lblComision.Text = "label11";
            // 
            // lblTotalSub
            // 
            this.lblTotalSub.AutoSize = true;
            this.lblTotalSub.Location = new System.Drawing.Point(302, 392);
            this.lblTotalSub.Name = "lblTotalSub";
            this.lblTotalSub.Size = new System.Drawing.Size(41, 13);
            this.lblTotalSub.TabIndex = 30;
            this.lblTotalSub.Text = "label10";
            // 
            // lblTotalFact
            // 
            this.lblTotalFact.AutoSize = true;
            this.lblTotalFact.Location = new System.Drawing.Point(132, 392);
            this.lblTotalFact.Name = "lblTotalFact";
            this.lblTotalFact.Size = new System.Drawing.Size(35, 13);
            this.lblTotalFact.TabIndex = 29;
            this.lblTotalFact.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(372, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "MONTO ASIGNADOS AL VENDEDOR POR EL REGISTRO DE FACTURAS";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(656, 86);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(35, 13);
            this.lblFecha.TabIndex = 27;
            this.lblFecha.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "FECHA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "FECHA FACT.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "MONTO FACT.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "N° FACTURA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "VENDEDOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "CONTROL DE FACTURAS DE VENDEDORES";
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "NUM FACTURA";
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "FECHA DE FACTURACION";
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "MONTO FACTURADO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvFacturas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtFechaFact);
            this.Controls.Add(this.txtMontoFact);
            this.Controls.Add(this.txtNumFact);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.lblTotalSub);
            this.Controls.Add(this.lblTotalFact);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Control de Facturas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFacturas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtFechaFact;
        private System.Windows.Forms.TextBox txtMontoFact;
        private System.Windows.Forms.TextBox txtNumFact;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblTotalSub;
        private System.Windows.Forms.Label lblTotalFact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

