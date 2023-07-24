
namespace juegoss
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btndados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apostard = new System.Windows.Forms.TextBox();
            this.lbnombred = new System.Windows.Forms.Label();
            this.lbtotald = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndados
            // 
            this.btndados.ForeColor = System.Drawing.Color.Red;
            this.btndados.Location = new System.Drawing.Point(130, 162);
            this.btndados.Name = "btndados";
            this.btndados.Size = new System.Drawing.Size(75, 23);
            this.btndados.TabIndex = 0;
            this.btndados.Text = "Apostar";
            this.btndados.UseVisualStyleBackColor = true;
            this.btndados.Click += new System.EventHandler(this.btndados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Juego Dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor apostar";
            // 
            // apostard
            // 
            this.apostard.Location = new System.Drawing.Point(114, 107);
            this.apostard.Name = "apostard";
            this.apostard.Size = new System.Drawing.Size(100, 20);
            this.apostard.TabIndex = 3;
            // 
            // lbnombred
            // 
            this.lbnombred.AutoSize = true;
            this.lbnombred.BackColor = System.Drawing.Color.Transparent;
            this.lbnombred.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombred.Location = new System.Drawing.Point(271, 37);
            this.lbnombred.Name = "lbnombred";
            this.lbnombred.Size = new System.Drawing.Size(60, 16);
            this.lbnombred.TabIndex = 4;
            this.lbnombred.Text = "nombre";
            // 
            // lbtotald
            // 
            this.lbtotald.AutoSize = true;
            this.lbtotald.BackColor = System.Drawing.Color.Transparent;
            this.lbtotald.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotald.Location = new System.Drawing.Point(271, 68);
            this.lbtotald.Name = "lbtotald";
            this.lbtotald.Size = new System.Drawing.Size(38, 16);
            this.lbtotald.TabIndex = 5;
            this.lbtotald.Text = "total";
            // 
            // btnvolver
            // 
            this.btnvolver.ForeColor = System.Drawing.Color.Red;
            this.btnvolver.Location = new System.Drawing.Point(212, 162);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 6;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(432, 285);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.lbtotald);
            this.Controls.Add(this.lbnombred);
            this.Controls.Add(this.apostard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndados);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apostard;
        public System.Windows.Forms.Label lbnombred;
        public System.Windows.Forms.Label lbtotald;
        private System.Windows.Forms.Button btnvolver;
    }
}