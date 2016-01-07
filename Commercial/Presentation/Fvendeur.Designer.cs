namespace Commercial
{
    partial class Fvendeur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fvendeur));
            this.btn_fermer = new System.Windows.Forms.Button();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_listeven = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_com = new System.Windows.Forms.Label();
            this.lbl_sal = new System.Windows.Forms.Label();
            this.lbl_ville = new System.Windows.Forms.Label();
            this.lbl_dtEmb = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.btn_details = new System.Windows.Forms.Button();
            this.lbl_noclient = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_sup = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(287, 226);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_fermer.TabIndex = 50;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = false;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(13, 13);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(232, 22);
            this.lbl_titre.TabIndex = 1;
            this.lbl_titre.Text = "Informations sur un vendeur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vendeur :";
            // 
            // cb_listeven
            // 
            this.cb_listeven.FormattingEnabled = true;
            this.cb_listeven.Location = new System.Drawing.Point(76, 55);
            this.cb_listeven.Name = "cb_listeven";
            this.cb_listeven.Size = new System.Drawing.Size(160, 21);
            this.cb_listeven.TabIndex = 1;
            this.cb_listeven.SelectedIndexChanged += new System.EventHandler(this.cb_listeven_SelectedIndexChanged);
            this.cb_listeven.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_listeven_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Embauche";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ville";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Salaire";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Comission";
            // 
            // lbl_com
            // 
            this.lbl_com.AutoSize = true;
            this.lbl_com.Location = new System.Drawing.Point(93, 208);
            this.lbl_com.Name = "lbl_com";
            this.lbl_com.Size = new System.Drawing.Size(35, 13);
            this.lbl_com.TabIndex = 10;
            this.lbl_com.Text = "label8";
            // 
            // lbl_sal
            // 
            this.lbl_sal.AutoSize = true;
            this.lbl_sal.Location = new System.Drawing.Point(93, 190);
            this.lbl_sal.Name = "lbl_sal";
            this.lbl_sal.Size = new System.Drawing.Size(35, 13);
            this.lbl_sal.TabIndex = 11;
            this.lbl_sal.Text = "label9";
            // 
            // lbl_ville
            // 
            this.lbl_ville.AutoSize = true;
            this.lbl_ville.Location = new System.Drawing.Point(93, 174);
            this.lbl_ville.Name = "lbl_ville";
            this.lbl_ville.Size = new System.Drawing.Size(41, 13);
            this.lbl_ville.TabIndex = 12;
            this.lbl_ville.Text = "label10";
            // 
            // lbl_dtEmb
            // 
            this.lbl_dtEmb.AutoSize = true;
            this.lbl_dtEmb.Location = new System.Drawing.Point(93, 157);
            this.lbl_dtEmb.Name = "lbl_dtEmb";
            this.lbl_dtEmb.Size = new System.Drawing.Size(41, 13);
            this.lbl_dtEmb.TabIndex = 13;
            this.lbl_dtEmb.Text = "label11";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(93, 140);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(41, 13);
            this.lbl_prenom.TabIndex = 14;
            this.lbl_prenom.Text = "label12";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(93, 123);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(41, 13);
            this.lbl_nom.TabIndex = 15;
            this.lbl_nom.Text = "label13";
            // 
            // btn_details
            // 
            this.btn_details.Location = new System.Drawing.Point(242, 53);
            this.btn_details.Name = "btn_details";
            this.btn_details.Size = new System.Drawing.Size(53, 23);
            this.btn_details.TabIndex = 2;
            this.btn_details.Text = "Détails";
            this.btn_details.UseVisualStyleBackColor = true;
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // lbl_noclient
            // 
            this.lbl_noclient.AutoSize = true;
            this.lbl_noclient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noclient.Location = new System.Drawing.Point(12, 96);
            this.lbl_noclient.Name = "lbl_noclient";
            this.lbl_noclient.Size = new System.Drawing.Size(205, 17);
            this.lbl_noclient.TabIndex = 16;
            this.lbl_noclient.Text = "Veuillez choisir un vendeur";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Supérieur";
            // 
            // lbl_sup
            // 
            this.lbl_sup.AutoSize = true;
            this.lbl_sup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_sup.Location = new System.Drawing.Point(93, 226);
            this.lbl_sup.Name = "lbl_sup";
            this.lbl_sup.Size = new System.Drawing.Size(35, 13);
            this.lbl_sup.TabIndex = 52;
            this.lbl_sup.Text = "label8";
            this.lbl_sup.Click += new System.EventHandler(this.lbl_sup_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Commercial.Properties.Resources.personnage2;
            this.pictureBox1.Location = new System.Drawing.Point(287, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 63);
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // Fvendeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 261);
            this.Controls.Add(this.lbl_sup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_noclient);
            this.Controls.Add(this.btn_details);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_dtEmb);
            this.Controls.Add(this.lbl_ville);
            this.Controls.Add(this.lbl_sal);
            this.Controls.Add(this.lbl_com);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_listeven);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 300);
            this.MinimumSize = new System.Drawing.Size(390, 300);
            this.Name = "Fvendeur";
            this.Text = "Informations vendeurs";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_listeven;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_com;
        private System.Windows.Forms.Label lbl_sal;
        private System.Windows.Forms.Label lbl_ville;
        private System.Windows.Forms.Label lbl_dtEmb;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Button btn_details;
        private System.Windows.Forms.Label lbl_noclient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_sup;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}