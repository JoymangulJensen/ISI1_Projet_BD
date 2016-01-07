namespace Commercial.Presentation
{
    partial class FListeArticles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FListeArticles));
            this.lvart = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.champToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tri_no = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tri_libelle = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tri_quantite = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tri_ville = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tri_prix = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tri_interrompu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.croissantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.décroissantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_articleselectionne = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvart
            // 
            this.lvart.Location = new System.Drawing.Point(13, 46);
            this.lvart.Name = "lvart";
            this.lvart.Size = new System.Drawing.Size(530, 250);
            this.lvart.TabIndex = 4;
            this.lvart.UseCompatibleStateImageBehavior = false;
            this.lvart.SelectedIndexChanged += new System.EventHandler(this.lvart_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.menu_articleselectionne,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.fermerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 20);
            this.toolStripMenuItem2.Text = "Augmenter/diminuer les prix";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.champToolStripMenuItem,
            this.toolStripSeparator1,
            this.croissantToolStripMenuItem,
            this.décroissantToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(33, 20);
            this.toolStripMenuItem1.Text = "Tri";
            // 
            // champToolStripMenuItem
            // 
            this.champToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_tri_no,
            this.menu_tri_libelle,
            this.menu_tri_quantite,
            this.menu_tri_ville,
            this.menu_tri_prix,
            this.menu_tri_interrompu});
            this.champToolStripMenuItem.Name = "champToolStripMenuItem";
            this.champToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.champToolStripMenuItem.Text = "Champ";
            // 
            // menu_tri_no
            // 
            this.menu_tri_no.Name = "menu_tri_no";
            this.menu_tri_no.Size = new System.Drawing.Size(153, 22);
            this.menu_tri_no.Text = "Numéro article";
            this.menu_tri_no.Click += new System.EventHandler(this.menu_tri_no_Click);
            // 
            // menu_tri_libelle
            // 
            this.menu_tri_libelle.Name = "menu_tri_libelle";
            this.menu_tri_libelle.Size = new System.Drawing.Size(153, 22);
            this.menu_tri_libelle.Text = "Libellé";
            this.menu_tri_libelle.Click += new System.EventHandler(this.menu_tri_libelle_Click);
            // 
            // menu_tri_quantite
            // 
            this.menu_tri_quantite.Name = "menu_tri_quantite";
            this.menu_tri_quantite.Size = new System.Drawing.Size(153, 22);
            this.menu_tri_quantite.Text = "Quantité";
            this.menu_tri_quantite.Click += new System.EventHandler(this.menu_tri_quantite_Click);
            // 
            // menu_tri_ville
            // 
            this.menu_tri_ville.Name = "menu_tri_ville";
            this.menu_tri_ville.Size = new System.Drawing.Size(153, 22);
            this.menu_tri_ville.Text = "Ville";
            this.menu_tri_ville.Click += new System.EventHandler(this.menu_tri_ville_Click);
            // 
            // menu_tri_prix
            // 
            this.menu_tri_prix.Name = "menu_tri_prix";
            this.menu_tri_prix.Size = new System.Drawing.Size(153, 22);
            this.menu_tri_prix.Text = "Prix";
            this.menu_tri_prix.Click += new System.EventHandler(this.menu_tri_prix_Click);
            // 
            // menu_tri_interrompu
            // 
            this.menu_tri_interrompu.Name = "menu_tri_interrompu";
            this.menu_tri_interrompu.Size = new System.Drawing.Size(153, 22);
            this.menu_tri_interrompu.Text = "Interrompu";
            this.menu_tri_interrompu.Click += new System.EventHandler(this.menu_tri_interrompu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // croissantToolStripMenuItem
            // 
            this.croissantToolStripMenuItem.Name = "croissantToolStripMenuItem";
            this.croissantToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.croissantToolStripMenuItem.Text = "Croissant";
            this.croissantToolStripMenuItem.Click += new System.EventHandler(this.croissantToolStripMenuItem_Click);
            // 
            // décroissantToolStripMenuItem
            // 
            this.décroissantToolStripMenuItem.Name = "décroissantToolStripMenuItem";
            this.décroissantToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.décroissantToolStripMenuItem.Text = "Décroissant";
            this.décroissantToolStripMenuItem.Click += new System.EventHandler(this.décroissantToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(92, 20);
            this.toolStripMenuItem3.Text = "Nouvel article";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // menu_articleselectionne
            // 
            this.menu_articleselectionne.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem});
            this.menu_articleselectionne.Name = "menu_articleselectionne";
            this.menu_articleselectionne.Size = new System.Drawing.Size(116, 20);
            this.menu_articleselectionne.Text = "Article sélectionné";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // FListeArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 311);
            this.Controls.Add(this.lvart);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(570, 350);
            this.Name = "FListeArticles";
            this.Text = "Liste des articles";
            this.Resize += new System.EventHandler(this.FListeArticles_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem champToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_tri_no;
        private System.Windows.Forms.ToolStripMenuItem menu_tri_libelle;
        private System.Windows.Forms.ToolStripMenuItem menu_tri_quantite;
        private System.Windows.Forms.ToolStripMenuItem menu_tri_ville;
        private System.Windows.Forms.ToolStripMenuItem menu_tri_prix;
        private System.Windows.Forms.ToolStripMenuItem menu_tri_interrompu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem croissantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem décroissantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menu_articleselectionne;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
    }
}