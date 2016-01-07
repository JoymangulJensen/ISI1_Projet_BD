namespace Commercial.Presentation
{
    partial class FDetailsCde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDetailsCde));
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lvart = new System.Windows.Forms.ListView();
            this.lbl_total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(12, 9);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(201, 22);
            this.lbl_titre.TabIndex = 4;
            this.lbl_titre.Text = "Détails de la commande";
            // 
            // lvart
            // 
            this.lvart.Location = new System.Drawing.Point(12, 34);
            this.lvart.Name = "lvart";
            this.lvart.Size = new System.Drawing.Size(460, 195);
            this.lvart.TabIndex = 5;
            this.lvart.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(13, 239);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(44, 13);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "Total :";
            // 
            // FDetailsCde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lvart);
            this.Controls.Add(this.lbl_titre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 280);
            this.Name = "FDetailsCde";
            this.Text = "Détails commande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.ListView lvart;
        private System.Windows.Forms.Label lbl_total;
    }
}