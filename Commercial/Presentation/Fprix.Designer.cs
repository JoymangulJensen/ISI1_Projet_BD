namespace Commercial.Presentation
{
    partial class Prix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prix));
            this.lbl_titre = new System.Windows.Forms.Label();
            this.rb_augmenter = new System.Windows.Forms.RadioButton();
            this.rb_diminuer = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.tb_pourcentageAuto = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tb_pourcentageAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(12, 9);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(135, 22);
            this.lbl_titre.TabIndex = 2;
            this.lbl_titre.Text = "Modifier les prix";
            // 
            // rb_augmenter
            // 
            this.rb_augmenter.AutoSize = true;
            this.rb_augmenter.Location = new System.Drawing.Point(29, 54);
            this.rb_augmenter.Name = "rb_augmenter";
            this.rb_augmenter.Size = new System.Drawing.Size(76, 17);
            this.rb_augmenter.TabIndex = 3;
            this.rb_augmenter.TabStop = true;
            this.rb_augmenter.Text = "Augmenter";
            this.rb_augmenter.UseVisualStyleBackColor = true;
            this.rb_augmenter.Click += new System.EventHandler(this.rb_augmenter_Click);
            // 
            // rb_diminuer
            // 
            this.rb_diminuer.AutoSize = true;
            this.rb_diminuer.Location = new System.Drawing.Point(111, 54);
            this.rb_diminuer.Name = "rb_diminuer";
            this.rb_diminuer.Size = new System.Drawing.Size(66, 17);
            this.rb_diminuer.TabIndex = 4;
            this.rb_diminuer.TabStop = true;
            this.rb_diminuer.Text = "Diminuer";
            this.rb_diminuer.UseVisualStyleBackColor = true;
            this.rb_diminuer.Click += new System.EventHandler(this.rb_diminuer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "de";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "%";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(96, 133);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(67, 23);
            this.btn_valider.TabIndex = 8;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(169, 133);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(63, 23);
            this.btn_annuler.TabIndex = 9;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_pourcentageAuto
            // 
            this.tb_pourcentageAuto.Location = new System.Drawing.Point(52, 87);
            this.tb_pourcentageAuto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tb_pourcentageAuto.Name = "tb_pourcentageAuto";
            this.tb_pourcentageAuto.Size = new System.Drawing.Size(53, 20);
            this.tb_pourcentageAuto.TabIndex = 10;
            this.tb_pourcentageAuto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Prix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 168);
            this.Controls.Add(this.tb_pourcentageAuto);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_diminuer);
            this.Controls.Add(this.rb_augmenter);
            this.Controls.Add(this.lbl_titre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(260, 207);
            this.MinimumSize = new System.Drawing.Size(260, 207);
            this.Name = "Prix";
            this.Text = "Prix";
            this.Load += new System.EventHandler(this.Fprix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_pourcentageAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.RadioButton rb_augmenter;
        private System.Windows.Forms.RadioButton rb_diminuer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.NumericUpDown tb_pourcentageAuto;
    }
}