using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace jpo
{
    public partial class frmEnregistrementMembres : Form
    {

        public frmEnregistrementMembres()
        {
            InitializeComponent();
        }

        private void frmEnregistrementMembres_Load(object sender, EventArgs e)
        {
            //Récupération des données de la base + écriture dans la listBox

            try
            {
                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                OleDbDataReader ExtractionDonnées = DbConnex.GetDataReader("select * from membre");
                while (ExtractionDonnées.Read())
                {
                    lbxListeMembres.Items.Add(ExtractionDonnées.GetString(1));
                }

                ExtractionDonnées = DbConnex.GetDataReader("select * from ligues");
                while (ExtractionDonnées.Read())
                {
                    cbxListeMembresLigue.Items.Add(ExtractionDonnées.GetString(1));
                }

                DbConnex.connexionClose();
            }
            catch(OleDbException ex)
            {
                MessageBox.Show("Erreur OleDb : " + ex.Message);
            }
            
            //Affectation des tailles max de chaque TextBox, des styles des combobox et enlèevement de l'autoValidate (pour l'errorProvider)
            
            tbxNom.MaxLength = 40;
            tbxPrenom.MaxLength = 40;
            tbxTelephone.MaxLength = 14;
            tbxMail.MaxLength = 40;
            cbxListeMembresLigue.DropDownStyle = ComboBoxStyle.DropDownList;
            AutoValidate = AutoValidate.Disable;
        }
        #region KeyPress/Validating
        private void tbxNom_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbxPrenom_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void tbxMail_Validating(object sender, CancelEventArgs e)
        {
            Regex rxMail = new Regex(@"^[a-z]{0,25}\@[a-z]{0,10}\.[a-z]{0,5}$");
            if (!rxMail.IsMatch(this.tbxMail.Text))
            {
                tbxMail.Clear();
                errorProvider.SetError(tbxMail, "Le mail saisi est incorrect");
            }
        }

        private void tbxTelephone_Validating(object sender, CancelEventArgs e)
        {
            Regex rxTel = new Regex(@"^(\d{2}\.){4}\d{2}$");
            if (!rxTel.IsMatch(this.tbxTelephone.Text))
            {
                tbxTelephone.Clear();
                errorProvider.SetError(tbxTelephone, "Le numéro de téléphone saisi est incorrect");
            }
        }
        #endregion
        private void cbxListeMembresLigue_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                String request = "SELECT * FROM MEMBRE, LIGUES WHERE MEMBRE.codeLigue = LIGUES.codeLigue AND LIGUES.nomLigue LIKE \"" + Convert.ToString(cbxListeMembresLigue.SelectedItem) + "\" ;";
                OleDbDataReader ExtractionMembres = DbConnex.GetDataReader(request);
                lbxListeMembres.Items.Clear();
                while (ExtractionMembres.Read())
                {
                    lbxListeMembres.Items.Add(ExtractionMembres.GetString(1));
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            ValidateChildren();

            if (errorProvider.GetError(tbxMail) == "" && errorProvider.GetError(tbxTelephone) == "")
            {
                try
                {
                    if (DbConnex.etatConnection() != ConnectionState.Open)
                    {
                        DbConnex.connexionBase();
                    }
                    string request = "INSERT INTO MEMBRE (nom, prénom, téléphone, mail) VALUES ('" + tbxNom.Text + "','" + tbxPrenom.Text + "','" + tbxTelephone.Text + "','" + tbxMail.Text + "');";
                    int Commande = DbConnex.nonQuery(request);
                    lbxListeMembres.Items.Clear();
                    OleDbDataReader ExtractionDonnées2 = DbConnex.GetDataReader("select * from membre");
                    while (ExtractionDonnées2.Read())
                    {
                        lbxListeMembres.Items.Add(ExtractionDonnées2.GetString(1));
                    }
                    DbConnex.connexionClose();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Erreur OleDb : " + ex.Message);
                }
            }
        }

        private void lbxListeMembres_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                string request = "SELECT * FROM MEMBRE WHERE MEMBRE.nom = '" + lbxListeMembres.SelectedItem + "';";
                OleDbDataReader ExtractionDonnées = DbConnex.GetDataReader(request);
                while (ExtractionDonnées.Read())
                {
                    tbxNom.Text = ExtractionDonnées.GetValue(1).ToString();
                    tbxPrenom.Text = ExtractionDonnées.GetValue(2).ToString();
                    tbxTelephone.Text = ExtractionDonnées.GetValue(3).ToString();
                    tbxMail.Text = ExtractionDonnées.GetValue(4).ToString();
                }
                DbConnex.connexionClose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erreur OleDb : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                string request = "DELETE FROM MEMBRE WHERE MEMBRE.nom = '" + tbxNom.Text + "' AND MEMBRE.prénom = '" + tbxPrenom.Text + "' AND MEMBRE.mail = '" + tbxMail.Text + "' AND MEMBRE.téléphone = '" + tbxTelephone.Text + "';";
                int ExtractionDonnées = DbConnex.nonQuery(request);
                lbxListeMembres.Items.Clear();
                OleDbDataReader ExtractionDonnées2 = DbConnex.GetDataReader("select * from membre");
                while (ExtractionDonnées2.Read())
                {
                    lbxListeMembres.Items.Add(ExtractionDonnées2.GetString(1));
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
