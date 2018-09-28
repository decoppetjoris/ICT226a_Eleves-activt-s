namespace eleves_activites
{
    partial class EleveActivites
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
            this.BtnOpenCSV = new System.Windows.Forms.Button();
            this.OvrirCSV = new System.Windows.Forms.OpenFileDialog();
            this.TxtBTes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnOpenCSV
            // 
            this.BtnOpenCSV.Location = new System.Drawing.Point(28, 29);
            this.BtnOpenCSV.Name = "BtnOpenCSV";
            this.BtnOpenCSV.Size = new System.Drawing.Size(75, 23);
            this.BtnOpenCSV.TabIndex = 0;
            this.BtnOpenCSV.Text = "Ouvrir CSV";
            this.BtnOpenCSV.UseVisualStyleBackColor = true;
            this.BtnOpenCSV.Click += new System.EventHandler(this.BtnOpenCSV_Click);
            // 
            // OvrirCSV
            // 
            this.OvrirCSV.FileName = "OfdCSV";
            // 
            // TxtBTes
            // 
            this.TxtBTes.Location = new System.Drawing.Point(274, 31);
            this.TxtBTes.Multiline = true;
            this.TxtBTes.Name = "TxtBTes";
            this.TxtBTes.Size = new System.Drawing.Size(376, 382);
            this.TxtBTes.TabIndex = 1;
            this.TxtBTes.TextChanged += new System.EventHandler(this.TxtBTes_TextChanged);
            // 
            // EleveActivites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBTes);
            this.Controls.Add(this.BtnOpenCSV);
            this.Name = "EleveActivites";
            this.Text = "Eleves/activites";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOpenCSV;
        private System.Windows.Forms.OpenFileDialog OvrirCSV;
        private System.Windows.Forms.TextBox TxtBTes;
    }
}

