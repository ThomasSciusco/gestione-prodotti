namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pulsante = new System.Windows.Forms.Button();
            this.primo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.etichetta = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // pulsante
            // 
            this.pulsante.Location = new System.Drawing.Point(61, 189);
            this.pulsante.Name = "pulsante";
            this.pulsante.Size = new System.Drawing.Size(75, 23);
            this.pulsante.TabIndex = 0;
            this.pulsante.Text = "copia";
            this.pulsante.UseVisualStyleBackColor = true;
            this.pulsante.Click += new System.EventHandler(this.button1_Click);
            // 
            // primo
            // 
            this.primo.Location = new System.Drawing.Point(61, 123);
            this.primo.Name = "primo";
            this.primo.Size = new System.Drawing.Size(100, 20);
            this.primo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Elemento";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(505, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(266, 368);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // etichetta
            // 
            this.etichetta.AutoSize = true;
            this.etichetta.Location = new System.Drawing.Point(102, 25);
            this.etichetta.Name = "etichetta";
            this.etichetta.Size = new System.Drawing.Size(109, 13);
            this.etichetta.TabIndex = 6;
            this.etichetta.Text = "Progrmamma di prova";
            this.etichetta.Click += new System.EventHandler(this.etichetta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etichetta);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.primo);
            this.Controls.Add(this.pulsante);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pulsante;
        private System.Windows.Forms.TextBox primo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label etichetta;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

