namespace TelaPrincipal
{
    partial class Form1
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbCaminho = new System.Windows.Forms.TextBox();
            this.tbSaida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(407, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.acaoBotaoBuscar);
            // 
            // tbCaminho
            // 
            this.tbCaminho.Location = new System.Drawing.Point(12, 24);
            this.tbCaminho.Name = "tbCaminho";
            this.tbCaminho.Size = new System.Drawing.Size(389, 20);
            this.tbCaminho.TabIndex = 1;
            // 
            // tbSaida
            // 
            this.tbSaida.Location = new System.Drawing.Point(12, 66);
            this.tbSaida.Multiline = true;
            this.tbSaida.Name = "tbSaida";
            this.tbSaida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSaida.Size = new System.Drawing.Size(470, 286);
            this.tbSaida.TabIndex = 2;
            this.tbSaida.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 364);
            this.Controls.Add(this.tbSaida);
            this.Controls.Add(this.tbCaminho);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbCaminho;
        private System.Windows.Forms.TextBox tbSaida;
    }
}

