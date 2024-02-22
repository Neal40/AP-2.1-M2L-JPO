
namespace jpo
{
    partial class frmEnregistrementMembres
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
            this.components = new System.ComponentModel.Container();
            this.lblTitreEnregistrementMembres = new System.Windows.Forms.Label();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.tbxTelephone = new System.Windows.Forms.TextBox();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblTéléphone = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblAjouterMembre = new System.Windows.Forms.Label();
            this.lblListeMembres = new System.Windows.Forms.Label();
            this.lbxListeMembres = new System.Windows.Forms.ListBox();
            this.cbxListeMembresLigue = new System.Windows.Forms.ComboBox();
            this.lblLigueListeMembres = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitreEnregistrementMembres
            // 
            this.lblTitreEnregistrementMembres.AutoSize = true;
            this.lblTitreEnregistrementMembres.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreEnregistrementMembres.Location = new System.Drawing.Point(46, 19);
            this.lblTitreEnregistrementMembres.Name = "lblTitreEnregistrementMembres";
            this.lblTitreEnregistrementMembres.Size = new System.Drawing.Size(269, 29);
            this.lblTitreEnregistrementMembres.TabIndex = 1;
            this.lblTitreEnregistrementMembres.Text = "Enregistrement membres";
            // 
            // tbxMail
            // 
            this.tbxMail.Location = new System.Drawing.Point(433, 292);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(174, 20);
            this.tbxMail.TabIndex = 5;
            this.tbxMail.Validating += new System.ComponentModel.CancelEventHandler(this.tbxMail_Validating);
            // 
            // tbxTelephone
            // 
            this.tbxTelephone.Location = new System.Drawing.Point(433, 245);
            this.tbxTelephone.Name = "tbxTelephone";
            this.tbxTelephone.Size = new System.Drawing.Size(174, 20);
            this.tbxTelephone.TabIndex = 4;
            this.tbxTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTelephone_KeyPress);
            this.tbxTelephone.Validating += new System.ComponentModel.CancelEventHandler(this.tbxTelephone_Validating);
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(433, 197);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(174, 20);
            this.tbxPrenom.TabIndex = 3;
            this.tbxPrenom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrenom_KeyPress_1);
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(433, 151);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(174, 20);
            this.tbxNom.TabIndex = 2;
            this.tbxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNom_KeyPress_1);
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblPrenom.Location = new System.Drawing.Point(347, 198);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(58, 19);
            this.lblPrenom.TabIndex = 6;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNom.Location = new System.Drawing.Point(347, 152);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(39, 19);
            this.lblNom.TabIndex = 7;
            this.lblNom.Text = "Nom";
            // 
            // lblTéléphone
            // 
            this.lblTéléphone.AutoSize = true;
            this.lblTéléphone.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblTéléphone.Location = new System.Drawing.Point(347, 246);
            this.lblTéléphone.Name = "lblTéléphone";
            this.lblTéléphone.Size = new System.Drawing.Size(76, 19);
            this.lblTéléphone.TabIndex = 8;
            this.lblTéléphone.Text = "Téléphone";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblMail.Location = new System.Drawing.Point(347, 293);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(38, 19);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Mail";
            // 
            // lblAjouterMembre
            // 
            this.lblAjouterMembre.AutoSize = true;
            this.lblAjouterMembre.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjouterMembre.Location = new System.Drawing.Point(450, 72);
            this.lblAjouterMembre.Name = "lblAjouterMembre";
            this.lblAjouterMembre.Size = new System.Drawing.Size(137, 23);
            this.lblAjouterMembre.TabIndex = 16;
            this.lblAjouterMembre.Text = "Ajouter membre";
            // 
            // lblListeMembres
            // 
            this.lblListeMembres.AutoSize = true;
            this.lblListeMembres.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeMembres.Location = new System.Drawing.Point(125, 72);
            this.lblListeMembres.Name = "lblListeMembres";
            this.lblListeMembres.Size = new System.Drawing.Size(122, 23);
            this.lblListeMembres.TabIndex = 18;
            this.lblListeMembres.Text = "Liste membres";
            // 
            // lbxListeMembres
            // 
            this.lbxListeMembres.FormattingEnabled = true;
            this.lbxListeMembres.Location = new System.Drawing.Point(126, 151);
            this.lbxListeMembres.Name = "lbxListeMembres";
            this.lbxListeMembres.Size = new System.Drawing.Size(121, 212);
            this.lbxListeMembres.TabIndex = 19;
            this.lbxListeMembres.SelectedValueChanged += new System.EventHandler(this.lbxListeMembres_SelectedValueChanged);
            // 
            // cbxListeMembresLigue
            // 
            this.cbxListeMembresLigue.FormattingEnabled = true;
            this.cbxListeMembresLigue.Location = new System.Drawing.Point(126, 114);
            this.cbxListeMembresLigue.Name = "cbxListeMembresLigue";
            this.cbxListeMembresLigue.Size = new System.Drawing.Size(121, 21);
            this.cbxListeMembresLigue.TabIndex = 1;
            this.cbxListeMembresLigue.SelectedIndexChanged += new System.EventHandler(this.cbxListeMembresLigue_SelectedIndexChanged);
            // 
            // lblLigueListeMembres
            // 
            this.lblLigueListeMembres.AutoSize = true;
            this.lblLigueListeMembres.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblLigueListeMembres.Location = new System.Drawing.Point(48, 116);
            this.lblLigueListeMembres.Name = "lblLigueListeMembres";
            this.lblLigueListeMembres.Size = new System.Drawing.Size(44, 19);
            this.lblLigueListeMembres.TabIndex = 21;
            this.lblLigueListeMembres.Text = "Ligue";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(454, 401);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(106, 33);
            this.btnSupprimer.TabIndex = 29;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 33);
            this.button2.TabIndex = 28;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(230, 401);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(106, 33);
            this.btnAjouter.TabIndex = 27;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmEnregistrementMembres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblLigueListeMembres);
            this.Controls.Add(this.cbxListeMembresLigue);
            this.Controls.Add(this.lbxListeMembres);
            this.Controls.Add(this.lblListeMembres);
            this.Controls.Add(this.lblAjouterMembre);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTéléphone);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.tbxTelephone);
            this.Controls.Add(this.tbxMail);
            this.Controls.Add(this.lblTitreEnregistrementMembres);
            this.Name = "frmEnregistrementMembres";
            this.Text = "Enregistrement membres";
            this.Load += new System.EventHandler(this.frmEnregistrementMembres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreEnregistrementMembres;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.TextBox tbxTelephone;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblTéléphone;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblAjouterMembre;
        private System.Windows.Forms.Label lblListeMembres;
        private System.Windows.Forms.ListBox lbxListeMembres;
        private System.Windows.Forms.ComboBox cbxListeMembresLigue;
        private System.Windows.Forms.Label lblLigueListeMembres;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}