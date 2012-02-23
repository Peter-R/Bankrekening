namespace Bankzaken
{
    partial class BankrekeningForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankrekeningForm));
            this.btNeemOpLinks = new System.Windows.Forms.Button();
            this.btStortLinks = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBedragLinks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSaldoLinks = new System.Windows.Forms.TextBox();
            this.txtRekeningnummerLinks = new System.Windows.Forms.TextBox();
            this.txtNaamLinks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBedragRechts = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btStortRechts = new System.Windows.Forms.Button();
            this.btNeemOpRechts = new System.Windows.Forms.Button();
            this.txtSaldoRechts = new System.Windows.Forms.TextBox();
            this.txtRekeningnummerRechts = new System.Windows.Forms.TextBox();
            this.txtNaamRechts = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btAfsluiten = new System.Windows.Forms.Button();
            this.btMaakOverNaarLinks = new System.Windows.Forms.Button();
            this.btMaakOverNaarRechts = new System.Windows.Forms.Button();
            this.txtBedragOverMaken = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btNeemOpLinks
            // 
            this.btNeemOpLinks.Location = new System.Drawing.Point(186, 53);
            this.btNeemOpLinks.Name = "btNeemOpLinks";
            this.btNeemOpLinks.Size = new System.Drawing.Size(75, 23);
            this.btNeemOpLinks.TabIndex = 0;
            this.btNeemOpLinks.Text = "Neem op";
            this.btNeemOpLinks.UseVisualStyleBackColor = true;
            this.btNeemOpLinks.Click += new System.EventHandler(this.btNeemOpLinks_Click);
            // 
            // btStortLinks
            // 
            this.btStortLinks.Location = new System.Drawing.Point(186, 26);
            this.btStortLinks.Name = "btStortLinks";
            this.btStortLinks.Size = new System.Drawing.Size(75, 23);
            this.btStortLinks.TabIndex = 1;
            this.btStortLinks.Text = "Stort";
            this.btStortLinks.UseVisualStyleBackColor = true;
            this.btStortLinks.Click += new System.EventHandler(this.btStortLinks_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtSaldoLinks);
            this.groupBox1.Controls.Add(this.txtRekeningnummerLinks);
            this.groupBox1.Controls.Add(this.txtNaamLinks);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 218);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BankrekeningLinks";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBedragLinks);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btNeemOpLinks);
            this.groupBox3.Controls.Add(this.btStortLinks);
            this.groupBox3.Location = new System.Drawing.Point(9, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 82);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // txtBedragLinks
            // 
            this.txtBedragLinks.Location = new System.Drawing.Point(65, 28);
            this.txtBedragLinks.Name = "txtBedragLinks";
            this.txtBedragLinks.Size = new System.Drawing.Size(100, 20);
            this.txtBedragLinks.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Bedrag:";
            // 
            // txtSaldoLinks
            // 
            this.txtSaldoLinks.Location = new System.Drawing.Point(136, 89);
            this.txtSaldoLinks.Name = "txtSaldoLinks";
            this.txtSaldoLinks.ReadOnly = true;
            this.txtSaldoLinks.Size = new System.Drawing.Size(140, 20);
            this.txtSaldoLinks.TabIndex = 5;
            // 
            // txtRekeningnummerLinks
            // 
            this.txtRekeningnummerLinks.Location = new System.Drawing.Point(136, 58);
            this.txtRekeningnummerLinks.Name = "txtRekeningnummerLinks";
            this.txtRekeningnummerLinks.ReadOnly = true;
            this.txtRekeningnummerLinks.Size = new System.Drawing.Size(140, 20);
            this.txtRekeningnummerLinks.TabIndex = 4;
            // 
            // txtNaamLinks
            // 
            this.txtNaamLinks.Location = new System.Drawing.Point(136, 26);
            this.txtNaamLinks.Name = "txtNaamLinks";
            this.txtNaamLinks.ReadOnly = true;
            this.txtNaamLinks.Size = new System.Drawing.Size(140, 20);
            this.txtNaamLinks.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naam:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rekeningnummer:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.txtSaldoRechts);
            this.groupBox2.Controls.Add(this.txtRekeningnummerRechts);
            this.groupBox2.Controls.Add(this.txtNaamRechts);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(458, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 218);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BankrekeningRechts";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBedragRechts);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btStortRechts);
            this.groupBox4.Controls.Add(this.btNeemOpRechts);
            this.groupBox4.Location = new System.Drawing.Point(9, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(267, 82);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // txtBedragRechts
            // 
            this.txtBedragRechts.Location = new System.Drawing.Point(65, 28);
            this.txtBedragRechts.Name = "txtBedragRechts";
            this.txtBedragRechts.Size = new System.Drawing.Size(100, 20);
            this.txtBedragRechts.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Bedrag:";
            // 
            // btStortRechts
            // 
            this.btStortRechts.Location = new System.Drawing.Point(186, 26);
            this.btStortRechts.Name = "btStortRechts";
            this.btStortRechts.Size = new System.Drawing.Size(75, 23);
            this.btStortRechts.TabIndex = 1;
            this.btStortRechts.Text = "Stort";
            this.btStortRechts.UseVisualStyleBackColor = true;
            this.btStortRechts.Click += new System.EventHandler(this.btStortRechts_Click);
            // 
            // btNeemOpRechts
            // 
            this.btNeemOpRechts.Location = new System.Drawing.Point(186, 53);
            this.btNeemOpRechts.Name = "btNeemOpRechts";
            this.btNeemOpRechts.Size = new System.Drawing.Size(75, 23);
            this.btNeemOpRechts.TabIndex = 0;
            this.btNeemOpRechts.Text = "Neem op";
            this.btNeemOpRechts.UseVisualStyleBackColor = true;
            this.btNeemOpRechts.Click += new System.EventHandler(this.btNeemOpRechts_Click);
            // 
            // txtSaldoRechts
            // 
            this.txtSaldoRechts.Location = new System.Drawing.Point(136, 89);
            this.txtSaldoRechts.Name = "txtSaldoRechts";
            this.txtSaldoRechts.ReadOnly = true;
            this.txtSaldoRechts.Size = new System.Drawing.Size(140, 20);
            this.txtSaldoRechts.TabIndex = 5;
            // 
            // txtRekeningnummerRechts
            // 
            this.txtRekeningnummerRechts.Location = new System.Drawing.Point(136, 58);
            this.txtRekeningnummerRechts.Name = "txtRekeningnummerRechts";
            this.txtRekeningnummerRechts.ReadOnly = true;
            this.txtRekeningnummerRechts.Size = new System.Drawing.Size(140, 20);
            this.txtRekeningnummerRechts.TabIndex = 4;
            // 
            // txtNaamRechts
            // 
            this.txtNaamRechts.Location = new System.Drawing.Point(136, 26);
            this.txtNaamRechts.Name = "txtNaamRechts";
            this.txtNaamRechts.ReadOnly = true;
            this.txtNaamRechts.Size = new System.Drawing.Size(140, 20);
            this.txtNaamRechts.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Naam:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Rekeningnummer:";
            // 
            // btAfsluiten
            // 
            this.btAfsluiten.Location = new System.Drawing.Point(659, 236);
            this.btAfsluiten.Name = "btAfsluiten";
            this.btAfsluiten.Size = new System.Drawing.Size(75, 23);
            this.btAfsluiten.TabIndex = 4;
            this.btAfsluiten.Text = "Afsluiten";
            this.btAfsluiten.UseVisualStyleBackColor = true;
            this.btAfsluiten.Click += new System.EventHandler(this.btAfsluiten_Click);
            // 
            // btMaakOverNaarLinks
            // 
            this.btMaakOverNaarLinks.Location = new System.Drawing.Point(313, 99);
            this.btMaakOverNaarLinks.Name = "btMaakOverNaarLinks";
            this.btMaakOverNaarLinks.Size = new System.Drawing.Size(27, 23);
            this.btMaakOverNaarLinks.TabIndex = 5;
            this.btMaakOverNaarLinks.Text = "<<";
            this.btMaakOverNaarLinks.UseVisualStyleBackColor = true;
            this.btMaakOverNaarLinks.Click += new System.EventHandler(this.btMaakOverNaarLinks_Click);
            // 
            // btMaakOverNaarRechts
            // 
            this.btMaakOverNaarRechts.Location = new System.Drawing.Point(425, 99);
            this.btMaakOverNaarRechts.Name = "btMaakOverNaarRechts";
            this.btMaakOverNaarRechts.Size = new System.Drawing.Size(27, 23);
            this.btMaakOverNaarRechts.TabIndex = 6;
            this.btMaakOverNaarRechts.Text = ">>";
            this.btMaakOverNaarRechts.UseVisualStyleBackColor = true;
            this.btMaakOverNaarRechts.Click += new System.EventHandler(this.btMaakOverNaarRechts_Click);
            // 
            // txtBedragOverMaken
            // 
            this.txtBedragOverMaken.Location = new System.Drawing.Point(346, 101);
            this.txtBedragOverMaken.Name = "txtBedragOverMaken";
            this.txtBedragOverMaken.Size = new System.Drawing.Size(73, 20);
            this.txtBedragOverMaken.TabIndex = 7;
            // 
            // BankrekeningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 264);
            this.Controls.Add(this.txtBedragOverMaken);
            this.Controls.Add(this.btMaakOverNaarRechts);
            this.Controls.Add(this.btMaakOverNaarLinks);
            this.Controls.Add(this.btAfsluiten);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BankrekeningForm";
            this.Text = "Bankzaken";
            this.Load += new System.EventHandler(this.BankrekeningForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNeemOpLinks;
        private System.Windows.Forms.Button btStortLinks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSaldoLinks;
        private System.Windows.Forms.TextBox txtRekeningnummerLinks;
        private System.Windows.Forms.TextBox txtNaamLinks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSaldoRechts;
        private System.Windows.Forms.TextBox txtRekeningnummerRechts;
        private System.Windows.Forms.TextBox txtNaamRechts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btStortRechts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btNeemOpRechts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAfsluiten;
        private System.Windows.Forms.Button btMaakOverNaarLinks;
        private System.Windows.Forms.Button btMaakOverNaarRechts;
        private System.Windows.Forms.TextBox txtBedragOverMaken;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBedragLinks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBedragRechts;
        private System.Windows.Forms.Label label8;
    }
}

