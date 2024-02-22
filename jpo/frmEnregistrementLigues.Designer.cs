
namespace jpo
{
    partial class frmEnregistrementLigues
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
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblLiguesEnregistrées = new System.Windows.Forms.Label();
            this.listBoxLiguesEnregistrées = new System.Windows.Forms.ListBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.tbxDiscipline = new System.Windows.Forms.TextBox();
            this.tbxVille = new System.Windows.Forms.TextBox();
            this.tbxCodePostal = new System.Windows.Forms.TextBox();
            this.tbxAdresse = new System.Windows.Forms.TextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.lblCodePostal = new System.Windows.Forms.Label();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblEnregistrementLigues = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(374, 400);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(106, 33);
            this.btnModifier.TabIndex = 46;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(268, 400);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(106, 33);
            this.btnAjouter.TabIndex = 45;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(480, 400);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(106, 33);
            this.btnSupprimer.TabIndex = 44;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lblLiguesEnregistrées
            // 
            this.lblLiguesEnregistrées.AutoSize = true;
            this.lblLiguesEnregistrées.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiguesEnregistrées.Location = new System.Drawing.Point(145, 86);
            this.lblLiguesEnregistrées.Name = "lblLiguesEnregistrées";
            this.lblLiguesEnregistrées.Size = new System.Drawing.Size(157, 23);
            this.lblLiguesEnregistrées.TabIndex = 41;
            this.lblLiguesEnregistrées.Text = "Ligues enregistrées";
            // 
            // listBoxLiguesEnregistrées
            // 
            this.listBoxLiguesEnregistrées.FormattingEnabled = true;
            this.listBoxLiguesEnregistrées.Location = new System.Drawing.Point(149, 135);
            this.listBoxLiguesEnregistrées.Name = "listBoxLiguesEnregistrées";
            this.listBoxLiguesEnregistrées.Size = new System.Drawing.Size(138, 212);
            this.listBoxLiguesEnregistrées.TabIndex = 40;
            this.listBoxLiguesEnregistrées.SelectedIndexChanged += new System.EventHandler(this.listBoxLiguesEnregistrées_SelectedIndexChanged);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(411, 86);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(199, 23);
            this.lblInformation.TabIndex = 39;
            this.lblInformation.Text = "Informations d\'une ligue";
            // 
            // tbxDiscipline
            // 
            this.tbxDiscipline.Location = new System.Drawing.Point(466, 299);
            this.tbxDiscipline.Name = "tbxDiscipline";
            this.tbxDiscipline.Size = new System.Drawing.Size(115, 20);
            this.tbxDiscipline.TabIndex = 38;
            this.tbxDiscipline.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDiscipline_KeyPress);
            // 
            // tbxVille
            // 
            this.tbxVille.Location = new System.Drawing.Point(466, 257);
            this.tbxVille.Name = "tbxVille";
            this.tbxVille.Size = new System.Drawing.Size(115, 20);
            this.tbxVille.TabIndex = 37;
            this.tbxVille.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxVille_KeyPress);
            // 
            // tbxCodePostal
            // 
            this.tbxCodePostal.Location = new System.Drawing.Point(466, 213);
            this.tbxCodePostal.Name = "tbxCodePostal";
            this.tbxCodePostal.Size = new System.Drawing.Size(115, 20);
            this.tbxCodePostal.TabIndex = 36;
            this.tbxCodePostal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCodePostal_KeyPress);
            // 
            // tbxAdresse
            // 
            this.tbxAdresse.Location = new System.Drawing.Point(466, 173);
            this.tbxAdresse.Name = "tbxAdresse";
            this.tbxAdresse.Size = new System.Drawing.Size(115, 20);
            this.tbxAdresse.TabIndex = 35;
            this.tbxAdresse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAdresse_KeyPress);
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(466, 132);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(115, 20);
            this.tbxNom.TabIndex = 34;
            this.tbxNom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNom_KeyPress);
            // 
            // lblCodePostal
            // 
            this.lblCodePostal.AutoSize = true;
            this.lblCodePostal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodePostal.Location = new System.Drawing.Point(378, 216);
            this.lblCodePostal.Name = "lblCodePostal";
            this.lblCodePostal.Size = new System.Drawing.Size(86, 19);
            this.lblCodePostal.TabIndex = 33;
            this.lblCodePostal.Text = "Code Postal";
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscipline.Location = new System.Drawing.Point(378, 302);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(73, 19);
            this.lblDiscipline.TabIndex = 32;
            this.lblDiscipline.Text = "Discipline";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdresse.Location = new System.Drawing.Point(378, 173);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(61, 19);
            this.lblAdresse.TabIndex = 31;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(378, 135);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(39, 19);
            this.lblNom.TabIndex = 30;
            this.lblNom.Text = "Nom";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.Location = new System.Drawing.Point(378, 257);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(38, 19);
            this.lblVille.TabIndex = 29;
            this.lblVille.Text = "Ville";
            // 
            // lblEnregistrementLigues
            // 
            this.lblEnregistrementLigues.AutoSize = true;
            this.lblEnregistrementLigues.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnregistrementLigues.Location = new System.Drawing.Point(46, 19);
            this.lblEnregistrementLigues.Name = "lblEnregistrementLigues";
            this.lblEnregistrementLigues.Size = new System.Drawing.Size(271, 29);
            this.lblEnregistrementLigues.TabIndex = 28;
            this.lblEnregistrementLigues.Text = "Enregistrement des ligues";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(161, 400);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(106, 33);
            this.btnEnregistrer.TabIndex = 47;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // frmEnregistrementLigues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.lblLiguesEnregistrées);
            this.Controls.Add(this.listBoxLiguesEnregistrées);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.tbxDiscipline);
            this.Controls.Add(this.tbxVille);
            this.Controls.Add(this.tbxCodePostal);
            this.Controls.Add(this.tbxAdresse);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.lblCodePostal);
            this.Controls.Add(this.lblDiscipline);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblEnregistrementLigues);
            this.Name = "frmEnregistrementLigues";
            this.Text = "Enregistrement ligues";
            this.Load += new System.EventHandler(this.frmEnregistrementLigues_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblLiguesEnregistrées;
        private System.Windows.Forms.ListBox listBoxLiguesEnregistrées;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.TextBox tbxDiscipline;
        private System.Windows.Forms.TextBox tbxVille;
        private System.Windows.Forms.TextBox tbxCodePostal;
        private System.Windows.Forms.TextBox tbxAdresse;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label lblCodePostal;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblEnregistrementLigues;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}