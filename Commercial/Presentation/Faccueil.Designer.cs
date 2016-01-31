namespace Commercial
{
    partial class Faccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faccueil));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interrogerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ficheVendeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listeCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeArticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gérerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesCommandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.augmenterLesPrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_etat = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.interrogerToolStripMenuItem,
            this.gérerToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(108, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // interrogerToolStripMenuItem
            // 
            this.interrogerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheClientToolStripMenuItem,
            this.ficheVendeurToolStripMenuItem,
            this.toolStripSeparator2,
            this.listeCommandesToolStripMenuItem,
            this.listeArticlesToolStripMenuItem});
            this.interrogerToolStripMenuItem.Enabled = false;
            this.interrogerToolStripMenuItem.Name = "interrogerToolStripMenuItem";
            this.interrogerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.interrogerToolStripMenuItem.Text = "Interroger";
            // 
            // ficheClientToolStripMenuItem
            // 
            this.ficheClientToolStripMenuItem.Image = global::Commercial.Properties.Resources.personnage;
            this.ficheClientToolStripMenuItem.Name = "ficheClientToolStripMenuItem";
            this.ficheClientToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ficheClientToolStripMenuItem.Text = "Fiche client";
            this.ficheClientToolStripMenuItem.Click += new System.EventHandler(this.ficheClientToolStripMenuItem_Click);
            // 
            // ficheVendeurToolStripMenuItem
            // 
            this.ficheVendeurToolStripMenuItem.Image = global::Commercial.Properties.Resources.personnage2;
            this.ficheVendeurToolStripMenuItem.Name = "ficheVendeurToolStripMenuItem";
            this.ficheVendeurToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ficheVendeurToolStripMenuItem.Text = "Fiche vendeur";
            this.ficheVendeurToolStripMenuItem.Click += new System.EventHandler(this.ficheVendeurToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(164, 6);
            // 
            // listeCommandesToolStripMenuItem
            // 
            this.listeCommandesToolStripMenuItem.Image = global::Commercial.Properties.Resources.panier;
            this.listeCommandesToolStripMenuItem.Name = "listeCommandesToolStripMenuItem";
            this.listeCommandesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listeCommandesToolStripMenuItem.Text = "Liste commandes";
            this.listeCommandesToolStripMenuItem.Click += new System.EventHandler(this.listeCommandesToolStripMenuItem_Click);
            // 
            // listeArticlesToolStripMenuItem
            // 
            this.listeArticlesToolStripMenuItem.Image = global::Commercial.Properties.Resources.tableau;
            this.listeArticlesToolStripMenuItem.Name = "listeArticlesToolStripMenuItem";
            this.listeArticlesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listeArticlesToolStripMenuItem.Text = "Liste articles";
            this.listeArticlesToolStripMenuItem.Click += new System.EventHandler(this.listeArticlesToolStripMenuItem_Click);
            // 
            // gérerToolStripMenuItem
            // 
            this.gérerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesCommandesToolStripMenuItem,
            this.toolStripSeparator3,
            this.augmenterLesPrixToolStripMenuItem});
            this.gérerToolStripMenuItem.Enabled = false;
            this.gérerToolStripMenuItem.Name = "gérerToolStripMenuItem";
            this.gérerToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.gérerToolStripMenuItem.Text = "Gérer";
            // 
            // gestionDesCommandesToolStripMenuItem
            // 
            this.gestionDesCommandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.gestionDesCommandesToolStripMenuItem.Image = global::Commercial.Properties.Resources.panier;
            this.gestionDesCommandesToolStripMenuItem.Name = "gestionDesCommandesToolStripMenuItem";
            this.gestionDesCommandesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.gestionDesCommandesToolStripMenuItem.Text = "Gestion des commandes";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(223, 6);
            // 
            // augmenterLesPrixToolStripMenuItem
            // 
            this.augmenterLesPrixToolStripMenuItem.Image = global::Commercial.Properties.Resources.prix;
            this.augmenterLesPrixToolStripMenuItem.Name = "augmenterLesPrixToolStripMenuItem";
            this.augmenterLesPrixToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.augmenterLesPrixToolStripMenuItem.Text = "Augmenter/diminuer les prix";
            this.augmenterLesPrixToolStripMenuItem.Click += new System.EventHandler(this.augmenterLesPrixToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.àProposToolStripMenuItem.Text = "À propos";
            this.àProposToolStripMenuItem.Click += new System.EventHandler(this.àProposToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestion commerciale";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_etat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 198);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_etat
            // 
            this.lbl_etat.Name = "lbl_etat";
            this.lbl_etat.Size = new System.Drawing.Size(88, 17);
            this.lbl_etat.Text = "Etat : hors ligne";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 133);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Faccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 220);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 259);
            this.MinimumSize = new System.Drawing.Size(600, 259);
            this.Name = "Faccueil";
            this.Text = "Application commerciale";
            this.Load += new System.EventHandler(this.Faccueil_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interrogerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ficheVendeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem listeCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gérerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem augmenterLesPrixToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_etat;
        private System.Windows.Forms.ToolStripMenuItem listeArticlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesCommandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}

