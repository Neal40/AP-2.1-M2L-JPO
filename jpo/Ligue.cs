using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jpo
{
    class Ligue
    {
        private String nomLigue;
        private String codeLigue;
        private String adresse;
        private String cp;
        private String ville;
        private String discipline;
        private List<Membre> lesMembres;

        public Ligue(string nomLigue, string codeLigue, string adresse, string cp, string ville, string discipline)
        {
            this.NomLigue = nomLigue;
            this.CodeLigue = codeLigue;
            this.Adresse = adresse;
            this.Cp = cp;
            this.Ville = ville;
            this.Discipline = discipline;
            this.LesMembres = null;
        }

        public List<Membre> getLesMembres()
        {
            if (this.lesMembres == null)
            {
                this.lesMembres = DataGetter.getMembresByCodeLigue(this.codeLigue);
            }
            return this.lesMembres;
        }

        public string NomLigue { get => nomLigue; set => nomLigue = value; }
        public string CodeLigue { get => codeLigue; set => codeLigue = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Ville { get => ville; set => ville = value; }
        public string Discipline { get => discipline; set => discipline = value; }
        internal List<Membre> LesMembres { 
            get{ return this.getLesMembres(); }
            set => lesMembres = value;
        }
    }
}
