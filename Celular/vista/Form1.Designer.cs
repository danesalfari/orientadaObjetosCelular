namespace Celular
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTextear = new System.Windows.Forms.Button();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnPrender = new System.Windows.Forms.Button();
            this.btnCaerse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MotoMoto";
            // 
            // btnTextear
            // 
            this.btnTextear.Location = new System.Drawing.Point(76, 93);
            this.btnTextear.Name = "btnTextear";
            this.btnTextear.Size = new System.Drawing.Size(76, 37);
            this.btnTextear.TabIndex = 1;
            this.btnTextear.Text = "TEXTEAR";
            this.btnTextear.UseVisualStyleBackColor = true;
            this.btnTextear.Click += new System.EventHandler(this.btnTextear_Click);
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(10, 93);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(61, 37);
            this.btnLlamar.TabIndex = 2;
            this.btnLlamar.Text = "LLAMAR";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(47, 136);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(51, 23);
            this.btnApagar.TabIndex = 3;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnPrender
            // 
            this.btnPrender.Location = new System.Drawing.Point(91, 205);
            this.btnPrender.Name = "btnPrender";
            this.btnPrender.Size = new System.Drawing.Size(61, 32);
            this.btnPrender.TabIndex = 4;
            this.btnPrender.Text = "Prender";
            this.btnPrender.UseVisualStyleBackColor = true;
            this.btnPrender.Click += new System.EventHandler(this.btnPrender_Click);
            // 
            // btnCaerse
            // 
            this.btnCaerse.Location = new System.Drawing.Point(10, 205);
            this.btnCaerse.Name = "btnCaerse";
            this.btnCaerse.Size = new System.Drawing.Size(56, 32);
            this.btnCaerse.TabIndex = 5;
            this.btnCaerse.Text = "Caerse";
            this.btnCaerse.UseVisualStyleBackColor = true;
            this.btnCaerse.Click += new System.EventHandler(this.btnCaerse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 249);
            this.Controls.Add(this.btnCaerse);
            this.Controls.Add(this.btnPrender);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.btnTextear);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTextear;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnPrender;
        private System.Windows.Forms.Button btnCaerse;
    }
}

