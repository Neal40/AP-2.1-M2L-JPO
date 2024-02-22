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
    public partial class frmInscriptionMembres : Form
    {
        public frmInscriptionMembres()
        {
            InitializeComponent();
        }

        private void frmInscriptionMembres_Load(object sender, EventArgs e)
        {
            try
            {
                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                OleDbDataReader ExtractionDonnées = DbConnex.GetDataReader("select * from ligues");
                while (ExtractionDonnées.Read())
                {
                    cbxLigue.Items.Add(ExtractionDonnées.GetString(1));
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erreur OleDb : " + ex.Message);
            }

            cbxLigue.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxActMatin.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxActAprem.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void lblMembresInscrits_Click(object sender, EventArgs e)
        {

        }

        private void cbxLigue_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                String request = "SELECT * FROM MEMBRE, LIGUES WHERE MEMBRE.codeLigue = LIGUES.codeLigue AND LIGUES.nomLigue LIKE \"" + Convert.ToString(cbxLigue.SelectedItem) + "\" ;";
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
    }
}
