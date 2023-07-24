
namespace juegoss
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
            this.btncaraysello = new System.Windows.Forms.Button();
            this.btnppt = new System.Windows.Forms.Button();
            this.btndados = new System.Windows.Forms.Button();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbtotal = new System.Windows.Forms.Label();
            this.textnombre = new System.Windows.Forms.TextBox();
            this.texttotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncaraysello
            // 
            this.btncaraysello.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncaraysello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btncaraysello.Location = new System.Drawing.Point(13, 178);
            this.btncaraysello.Name = "btncaraysello";
            this.btncaraysello.Size = new System.Drawing.Size(124, 23);
            this.btncaraysello.TabIndex = 0;
            this.btncaraysello.Text = "Juego Cara y sello";
            this.btncaraysello.UseVisualStyleBackColor = true;
            this.btncaraysello.Click += new System.EventHandler(this.btncaraysello_Click);
            // 
            // btnppt
            // 
            this.btnppt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnppt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnppt.Location = new System.Drawing.Point(143, 178);
            this.btnppt.Name = "btnppt";
            this.btnppt.Size = new System.Drawing.Size(163, 23);
            this.btnppt.TabIndex = 1;
            this.btnppt.Text = "Juego Piedra, papel y tijera";
            this.btnppt.UseVisualStyleBackColor = true;
            this.btnppt.Click += new System.EventHandler(this.btnppt_Click);
            // 
            // btndados
            // 
            this.btndados.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btndados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btndados.Location = new System.Drawing.Point(312, 178);
            this.btndados.Name = "btndados";
            this.btndados.Size = new System.Drawing.Size(109, 23);
            this.btndados.TabIndex = 2;
            this.btndados.Text = "Juego Dados";
            this.btndados.UseVisualStyleBackColor = true;
            this.btndados.Click += new System.EventHandler(this.btndados_Click);
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.BackColor = System.Drawing.Color.Transparent;
            this.lbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.ForeColor = System.Drawing.Color.White;
            this.lbnombre.Location = new System.Drawing.Point(58, 76);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(68, 18);
            this.lbnombre.TabIndex = 3;
            this.lbnombre.Text = "Nombre";
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.BackColor = System.Drawing.Color.Transparent;
            this.lbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.ForeColor = System.Drawing.Color.White;
            this.lbtotal.Location = new System.Drawing.Point(58, 114);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(95, 18);
            this.lbtotal.TabIndex = 4;
            this.lbtotal.Text = "Valor Inicial";
            // 
            // textnombre
            // 
            this.textnombre.Location = new System.Drawing.Point(151, 81);
            this.textnombre.Name = "textnombre";
            this.textnombre.Size = new System.Drawing.Size(155, 20);
            this.textnombre.TabIndex = 5;
            // 
            // texttotal
            // 
            this.texttotal.Location = new System.Drawing.Point(151, 112);
            this.texttotal.Name = "texttotal";
            this.texttotal.Size = new System.Drawing.Size(155, 20);
            this.texttotal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(103, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "JUEGOS DE AZAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(470, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texttotal);
            this.Controls.Add(this.textnombre);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.btndados);
            this.Controls.Add(this.btnppt);
            this.Controls.Add(this.btncaraysello);
            this.Name = "Form1";
            this.Text = "Juegos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncaraysello;
        private System.Windows.Forms.Button btnppt;
        private System.Windows.Forms.Button btndados;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.TextBox textnombre;
        private System.Windows.Forms.TextBox texttotal;
        private System.Windows.Forms.Label label2;
    }
}

