namespace ExPag33
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.lblinserir = new System.Windows.Forms.Label();
            this.btnverificar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(394, 39);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(137, 20);
            this.txtvalor.TabIndex = 0;
            this.txtvalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(394, 125);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(137, 20);
            this.txtresultado.TabIndex = 1;
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblinserir
            // 
            this.lblinserir.AutoSize = true;
            this.lblinserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinserir.Location = new System.Drawing.Point(11, 34);
            this.lblinserir.Name = "lblinserir";
            this.lblinserir.Size = new System.Drawing.Size(364, 25);
            this.lblinserir.TabIndex = 2;
            this.lblinserir.Text = "coloque um valor entre  \"A\", \"B\" e \"C\"";
            this.lblinserir.Click += new System.EventHandler(this.lblinserir_Click);
            // 
            // btnverificar
            // 
            this.btnverificar.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverificar.Location = new System.Drawing.Point(379, 65);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(167, 54);
            this.btnverificar.TabIndex = 3;
            this.btnverificar.Text = "Verificar";
            this.btnverificar.UseVisualStyleBackColor = true;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(84, 120);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(291, 25);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "Resultado do valor colocado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(590, 173);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.lblinserir);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtvalor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label lblinserir;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Label lblresultado;
    }
}

