namespace RappelWinForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.B_Click = new System.Windows.Forms.Button();
            this.LB_Infos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // B_Click
            // 
            this.B_Click.Location = new System.Drawing.Point(211, 194);
            this.B_Click.Name = "B_Click";
            this.B_Click.Size = new System.Drawing.Size(205, 63);
            this.B_Click.TabIndex = 0;
            this.B_Click.Text = "Click";
            this.B_Click.UseVisualStyleBackColor = true;
            this.B_Click.Click += new System.EventHandler(this.B_Click_Click);
            // 
            // LB_Infos
            // 
            this.LB_Infos.AutoSize = true;
            this.LB_Infos.Location = new System.Drawing.Point(327, 322);
            this.LB_Infos.Name = "LB_Infos";
            this.LB_Infos.Size = new System.Drawing.Size(35, 13);
            this.LB_Infos.TabIndex = 1;
            this.LB_Infos.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LB_Infos);
            this.Controls.Add(this.B_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_Click;
        private System.Windows.Forms.Label LB_Infos;
    }
}

