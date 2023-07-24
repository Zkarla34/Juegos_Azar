
namespace juegoss
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnapuestacs = new System.Windows.Forms.Button();
            this.lbnombrecs = new System.Windows.Forms.Label();
            this.apuesta = new System.Windows.Forms.Label();
            this.textapuestacs = new System.Windows.Forms.TextBox();
            this.lbtotalcs = new System.Windows.Forms.Label();
            this.opcioncs = new System.Windows.Forms.ComboBox();
            this.lbopcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnapuestacs
            // 
            this.btnapuestacs.ForeColor = System.Drawing.Color.Red;
            this.btnapuestacs.Location = new System.Drawing.Point(104, 195);
            this.btnapuestacs.Name = "btnapuestacs";
            this.btnapuestacs.Size = new System.Drawing.Size(75, 23);
            this.btnapuestacs.TabIndex = 0;
            this.btnapuestacs.Text = "Apostar";
            this.btnapuestacs.UseVisualStyleBackColor = true;
            this.btnapuestacs.Click += new System.EventHandler(this.btnapuestacs_Click);
            // 
            // lbnombrecs
            // 
            this.lbnombrecs.AutoSize = true;
            this.lbnombrecs.BackColor = System.Drawing.Color.Transparent;
            this.lbnombrecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombrecs.Location = new System.Drawing.Point(272, 15);
            this.lbnombrecs.Name = "lbnombrecs";
            this.lbnombrecs.Size = new System.Drawing.Size(65, 18);
            this.lbnombrecs.TabIndex = 1;
            this.lbnombrecs.Text = "nombre";
            // 
            // apuesta
            // 
            this.apuesta.AutoSize = true;
            this.apuesta.BackColor = System.Drawing.Color.Transparent;
            this.apuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apuesta.ForeColor = System.Drawing.Color.Red;
            this.apuesta.Location = new System.Drawing.Point(5, 128);
            this.apuesta.Name = "apuesta";
            this.apuesta.Size = new System.Drawing.Size(111, 18);
            this.apuesta.TabIndex = 3;
            this.apuesta.Text = "Valor apuesta";
            // 
            // textapuestacs
            // 
            this.textapuestacs.Location = new System.Drawing.Point(119, 125);
            this.textapuestacs.Name = "textapuestacs";
            this.textapuestacs.Size = new System.Drawing.Size(121, 20);
            this.textapuestacs.TabIndex = 4;
            // 
            // lbtotalcs
            // 
            this.lbtotalcs.AutoSize = true;
            this.lbtotalcs.BackColor = System.Drawing.Color.Transparent;
            this.lbtotalcs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalcs.Location = new System.Drawing.Point(272, 45);
            this.lbtotalcs.Name = "lbtotalcs";
            this.lbtotalcs.Size = new System.Drawing.Size(46, 18);
            this.lbtotalcs.TabIndex = 5;
            this.lbtotalcs.Text = "Total";
            // 
            // opcioncs
            // 
            this.opcioncs.FormattingEnabled = true;
            this.opcioncs.Items.AddRange(new object[] {
            "Cara",
            "Sello"});
            this.opcioncs.Location = new System.Drawing.Point(81, 87);
            this.opcioncs.Name = "opcioncs";
            this.opcioncs.Size = new System.Drawing.Size(121, 21);
            this.opcioncs.TabIndex = 7;
            // 
            // lbopcion
            // 
            this.lbopcion.AutoSize = true;
            this.lbopcion.BackColor = System.Drawing.Color.Transparent;
            this.lbopcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbopcion.ForeColor = System.Drawing.Color.Black;
            this.lbopcion.Location = new System.Drawing.Point(5, 87);
            this.lbopcion.Name = "lbopcion";
            this.lbopcion.Size = new System.Drawing.Size(62, 18);
            this.lbopcion.TabIndex = 8;
            this.lbopcion.Text = "Opción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Juego Cara y Sello";
            // 
            // btnvolver
            // 
            this.btnvolver.ForeColor = System.Drawing.Color.Red;
            this.btnvolver.Location = new System.Drawing.Point(185, 195);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 10;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(423, 322);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbopcion);
            this.Controls.Add(this.opcioncs);
            this.Controls.Add(this.lbtotalcs);
            this.Controls.Add(this.textapuestacs);
            this.Controls.Add(this.apuesta);
            this.Controls.Add(this.lbnombrecs);
            this.Controls.Add(this.btnapuestacs);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnapuestacs;
        public System.Windows.Forms.Label lbnombrecs;
        public System.Windows.Forms.Label apuesta;
        public System.Windows.Forms.TextBox textapuestacs;
        public System.Windows.Forms.Label lbtotalcs;
        private System.Windows.Forms.ComboBox opcioncs;
        private System.Windows.Forms.Label lbopcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnvolver;
    }
}