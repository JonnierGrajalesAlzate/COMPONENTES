namespace ComponentesJG
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
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnWMP = new System.Windows.Forms.Button();
            this.btnWeb = new System.Windows.Forms.Button();
            this.govComponentes = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.govComponentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(25, 33);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(108, 39);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnWMP
            // 
            this.btnWMP.Location = new System.Drawing.Point(193, 33);
            this.btnWMP.Name = "btnWMP";
            this.btnWMP.Size = new System.Drawing.Size(108, 39);
            this.btnWMP.TabIndex = 2;
            this.btnWMP.Text = "MEDIA PLAYER";
            this.btnWMP.UseVisualStyleBackColor = true;
            this.btnWMP.Click += new System.EventHandler(this.btnWMP_Click);
            // 
            // btnWeb
            // 
            this.btnWeb.Location = new System.Drawing.Point(340, 33);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(108, 39);
            this.btnWeb.TabIndex = 3;
            this.btnWeb.Text = "WEB";
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // govComponentes
            // 
            this.govComponentes.Controls.Add(this.lblMensaje);
            this.govComponentes.Controls.Add(this.label2);
            this.govComponentes.Controls.Add(this.btnPDF);
            this.govComponentes.Controls.Add(this.btnWeb);
            this.govComponentes.Controls.Add(this.btnWMP);
            this.govComponentes.Location = new System.Drawing.Point(12, 25);
            this.govComponentes.Name = "govComponentes";
            this.govComponentes.Size = new System.Drawing.Size(474, 100);
            this.govComponentes.TabIndex = 4;
            this.govComponentes.TabStop = false;
            this.govComponentes.Text = "Componentes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(32, 75);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(95, 13);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "Debes abrir tu pdf*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 154);
            this.Controls.Add(this.govComponentes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.govComponentes.ResumeLayout(false);
            this.govComponentes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnWMP;
        private System.Windows.Forms.Button btnWeb;
        private System.Windows.Forms.GroupBox govComponentes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMensaje;
    }
}

