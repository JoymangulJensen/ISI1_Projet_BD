namespace Commercial.Presentation
{
    partial class FajouteCdes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FajouteCdes));
            this.lbl_titre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_f_oui = new System.Windows.Forms.RadioButton();
            this.rb_f_non = new System.Windows.Forms.RadioButton();
            this.tb_nocmd = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.cb_novendeur = new System.Windows.Forms.ComboBox();
            this.cb_noclient = new System.Windows.Forms.ComboBox();
            this.details_vendeur = new System.Windows.Forms.Label();
            this.details_client = new System.Windows.Forms.Label();
            this.submit_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(12, 9);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(172, 22);
            this.lbl_titre.TabIndex = 2;
            this.lbl_titre.Text = "Nouvelle commande";
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
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "N° vendeur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "N° client :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Facture :";
            // 
            // rb_f_oui
            // 
            this.rb_f_oui.AutoSize = true;
            this.rb_f_oui.Location = new System.Drawing.Point(98, 187);
            this.rb_f_oui.Name = "rb_f_oui";
            this.rb_f_oui.Size = new System.Drawing.Size(41, 17);
            this.rb_f_oui.TabIndex = 5;
            this.rb_f_oui.TabStop = true;
            this.rb_f_oui.Text = "Oui";
            this.rb_f_oui.UseVisualStyleBackColor = true;
            this.rb_f_oui.CheckedChanged += new System.EventHandler(this.rb_f_oui_CheckedChanged);
            // 
            // rb_f_non
            // 
            this.rb_f_non.AutoSize = true;
            this.rb_f_non.Location = new System.Drawing.Point(146, 187);
            this.rb_f_non.Name = "rb_f_non";
            this.rb_f_non.Size = new System.Drawing.Size(45, 17);
            this.rb_f_non.TabIndex = 5;
            this.rb_f_non.TabStop = true;
            this.rb_f_non.Text = "Non";
            this.rb_f_non.UseVisualStyleBackColor = true;
            this.rb_f_non.CheckedChanged += new System.EventHandler(this.rb_f_non_CheckedChanged);
            // 
            // tb_nocmd
            // 
            this.tb_nocmd.Location = new System.Drawing.Point(98, 45);
            this.tb_nocmd.Name = "tb_nocmd";
            this.tb_nocmd.Size = new System.Drawing.Size(200, 20);
            this.tb_nocmd.TabIndex = 1;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(98, 143);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_date.TabIndex = 4;
            // 
            // cb_novendeur
            // 
            this.cb_novendeur.FormattingEnabled = true;
            this.cb_novendeur.Location = new System.Drawing.Point(98, 76);
            this.cb_novendeur.Name = "cb_novendeur";
            this.cb_novendeur.Size = new System.Drawing.Size(200, 21);
            this.cb_novendeur.TabIndex = 2;
            // 
            // cb_noclient
            // 
            this.cb_noclient.FormattingEnabled = true;
            this.cb_noclient.Location = new System.Drawing.Point(98, 111);
            this.cb_noclient.Name = "cb_noclient";
            this.cb_noclient.Size = new System.Drawing.Size(200, 21);
            this.cb_noclient.TabIndex = 3;
            // 
            // details_vendeur
            // 
            this.details_vendeur.AutoSize = true;
            this.details_vendeur.Location = new System.Drawing.Point(304, 79);
            this.details_vendeur.Name = "details_vendeur";
            this.details_vendeur.Size = new System.Drawing.Size(107, 13);
            this.details_vendeur.TabIndex = 16;
            this.details_vendeur.Text = "détails sur le vendeur";
            // 
            // details_client
            // 
            this.details_client.AutoSize = true;
            this.details_client.Location = new System.Drawing.Point(304, 114);
            this.details_client.Name = "details_client";
            this.details_client.Size = new System.Drawing.Size(93, 13);
            this.details_client.TabIndex = 17;
            this.details_client.Text = "détails sur le client";
            // 
            // submit_button
            // 
            this.submit_button.Location = new System.Drawing.Point(239, 226);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(172, 23);
            this.submit_button.TabIndex = 6;
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
            // FajouteCdes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 261);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.submit_button);
            this.Controls.Add(this.details_client);
            this.Controls.Add(this.details_vendeur);
            this.Controls.Add(this.cb_noclient);
            this.Controls.Add(this.cb_novendeur);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.tb_nocmd);
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
            this.Name = "FajouteCdes";
            this.Text = "Nouvelle commande";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox tb_nocmd;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.ComboBox cb_novendeur;
        private System.Windows.Forms.ComboBox cb_noclient;
        private System.Windows.Forms.Label details_vendeur;
        private System.Windows.Forms.Label details_client;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cancel;
    }
}