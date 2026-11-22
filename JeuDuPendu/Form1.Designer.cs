namespace JeuDuPendu
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
            this.ImgPendu = new System.Windows.Forms.PictureBox();
            this.TxtMot = new System.Windows.Forms.TextBox();
            this.lblLettreUtilise = new System.Windows.Forms.Label();
            this.cmbLettres = new System.Windows.Forms.ComboBox();
            this.btnTest1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPendu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgPendu
            // 
            this.ImgPendu.BackgroundImage = global::JeuDuPendu.Properties.Resources.pendu0;
            this.ImgPendu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImgPendu.Location = new System.Drawing.Point(12, 12);
            this.ImgPendu.Name = "ImgPendu";
            this.ImgPendu.Size = new System.Drawing.Size(336, 326);
            this.ImgPendu.TabIndex = 0;
            this.ImgPendu.TabStop = false;
            // 
            // TxtMot
            // 
            this.TxtMot.Location = new System.Drawing.Point(6, 19);
            this.TxtMot.Name = "TxtMot";
            this.TxtMot.Size = new System.Drawing.Size(288, 20);
            this.TxtMot.TabIndex = 1;
            this.TxtMot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMot_KeyPress);
            // 
            // lblLettreUtilise
            // 
            this.lblLettreUtilise.AutoSize = true;
            this.lblLettreUtilise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLettreUtilise.Location = new System.Drawing.Point(2, 12);
            this.lblLettreUtilise.Name = "lblLettreUtilise";
            this.lblLettreUtilise.Size = new System.Drawing.Size(292, 20);
            this.lblLettreUtilise.TabIndex = 2;
            this.lblLettreUtilise.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // cmbLettres
            // 
            this.cmbLettres.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLettres.FormattingEnabled = true;
            this.cmbLettres.Location = new System.Drawing.Point(6, 19);
            this.cmbLettres.Name = "cmbLettres";
            this.cmbLettres.Size = new System.Drawing.Size(121, 42);
            this.cmbLettres.TabIndex = 3;
            // 
            // btnTest1
            // 
            this.btnTest1.Font = new System.Drawing.Font("Liberation Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTest1.Location = new System.Drawing.Point(133, 19);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(161, 45);
            this.btnTest1.TabIndex = 4;
            this.btnTest1.Text = "Test";
            this.btnTest1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTest1.UseVisualStyleBackColor = true;
            this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReset.Font = new System.Drawing.Font("ISOCPEUR", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(364, 305);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(288, 33);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Recommencer";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtMot);
            this.groupBox1.Location = new System.Drawing.Point(358, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 50);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mot à chercher";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTest1);
            this.groupBox2.Controls.Add(this.cmbLettres);
            this.groupBox2.Location = new System.Drawing.Point(358, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 76);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lettre à utiliser";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblLettreUtilise);
            this.groupBox3.Location = new System.Drawing.Point(358, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 35);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lettres Utilisées";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(669, 346);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.ImgPendu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgPendu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgPendu;
        private System.Windows.Forms.TextBox TxtMot;
        private System.Windows.Forms.Label lblLettreUtilise;
        private System.Windows.Forms.ComboBox cmbLettres;
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

