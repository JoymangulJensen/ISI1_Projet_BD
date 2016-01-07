namespace Commercial.Presentation
{
    partial class FajouteArticle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FajouteArticle));
            this.lbl_titre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_f_oui = new System.Windows.Forms.RadioButton();
            this.rb_f_non = new System.Windows.Forms.RadioButton();
            this.submit_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_libelle = new System.Windows.Forms.TextBox();
            this.tb_quantite = new System.Windows.Forms.NumericUpDown();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_prix = new System.Windows.Forms.TextBox();
            this.tb_noart = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_quantite)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(12, 9);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(119, 22);
            this.lbl_titre.TabIndex = 2;
            this.lbl_titre.Text = "Nouvel article";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Libellé :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantité :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ville :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Interrompu :";
            // 
            // rb_f_oui
            // 
            this.rb_f_oui.AutoSize = true;
            this.rb_f_oui.Location = new System.Drawing.Point(98, 209);
            this.rb_f_oui.Name = "rb_f_oui";
            this.rb_f_oui.Size = new System.Drawing.Size(41, 17);
            this.rb_f_oui.TabIndex = 6;
            this.rb_f_oui.TabStop = true;
            this.rb_f_oui.Text = "Oui";
            this.rb_f_oui.UseVisualStyleBackColor = true;
            this.rb_f_oui.CheckedChanged += new System.EventHandler(this.rb_f_oui_CheckedChanged);
            // 
            // rb_f_non
            // 
            this.rb_f_non.AutoSize = true;
            this.rb_f_non.Location = new System.Drawing.Point(145, 209);
            this.rb_f_non.Name = "rb_f_non";
            this.rb_f_non.Size = new System.Drawing.Size(45, 17);
            this.rb_f_non.TabIndex = 6;
            this.rb_f_non.TabStop = true;
            this.rb_f_non.Text = "Non";
            this.rb_f_non.UseVisualStyleBackColor = true;
            this.rb_f_non.CheckedChanged += new System.EventHandler(this.rb_f_non_CheckedChanged);
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(239, 226);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(172, 23);
            this.submit_button.TabIndex = 7;
            this.submit_button.Text = "Enregistrer les données";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Commercial.Properties.Resources.panier;
            this.pictureBox1.Location = new System.Drawing.Point(456, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 50);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(418, 226);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 20;
            this.btn_cancel.Text = "Annuler";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_libelle
            // 
            this.tb_libelle.Location = new System.Drawing.Point(98, 76);
            this.tb_libelle.Name = "tb_libelle";
            this.tb_libelle.Size = new System.Drawing.Size(200, 20);
            this.tb_libelle.TabIndex = 2;
            this.tb_libelle.TextChanged += new System.EventHandler(this.tb_libelle_TextChanged);
            // 
            // tb_quantite
            // 
            this.tb_quantite.Location = new System.Drawing.Point(98, 112);
            this.tb_quantite.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tb_quantite.Name = "tb_quantite";
            this.tb_quantite.Size = new System.Drawing.Size(69, 20);
            this.tb_quantite.TabIndex = 3;
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(98, 146);
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(200, 20);
            this.tb_ville.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Prix :";
            // 
            // tb_prix
            // 
            this.tb_prix.Location = new System.Drawing.Point(98, 180);
            this.tb_prix.Name = "tb_prix";
            this.tb_prix.Size = new System.Drawing.Size(200, 20);
            this.tb_prix.TabIndex = 5;
            this.tb_prix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_prix_KeyPress);
            // 
            // tb_noart
            // 
            this.tb_noart.Location = new System.Drawing.Point(98, 45);
            this.tb_noart.Name = "tb_noart";
            this.tb_noart.Size = new System.Drawing.Size(200, 20);
            this.tb_noart.TabIndex = 1;
            this.tb_noart.TextChanged += new System.EventHandler(this.tb_noart_TextChanged);
            this.tb_noart.Leave += new System.EventHandler(this.tb_noart_verifier);
            // 
            // FajouteArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 261);
            this.Controls.Add(this.tb_noart);
            this.Controls.Add(this.tb_prix);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_ville);
            this.Controls.Add(this.tb_quantite);
            this.Controls.Add(this.tb_libelle);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.rb_f_non);
            this.Controls.Add(this.rb_f_oui);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_titre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(526, 300);
            this.MinimumSize = new System.Drawing.Size(526, 300);
            this.Name = "FajouteArticle";
            this.Text = "Nouvel article";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_quantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_f_oui;
        private System.Windows.Forms.RadioButton rb_f_non;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tb_libelle;
        private System.Windows.Forms.NumericUpDown tb_quantite;
        private System.Windows.Forms.TextBox tb_ville;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_prix;
        private System.Windows.Forms.TextBox tb_noart;
    }
}