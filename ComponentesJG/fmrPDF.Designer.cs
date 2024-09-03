namespace ComponentesJG
{
    partial class fmrPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrPDF));
            this.axPDF = new AxAcroPDFLib.AxAcroPDF();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // axPDF
            // 
            this.axPDF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axPDF.Enabled = true;
            this.axPDF.Location = new System.Drawing.Point(0, 0);
            this.axPDF.Name = "axPDF";
            this.axPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPDF.OcxState")));
            this.axPDF.Size = new System.Drawing.Size(479, 265);
            this.axPDF.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Elige un archivo PDF";
            // 
            // fmrPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 265);
            this.Controls.Add(this.axPDF);
            this.Name = "fmrPDF";
            this.Text = "fmrPDF";
            this.Load += new System.EventHandler(this.fmrPDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axPDF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axPDF;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}