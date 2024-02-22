
namespace jpo
{
    partial class frmInscriptionLigues
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
            this.btnModifierStand = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnDésincrire = new System.Windows.Forms.Button();
            this.numericUpDownLargeur = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLongueur = new System.Windows.Forms.NumericUpDown();
            this.lblLiguesNonInscrites = new System.Windows.Forms.Label();
            this.listBoxLiguesNonInscrites = new System.Windows.Forms.ListBox();
            this.lblLiguesInscrites = new System.Windows.Forms.Label();
            this.listBoxLiguesInscrites = new System.Windows.Forms.ListBox();
            this.listBoxEquipement = new System.Windows.Forms.ListBox();
            this.lblListedesequipements = new System.Windows.Forms.Label();
            this.lblStandtaille = new System.Windows.Forms.Label();
            this.lblLargeur = new System.Windows.Forms.Label();
            this.lblLongueur = new System.Windows.Forms.Label();
            this.lblInscriptionLigues = new System.Windows.Forms.Label();
            this.btnInscrire = new System.Windows.Forms.Button();
            this.checkBoxEquipement = new System.Windows.Forms.CheckBox();
            this.btnModifierEquipement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLargeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongueur)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifierStand
            // 
            this.btnModifierStand.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierStand.Location = new System.Drawing.Point(337, 382);
            this.btnModifierStand.Name = "btnModifierStand";
            this.btnModifierStand.Size = new System.Drawing.Size(106, 49);
            this.btnModifierStand.TabIndex = 45;
            this.btnModifierStand.Text = "Modifier stand";
            this.btnModifierStand.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(206, 382);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(106, 49);
            this.btnAjouter.TabIndex = 44;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnDésincrire
            // 
            this.btnDésincrire.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDésincrire.Location = new System.Drawing.Point(624, 382);
            this.btnDésincrire.Name = "btnDésincrire";
            this.btnDésincrire.Size = new System.Drawing.Size(106, 49);
            this.btnDésincrire.TabIndex = 43;
            this.btnDésincrire.Text = "Désincrire";
            this.btnDésincrire.UseVisualStyleBackColor = true;
            this.btnDésincrire.Click += new System.EventHandler(this.btnDésincrire_Click);
            // 
            // numericUpDownLargeur
            // 
            this.numericUpDownLargeur.Location = new System.Drawing.Point(308, 253);
            this.numericUpDownLargeur.Name = "numericUpDownLargeur";
            this.numericUpDownLargeur.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownLargeur.TabIndex = 42;
            // 
            // numericUpDownLongueur
            // 
            this.numericUpDownLongueur.Location = new System.Drawing.Point(308, 194);
            this.numericUpDownLongueur.Name = "numericUpDownLongueur";
            this.numericUpDownLongueur.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownLongueur.TabIndex = 41;
            // 
            // lblLiguesNonInscrites
            // 
            this.lblLiguesNonInscrites.AutoSize = true;
            this.lblLiguesNonInscrites.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiguesNonInscrites.Location = new System.Drawing.Point(47, 78);
            this.lblLiguesNonInscrites.Name = "lblLiguesNonInscrites";
            this.lblLiguesNonInscrites.Size = new System.Drawing.Size(160, 23);
            this.lblLiguesNonInscrites.TabIndex = 40;
            this.lblLiguesNonInscrites.Text = "Ligues non inscrites";
            // 
            // listBoxLiguesNonInscrites
            // 
            this.listBoxLiguesNonInscrites.FormattingEnabled = true;
            this.listBoxLiguesNonInscrites.Location = new System.Drawing.Point(51, 139);
            this.listBoxLiguesNonInscrites.Name = "listBoxLiguesNonInscrites";
            this.listBoxLiguesNonInscrites.Size = new System.Drawing.Size(138, 212);
            this.listBoxLiguesNonInscrites.TabIndex = 39;
            // 
            // lblLiguesInscrites
            // 
            this.lblLiguesInscrites.AutoSize = true;
            this.lblLiguesInscrites.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiguesInscrites.Location = new System.Drawing.Point(636, 78);
            this.lblLiguesInscrites.Name = "lblLiguesInscrites";
            this.lblLiguesInscrites.Size = new System.Drawing.Size(126, 23);
            this.lblLiguesInscrites.TabIndex = 38;
            this.lblLiguesInscrites.Text = "Ligues inscrites";
            // 
            // listBoxLiguesInscrites
            // 
            this.listBoxLiguesInscrites.FormattingEnabled = true;
            this.listBoxLiguesInscrites.Location = new System.Drawing.Point(624, 139);
            this.listBoxLiguesInscrites.Name = "listBoxLiguesInscrites";
            this.listBoxLiguesInscrites.Size = new System.Drawing.Size(138, 212);
            this.listBoxLiguesInscrites.TabIndex = 37;
            // 
            // listBoxEquipement
            // 
            this.listBoxEquipement.FormattingEnabled = true;
            this.listBoxEquipement.Location = new System.Drawing.Point(440, 139);
            this.listBoxEquipement.Name = "listBoxEquipement";
            this.listBoxEquipement.Size = new System.Drawing.Size(138, 212);
            this.listBoxEquipement.TabIndex = 36;
            // 
            // lblListedesequipements
            // 
            this.lblListedesequipements.AutoSize = true;
            this.lblListedesequipements.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListedesequipements.Location = new System.Drawing.Point(418, 78);
            this.lblListedesequipements.Name = "lblListedesequipements";
            this.lblListedesequipements.Size = new System.Drawing.Size(180, 23);
            this.lblListedesequipements.TabIndex = 35;
            this.lblListedesequipements.Text = "Liste des équipements";
            // 
            // lblStandtaille
            // 
            this.lblStandtaille.AutoSize = true;
            this.lblStandtaille.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandtaille.Location = new System.Drawing.Point(249, 78);
            this.lblStandtaille.Name = "lblStandtaille";
            this.lblStandtaille.Size = new System.Drawing.Size(119, 23);
            this.lblStandtaille.TabIndex = 34;
            this.lblStandtaille.Text = "Taille du stand";
            // 
            // lblLargeur
            // 
            this.lblLargeur.AutoSize = true;
            this.lblLargeur.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargeur.Location = new System.Drawing.Point(233, 251);
            this.lblLargeur.Name = "lblLargeur";
            this.lblLargeur.Size = new System.Drawing.Size(58, 19);
            this.lblLargeur.TabIndex = 33;
            this.lblLargeur.Text = "Largeur";
            // 
            // lblLongueur
            // 
            this.lblLongueur.AutoSize = true;
            this.lblLongueur.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongueur.Location = new System.Drawing.Point(233, 194);
            this.lblLongueur.Name = "lblLongueur";
            this.lblLongueur.Size = new System.Drawing.Size(69, 19);
            this.lblLongueur.TabIndex = 32;
            this.lblLongueur.Text = "Longueur";
            // 
            // lblInscriptionLigues
            // 
            this.lblInscriptionLigues.AutoSize = true;
            this.lblInscriptionLigues.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblInscriptionLigues.Location = new System.Drawing.Point(46, 19);
            this.lblInscriptionLigues.Name = "lblInscriptionLigues";
            this.lblInscriptionLigues.Size = new System.Drawing.Size(305, 29);
            this.lblInscriptionLigues.TabIndex = 31;
            this.lblInscriptionLigues.Text = "Inscription des ligues à la JPO";
            // 
            // btnInscrire
            // 
            this.btnInscrire.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscrire.Location = new System.Drawing.Point(83, 382);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(106, 49);
            this.btnInscrire.TabIndex = 46;
            this.btnInscrire.Text = "Inscrire";
            this.btnInscrire.UseVisualStyleBackColor = true;
            // 
            // checkBoxEquipement
            // 
            this.checkBoxEquipement.AutoSize = true;
            this.checkBoxEquipement.BackColor = System.Drawing.Color.White;
            this.checkBoxEquipement.Location = new System.Drawing.Point(455, 160);
            this.checkBoxEquipement.Name = "checkBoxEquipement";
            this.checkBoxEquipement.Size = new System.Drawing.Size(80, 17);
            this.checkBoxEquipement.TabIndex = 47;
            this.checkBoxEquipement.Text = "checkBox1";
            this.checkBoxEquipement.UseVisualStyleBackColor = false;
            // 
            // btnModifierEquipement
            // 
            this.btnModifierEquipement.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierEquipement.Location = new System.Drawing.Point(472, 382);
            this.btnModifierEquipement.Name = "btnModifierEquipement";
            this.btnModifierEquipement.Size = new System.Drawing.Size(106, 49);
            this.btnModifierEquipement.TabIndex = 48;
            this.btnModifierEquipement.Text = "Modifier équipements";
            this.btnModifierEquipement.UseVisualStyleBackColor = true;
            // 
            // frmInscriptionLigues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifierEquipement);
            this.Controls.Add(this.checkBoxEquipement);
            this.Controls.Add(this.btnInscrire);
            this.Controls.Add(this.btnModifierStand);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnDésincrire);
            this.Controls.Add(this.numericUpDownLargeur);
            this.Controls.Add(this.numericUpDownLongueur);
            this.Controls.Add(this.lblLiguesNonInscrites);
            this.Controls.Add(this.listBoxLiguesNonInscrites);
            this.Controls.Add(this.lblLiguesInscrites);
            this.Controls.Add(this.listBoxLiguesInscrites);
            this.Controls.Add(this.listBoxEquipement);
            this.Controls.Add(this.lblListedesequipements);
            this.Controls.Add(this.lblStandtaille);
            this.Controls.Add(this.lblLargeur);
            this.Controls.Add(this.lblLongueur);
            this.Controls.Add(this.lblInscriptionLigues);
            this.Name = "frmInscriptionLigues";
            this.Text = "Inscription ligues";
            this.Load += new System.EventHandler(this.frmInscriptionLigues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLargeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLongueur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifierStand;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnDésincrire;
        private System.Windows.Forms.NumericUpDown numericUpDownLargeur;
        private System.Windows.Forms.NumericUpDown numericUpDownLongueur;
        private System.Windows.Forms.Label lblLiguesNonInscrites;
        private System.Windows.Forms.ListBox listBoxLiguesNonInscrites;
        private System.Windows.Forms.Label lblLiguesInscrites;
        private System.Windows.Forms.ListBox listBoxLiguesInscrites;
        private System.Windows.Forms.ListBox listBoxEquipement;
        private System.Windows.Forms.Label lblListedesequipements;
        private System.Windows.Forms.Label lblStandtaille;
        private System.Windows.Forms.Label lblLargeur;
        private System.Windows.Forms.Label lblLongueur;
        private System.Windows.Forms.Label lblInscriptionLigues;
        private System.Windows.Forms.Button btnInscrire;
        private System.Windows.Forms.CheckBox checkBoxEquipement;
        private System.Windows.Forms.Button btnModifierEquipement;
    }
}