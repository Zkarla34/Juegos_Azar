
namespace juegoss
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnppt = new System.Windows.Forms.Button();
            this.lbnombreppt = new System.Windows.Forms.Label();
            this.lbtotalppt = new System.Windows.Forms.Label();
            this.opcionppt = new System.Windows.Forms.ComboBox();
            this.textapuestappt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnvolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnppt
            // 
            this.btnppt.ForeColor = System.Drawing.Color.Red;
            this.btnppt.Location = new System.Drawing.Point(115, 200);
            this.btnppt.Name = "btnppt";
            this.btnppt.Size = new System.Drawing.Size(75, 23);
            this.btnppt.TabIndex = 0;
            this.btnppt.Text = "Apostar";
            this.btnppt.UseVisualStyleBackColor = true;
            this.btnppt.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbnombreppt
            // 
            this.lbnombreppt.AutoSize = true;
            this.lbnombreppt.BackColor = System.Drawing.Color.Transparent;
            this.lbnombreppt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombreppt.Location = new System.Drawing.Point(219, 39);
            this.lbnombreppt.Name = "lbnombreppt";
            this.lbnombreppt.Size = new System.Drawing.Size(56, 15);
            this.lbnombreppt.TabIndex = 1;
            this.lbnombreppt.Text = "nombre";
            // 
            // lbtotalppt
            // 
            this.lbtotalppt.AutoSize = true;
            this.lbtotalppt.BackColor = System.Drawing.Color.Transparent;
            this.lbtotalppt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalppt.Location = new System.Drawing.Point(219, 67);
            this.lbtotalppt.Name = "lbtotalppt";
            this.lbtotalppt.Size = new System.Drawing.Size(35, 15);
            this.lbtotalppt.TabIndex = 2;
            this.lbtotalppt.Text = "total";
            // 
            // opcionppt
            // 
            this.opcionppt.AutoCompleteCustomSource.AddRange(new string[] {
            "Piedra",
            "Papel",
            "Tijera"});
            this.opcionppt.FormattingEnabled = true;
            this.opcionppt.Items.AddRange(new object[] {
            "Piedra",
            "Papel",
            "Tijera"});
            this.opcionppt.Location = new System.Drawing.Point(76, 92);
            this.opcionppt.Name = "opcionppt";
            this.opcionppt.Size = new System.Drawing.Size(121, 21);
            this.opcionppt.TabIndex = 3;
            // 
            // textapuestappt
            // 
            this.textapuestappt.Location = new System.Drawing.Point(104, 142);
            this.textapuestappt.Name = "textapuestappt";
            this.textapuestappt.Size = new System.Drawing.Size(100, 20);
            this.textapuestappt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Juego Piedra, Papel y Tijera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Opción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor apostar";
            // 
            // btnvolver
            // 
            this.btnvolver.ForeColor = System.Drawing.Color.Red;
            this.btnvolver.Location = new System.Drawing.Point(197, 200);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(75, 23);
            this.btnvolver.TabIndex = 8;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(396, 296);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textapuestappt);
            this.Controls.Add(this.opcionppt);
            this.Controls.Add(this.lbtotalppt);
            this.Controls.Add(this.lbnombreppt);
            this.Controls.Add(this.btnppt);
            this.Name = "Form3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnppt;
        public System.Windows.Forms.Label lbnombreppt;
        public System.Windows.Forms.Label lbtotalppt;
        private System.Windows.Forms.ComboBox opcionppt;
        public System.Windows.Forms.TextBox textapuestappt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnvolver;
    }
}