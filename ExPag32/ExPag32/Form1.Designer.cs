namespace ExPag32
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
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtdigitenum = new System.Windows.Forms.TextBox();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.lblinserir = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F);
            this.btncalcular.Location = new System.Drawing.Point(183, 163);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(404, 120);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Verificar";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // txtdigitenum
            // 
            this.txtdigitenum.Location = new System.Drawing.Point(387, 106);
            this.txtdigitenum.Name = "txtdigitenum";
            this.txtdigitenum.Size = new System.Drawing.Size(128, 20);
            this.txtdigitenum.TabIndex = 1;
            this.txtdigitenum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdigitenum.TextChanged += new System.EventHandler(this.txtdigitenum_TextChanged);
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(387, 317);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(128, 20);
            this.txtresultado.TabIndex = 2;
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblinserir
            // 
            this.lblinserir.AutoSize = true;
            this.lblinserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinserir.Location = new System.Drawing.Point(211, 100);
            this.lblinserir.Name = "lblinserir";
            this.lblinserir.Size = new System.Drawing.Size(183, 25);
            this.lblinserir.TabIndex = 3;
            this.lblinserir.Text = "Insira um número:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.BackColor = System.Drawing.Color.Brown;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(266, 312);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(115, 25);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "Resultado:";
            this.lblresultado.Click += new System.EventHandler(this.lblresultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblinserir);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.txtdigitenum);
            this.Controls.Add(this.btncalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtdigitenum;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label lblinserir;
        private System.Windows.Forms.Label lblresultado;
    }
}

