using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace jpo
{
    public partial class frmEnregistrementLigues : Form
    {
        public frmEnregistrementLigues()
        {
            InitializeComponent();
        }

        //Récupération des données de la base + écriture dans la listBox des Ligues qui sont enregistrées

        private void frmEnregistrementLigues_Load_1(object sender, EventArgs e)
        {

            List<Ligue> lesLigues = new List<Ligue>();
            lesLigues = DataGetter.getToutesLesLigues();
            listBoxLiguesEnregistrées.DataSource = lesLigues;
            listBoxLiguesEnregistrées.DisplayMember = "NomLigue";

            //Affectation des tailles max de chaque TextBox, contrôle de saisies

            tbxNom.MaxLength = 50;
            tbxAdresse.MaxLength = 50;
            tbxCodePostal.MaxLength = 5;
            tbxVille.MaxLength = 50;
            tbxDiscipline.MaxLength = 50;
        }
        #region Validating / KeyPress
        private void tbxNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

            }
        }

        private void tbxAdresse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void tbxCodePostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbxVille_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

            }
        }

        private void tbxDiscipline_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;

            }
        }
        #endregion
        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                int codeL = 0;
                codeL++; // Doublons donc ne marche pas, peut-être dans une boucle while
                String uneRequete = "INSERT INTO LIGUES (codeLigue, nomLigue, adresse, cp, ville, discipline) VALUES ('" + codeL + "' ,  '" + tbxNom.Text + "' , '" + tbxAdresse.Text + "','" + tbxCodePostal.Text + "' ,'" + tbxVille.Text + "' ,'" + tbxDiscipline.Text + "' ) ";
                MessageBox.Show(uneRequete);
                int UneCommande = DbConnex.Unscalar(uneRequete);
                DbConnex.connexionClose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erreur OleDb : " + ex.Message);
            }
        }

        // Bouton supprimer des ligues
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                string request = "DELETE FROM LIGUES WHERE LIGUES.nomLigue = '" + tbxNom.Text + "' AND LIGUES.adresse = '" + tbxAdresse.Text + "' AND LIGUES.cp = '" + tbxCodePostal.Text + "' AND LIGUES.ville= '" + tbxVille.Text + "' AND LIGUES.discipline ='" + tbxDiscipline.Text + "'; ";
                int ExtractionDonnées = DbConnex.nonQuery(request);
                listBoxLiguesEnregistrées.Items.Clear();
                OleDbDataReader ExtractionDonnées2 = DbConnex.GetDataReader("select * from ligues");
                while (ExtractionDonnées2.Read())
                {
                    listBoxLiguesEnregistrées.Items.Add(ExtractionDonnées2.GetString(1));
                }
                DbConnex.connexionClose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erreur OleDb : " + ex.Message);
            }
        }

        // Affichage des ligues enregistrées avec leurs informations dans la listBox
        private void listBoxLiguesEnregistrées_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                string request = "SELECT * FROM LIGUES WHERE LIGUES.nomLigue = '" + listBoxLiguesEnregistrées.SelectedItem + "';";
                OleDbDataReader ExtractionDonnées = DbConnex.GetDataReader(request);
                while (ExtractionDonnées.Read())
                {
                    tbxNom.Text = ExtractionDonnées.GetValue(2).ToString();
                    tbxAdresse.Text = ExtractionDonnées.GetValue(3).ToString();
                    tbxCodePostal.Text = ExtractionDonnées.GetValue(4).ToString();
                    tbxVille.Text = ExtractionDonnées.GetValue(5).ToString();
                    tbxDiscipline.Text = ExtractionDonnées.GetValue(6).ToString();
                }
                DbConnex.connexionClose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erreur OleDb : " + ex.Message);
            }
        }
    }
}



