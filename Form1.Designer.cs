
namespace Semana2Form
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
            this.btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.est1 = new System.Windows.Forms.Label();
            this.est2 = new System.Windows.Forms.Label();
            this.est3 = new System.Windows.Forms.Label();
            this.est4 = new System.Windows.Forms.Label();
            this.est5 = new System.Windows.Forms.Label();
            this.est6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(221, 87);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(229, 34);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Clickea aqui";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombres de los participantes";
            // 
            // est1
            // 
            this.est1.AutoSize = true;
            this.est1.Location = new System.Drawing.Point(289, 144);
            this.est1.Name = "est1";
            this.est1.Size = new System.Drawing.Size(13, 17);
            this.est1.TabIndex = 2;
            this.est1.Text = "-";
            this.est1.Click += new System.EventHandler(this.est1_Click);
            // 
            // est2
            // 
            this.est2.AutoSize = true;
            this.est2.Location = new System.Drawing.Point(289, 187);
            this.est2.Name = "est2";
            this.est2.Size = new System.Drawing.Size(13, 17);
            this.est2.TabIndex = 3;
            this.est2.Text = "-";
            // 
            // est3
            // 
            this.est3.AutoSize = true;
            this.est3.Location = new System.Drawing.Point(289, 222);
            this.est3.Name = "est3";
            this.est3.Size = new System.Drawing.Size(13, 17);
            this.est3.TabIndex = 4;
            this.est3.Text = "-";
            // 
            // est4
            // 
            this.est4.AutoSize = true;
            this.est4.Location = new System.Drawing.Point(289, 257);
            this.est4.Name = "est4";
            this.est4.Size = new System.Drawing.Size(13, 17);
            this.est4.TabIndex = 5;
            this.est4.Text = "-";
            // 
            // est5
            // 
            this.est5.AutoSize = true;
            this.est5.Location = new System.Drawing.Point(289, 294);
            this.est5.Name = "est5";
            this.est5.Size = new System.Drawing.Size(13, 17);
            this.est5.TabIndex = 6;
            this.est5.Text = "-";
            // 
            // est6
            // 
            this.est6.AutoSize = true;
            this.est6.Location = new System.Drawing.Point(289, 345);
            this.est6.Name = "est6";
            this.est6.Size = new System.Drawing.Size(13, 17);
            this.est6.TabIndex = 7;
            this.est6.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.est6);
            this.Controls.Add(this.est5);
            this.Controls.Add(this.est4);
            this.Controls.Add(this.est3);
            this.Controls.Add(this.est2);
            this.Controls.Add(this.est1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label est1;
        private System.Windows.Forms.Label est2;
        private System.Windows.Forms.Label est3;
        private System.Windows.Forms.Label est4;
        private System.Windows.Forms.Label est5;
        private System.Windows.Forms.Label est6;
    }
}

