using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jpo
{
    public partial class frmInscriptionLigues : Form
    {
        public frmInscriptionLigues()
        {
            InitializeComponent();
        }

        private void frmInscriptionLigues_Load(object sender, EventArgs e)
        {
            //Récupération des données de la base + écriture dans la listBox

            try
            {
                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                OleDbDataReader ExtractionDonnées = DbConnex.GetDataReader("select * from ligues");
                while (ExtractionDonnées.Read())
                {
                    listBoxLiguesNonInscrites.Items.Add(ExtractionDonnées.GetString(1));
                }

                ExtractionDonnées = DbConnex.GetDataReader("select * from ligues");
                while (ExtractionDonnées.Read())
                {
                    listBoxLiguesNonInscrites.Items.Add(ExtractionDonnées.GetString(1));
                }

                DbConnex.connexionClose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erreur OleDb : " + ex.Message);
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                string request = "SELECT * LIGUES";
                int Commande = DbConnex.nonQuery(request);
                listBoxLiguesNonInscrites.Items.Clear();
                OleDbDataReader ExtractionDonnées2 = DbConnex.GetDataReader("select * from ligues");
                while (ExtractionDonnées2.Read())
                {
                    listBoxLiguesNonInscrites.Items.Add(ExtractionDonnées2.GetString(1));
                }
                DbConnex.connexionClose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erreur OleDb : " + ex.Message);
            }
        }

        private void btnDésincrire_Click(object sender, EventArgs e)
        {
            try
            {
                if (DbConnex.etatConnection() != ConnectionState.Open)
                {
                    DbConnex.connexionBase();
                }
                string request = "DELETE FROM LIGUES WHERE LIGUES.nomLigue ";
                int ExtractionDonnées = DbConnex.nonQuery(request);
                listBoxLiguesNonInscrites.Items.Clear();
                OleDbDataReader ExtractionDonnées2 = DbConnex.GetDataReader("select * from ligues");
                while (ExtractionDonnées2.Read())
                {
                    listBoxLiguesNonInscrites.Items.Add(ExtractionDonnées2.GetString(1));
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
