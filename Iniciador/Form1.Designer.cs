﻿namespace Iniciador
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
            this.label4 = new System.Windows.Forms.Label();
            this.dgvvista = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.rtblogs = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_puerto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.KDC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtdestino = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvista)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 495);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Logs";
            // 
            // dgvvista
            // 
            this.dgvvista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvista.Location = new System.Drawing.Point(126, 520);
            this.dgvvista.Name = "dgvvista";
            this.dgvvista.Size = new System.Drawing.Size(317, 150);
            this.dgvvista.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Logs";
            // 
            // rtblogs
            // 
            this.rtblogs.Location = new System.Drawing.Point(126, 293);
            this.rtblogs.Name = "rtblogs";
            this.rtblogs.Size = new System.Drawing.Size(317, 140);
            this.rtblogs.TabIndex = 16;
            this.rtblogs.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(784, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "puerto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "nombre";
            // 
            // tb_puerto
            // 
            this.tb_puerto.Location = new System.Drawing.Point(584, 130);
            this.tb_puerto.Name = "tb_puerto";
            this.tb_puerto.Size = new System.Drawing.Size(100, 20);
            this.tb_puerto.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // KDC
            // 
            this.KDC.AutoSize = true;
            this.KDC.Location = new System.Drawing.Point(441, 90);
            this.KDC.Name = "KDC";
            this.KDC.Size = new System.Drawing.Size(29, 13);
            this.KDC.TabIndex = 10;
            this.KDC.Text = "KDC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(510, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "numero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "destino";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(584, 200);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 21;
            // 
            // txtdestino
            // 
            this.txtdestino.Location = new System.Drawing.Point(271, 200);
            this.txtdestino.Name = "txtdestino";
            this.txtdestino.Size = new System.Drawing.Size(100, 20);
            this.txtdestino.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 671);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtdestino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvvista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtblogs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_puerto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.KDC);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvvista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvvista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtblogs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_puerto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label KDC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtdestino;
    }
}

