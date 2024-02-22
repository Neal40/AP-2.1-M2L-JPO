
namespace jpo
{
    partial class frmInscriptionMembres
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnInscriptionJPO = new System.Windows.Forms.Label();
            this.lblLigue = new System.Windows.Forms.Label();
            this.cbxLigue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxActAprem = new System.Windows.Forms.ComboBox();
            this.cbxActMatin = new System.Windows.Forms.ComboBox();
            this.lblMatin = new System.Windows.Forms.Label();
            this.lblActiviteAprem = new System.Windows.Forms.Label();
            this.lblMembresNonInscrits = new System.Windows.Forms.Label();
            this.lblMembresInscrits = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lbxMembresInscrits = new System.Windows.Forms.ListBox();
            this.lbxMembresNonInscrits = new System.Windows.Forms.ListBox();
            this.lbxListeMembres = new System.Windows.Forms.ListBox();
            this.lblActivités = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.BackColor = System.Drawing.Color.Transparent;
            this.lblTitre.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(46, 19);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(303, 29);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Inscription membres à la JPO";
            // 
            // btnInscriptionJPO
            // 
            this.btnInscriptionJPO.AutoSize = true;
            this.btnInscriptionJPO.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscriptionJPO.Location = new System.Drawing.Point(108, 58);
            this.btnInscriptionJPO.Name = "btnInscriptionJPO";
            this.btnInscriptionJPO.Size = new System.Drawing.Size(127, 23);
            this.btnInscriptionJPO.TabIndex = 8;
            this.btnInscriptionJPO.Text = "Inscription JPO";
            // 
            // lblLigue
            // 
            this.lblLigue.AutoSize = true;
            this.lblLigue.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblLigue.Location = new System.Drawing.Point(12, 97);
            this.lblLigue.Name = "lblLigue";
            this.lblLigue.Size = new System.Drawing.Size(44, 19);
            this.lblLigue.TabIndex = 9;
            this.lblLigue.Text = "Ligue";
            // 
            // cbxLigue
            // 
            this.cbxLigue.FormattingEnabled = true;
            this.cbxLigue.Location = new System.Drawing.Point(109, 96);
            this.cbxLigue.Name = "cbxLigue";
            this.cbxLigue.Size = new System.Drawing.Size(121, 21);
            this.cbxLigue.TabIndex = 4;
            this.cbxLigue.SelectedIndexChanged += new System.EventHandler(this.cbxLigue_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Créneau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(12, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Membres";
            // 
            // cbxActAprem
            // 
            this.cbxActAprem.FormattingEnabled = true;
            this.cbxActAprem.Location = new System.Drawing.Point(342, 297);
            this.cbxActAprem.Name = "cbxActAprem";
            this.cbxActAprem.Size = new System.Drawing.Size(121, 21);
            this.cbxActAprem.TabIndex = 16;
            // 
            // cbxActMatin
            // 
            this.cbxActMatin.FormattingEnabled = true;
            this.cbxActMatin.Location = new System.Drawing.Point(342, 264);
            this.cbxActMatin.Name = "cbxActMatin";
            this.cbxActMatin.Size = new System.Drawing.Size(121, 21);
            this.cbxActMatin.TabIndex = 17;
            // 
            // lblMatin
            // 
            this.lblMatin.AutoSize = true;
            this.lblMatin.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblMatin.Location = new System.Drawing.Point(257, 263);
            this.lblMatin.Name = "lblMatin";
            this.lblMatin.Size = new System.Drawing.Size(47, 19);
            this.lblMatin.TabIndex = 18;
            this.lblMatin.Text = "Matin";
            // 
            // lblActiviteAprem
            // 
            this.lblActiviteAprem.AutoSize = true;
            this.lblActiviteAprem.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblActiviteAprem.Location = new System.Drawing.Point(257, 297);
            this.lblActiviteAprem.Name = "lblActiviteAprem";
            this.lblActiviteAprem.Size = new System.Drawing.Size(79, 19);
            this.lblActiviteAprem.TabIndex = 19;
            this.lblActiviteAprem.Text = "Après-midi";
            // 
            // lblMembresNonInscrits
            // 
            this.lblMembresNonInscrits.AutoSize = true;
            this.lblMembresNonInscrits.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblMembresNonInscrits.Location = new System.Drawing.Point(637, 97);
            this.lblMembresNonInscrits.Name = "lblMembresNonInscrits";
            this.lblMembresNonInscrits.Size = new System.Drawing.Size(149, 19);
            this.lblMembresNonInscrits.TabIndex = 22;
            this.lblMembresNonInscrits.Text = "Membres non inscrits";
            // 
            // lblMembresInscrits
            // 
            this.lblMembresInscrits.AutoSize = true;
            this.lblMembresInscrits.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblMembresInscrits.Location = new System.Drawing.Point(501, 97);
            this.lblMembresInscrits.Name = "lblMembresInscrits";
            this.lblMembresInscrits.Size = new System.Drawing.Size(121, 19);
            this.lblMembresInscrits.TabIndex = 23;
            this.lblMembresInscrits.Text = "Membres inscrits";
            this.lblMembresInscrits.Click += new System.EventHandler(this.lblMembresInscrits_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(230, 401);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(106, 33);
            this.btnAjouter.TabIndex = 24;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(342, 401);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(106, 33);
            this.btnModifier.TabIndex = 25;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(454, 401);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(106, 33);
            this.btnSupprimer.TabIndex = 26;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // lbxMembresInscrits
            // 
            this.lbxMembresInscrits.FormattingEnabled = true;
            this.lbxMembresInscrits.Location = new System.Drawing.Point(501, 133);
            this.lbxMembresInscrits.Name = "lbxMembresInscrits";
            this.lbxMembresInscrits.Size = new System.Drawing.Size(121, 212);
            this.lbxMembresInscrits.TabIndex = 27;
            // 
            // lbxMembresNonInscrits
            // 
            this.lbxMembresNonInscrits.FormattingEnabled = true;
            this.lbxMembresNonInscrits.Location = new System.Drawing.Point(652, 133);
            this.lbxMembresNonInscrits.Name = "lbxMembresNonInscrits";
            this.lbxMembresNonInscrits.Size = new System.Drawing.Size(121, 212);
            this.lbxMembresNonInscrits.TabIndex = 28;
            // 
            // lbxListeMembres
            // 
            this.lbxListeMembres.FormattingEnabled = true;
            this.lbxListeMembres.Location = new System.Drawing.Point(109, 133);
            this.lbxListeMembres.Name = "lbxListeMembres";
            this.lbxListeMembres.Size = new System.Drawing.Size(121, 212);
            this.lbxListeMembres.TabIndex = 29;
            // 
            // lblActivités
            // 
            this.lblActivités.AutoSize = true;
            this.lblActivités.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivités.Location = new System.Drawing.Point(260, 227);
            this.lblActivités.Name = "lblActivités";
            this.lblActivités.Size = new System.Drawing.Size(76, 23);
            this.lblActivités.TabIndex = 30;
            this.lblActivités.Text = "Activités";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Matin",
            "Après-midi"});
            this.checkedListBox2.Location = new System.Drawing.Point(342, 163);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(121, 34);
            this.checkedListBox2.TabIndex = 14;
            // 
            // frmInscriptionMembres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblActivités);
            this.Controls.Add(this.lbxListeMembres);
            this.Controls.Add(this.lbxMembresNonInscrits);
            this.Controls.Add(this.lbxMembresInscrits);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblMembresInscrits);
            this.Controls.Add(this.lblMembresNonInscrits);
            this.Controls.Add(this.lblActiviteAprem);
            this.Controls.Add(this.lblMatin);
            this.Controls.Add(this.cbxActMatin);
            this.Controls.Add(this.cbxActAprem);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLigue);
            this.Controls.Add(this.btnInscriptionJPO);
            this.Controls.Add(this.cbxLigue);
            this.Controls.Add(this.lblTitre);
            this.Name = "frmInscriptionMembres";
            this.Text = "frmInscriptionMembres";
            this.Load += new System.EventHandler(this.frmInscriptionMembres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label btnInscriptionJPO;
        private System.Windows.Forms.Label lblLigue;
        private System.Windows.Forms.ComboBox cbxLigue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxActAprem;
        private System.Windows.Forms.ComboBox cbxActMatin;
        private System.Windows.Forms.Label lblMatin;
        private System.Windows.Forms.Label lblActiviteAprem;
        private System.Windows.Forms.Label lblMembresNonInscrits;
        private System.Windows.Forms.Label lblMembresInscrits;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ListBox lbxMembresInscrits;
        private System.Windows.Forms.ListBox lbxMembresNonInscrits;
        private System.Windows.Forms.ListBox lbxListeMembres;
        private System.Windows.Forms.Label lblActivités;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
    }
}