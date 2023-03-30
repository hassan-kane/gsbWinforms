using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB_3_C
{
    public partial class GERER_VISITEURS : Form
    {
        private gsbrapportsEntities mesDonneesGSB;
        public GERER_VISITEURS(gsbrapportsEntities mesDonneesGSB)
        {
            InitializeComponent();
            this.mesDonneesGSB = mesDonneesGSB;
            var visiteurs = mesDonneesGSB.visiteurs.ToList(); // exécute la requête et charge les données dans une liste
            this.bdgSrcVisiteur.DataSource = visiteurs; // lie la liste à la source de données
        }

        private string getIdVisiteur()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(10000); // génère un nombre aléatoire entre 0 et 9999
            char randomLetter = (char)rand.Next('a', 'z' + 1); // génère une lettre minuscule aléatoire

            return string.Format("{0}{1:D4}", randomLetter, randomNumber); // concatène la lettre et le nombre, avec le nombre sur 4 chiffres (en ajoutant des zéros devant si nécessaire)
        }

       /* private string getLoginVisiteur()
        {
            Random rand = new Random();
            string[] prefixes = { "john", "jane", "bob", "alice", "sam", "sara", "max", "lisa", "tom", "mary", "tim", "amy", "dan", "emily", "mike" }; // liste de préfixes de noms possibles
            string[] suffixes = { "smith", "jones", "brown", "lee", "wilson", "taylor", "clark", "wright", "green", "adams", "baker", "cooper", "carter", "parker", "campbell" }; // liste de suffixes de noms possibles
            string prefix = prefixes[rand.Next(prefixes.Length)]; // sélectionne un préfixe de nom aléatoire
            string suffix = suffixes[rand.Next(suffixes.Length)]; // sélectionne un suffixe de nom aléatoire
            return string.Format("{0}_{1}", prefix, suffix); // concatène le préfixe et le suffixe avec un "_" entre les deux
        }*/

        private string getMdpVisiteur(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private char getPremiereLettreDuPrenom(string mot)
        {
            return mot[0];
        }


        private void bdgNavVisiteur_RefreshItems(object sender, EventArgs e)
        {
            this.txtIDVisiteur.Text = this.getIdVisiteur();

            if (!string.IsNullOrEmpty(this.txtPrenomVisiteur.Text))
            {
                this.txtLoginVisiteur.Text = this.txtPrenomVisiteur.Text[0] + this.txtNomVisiteur.Text;
            }
            else
            {
                this.txtLoginVisiteur.Text = this.txtNomVisiteur.Text;
            }

            this.txtMdpVisiteur.Text = this.getMdpVisiteur(6);

            // Mettre les champs nom, login et mot de passe en lecture seule
            this.txtIDVisiteur.ReadOnly = true;
            this.txtLoginVisiteur.ReadOnly = true;
            this.txtMdpVisiteur.ReadOnly = true;
        }

        private void btnEnregistrerVisiteur_Click(object sender, EventArgs e)
        {
            try
            {
                this.bdgSrcVisiteur.EndEdit();
                this.mesDonneesGSB.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur est survenue lors de l'enregistrement des données : " + ex.Message);
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            if(txtNomVisiteur.Text == "" ||txtPrenomVisiteur.Text == "" || txtAdresseVisiteur.Text == "" || txtVilleVisiteur.Text == "" || txtCpVisiteur.Text == "")
            {
                MessageBox.Show("Veuillez renseigner tous les champs du nouveau visiteur pour que l'ajout soit effectif");
                bdgSrcVisiteur.CancelEdit(); // Annule l'ajout dans le cas ou le nouveau visiteur n'a pas d'info
            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            if (txtNomVisiteur.Text == "" || txtPrenomVisiteur.Text == "" || txtAdresseVisiteur.Text == "" || txtVilleVisiteur.Text == "" || txtCpVisiteur.Text == "")
            {
                MessageBox.Show("Veuillez renseigner tous les champs du nouveau visiteur pour que l'ajout soit effectif");
                bdgSrcVisiteur.CancelEdit(); // Annule l'ajout dans le cas ou le nouveau visiteur n'a pas d'info
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            /* if (txtNomVisiteur.Text == "" || txtPrenomVisiteur.Text == "" || txtAdresseVisiteur.Text == "" || txtVilleVisiteur.Text == "" || txtCpVisiteur.Text == "")
             {
                 MessageBox.Show("Veuillez renseigner tous les champs du nouveau visiteur pour que l'ajout soit effectif");
                 bdgSrcVisiteur.CancelEdit(); // Annule l'ajout dans le cas ou le nouveau visiteur n'a pas d'info
             }*/
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            if (txtNomVisiteur.Text == "" || txtPrenomVisiteur.Text == "" || txtAdresseVisiteur.Text == "" || txtVilleVisiteur.Text == "" || txtCpVisiteur.Text == "")
            {
                MessageBox.Show("Veuillez renseigner tous les champs du nouveau visiteur pour que l'ajout soit effectif");
                bdgSrcVisiteur.CancelEdit(); // Annule l'ajout dans le cas ou le nouveau visiteur n'a pas d'info
            }
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            if (txtNomVisiteur.Text == "" || txtPrenomVisiteur.Text == "" || txtAdresseVisiteur.Text == "" || txtVilleVisiteur.Text == "" || txtCpVisiteur.Text == "")
            {
                MessageBox.Show("Veuillez renseigner tous les champs du nouveau visiteur pour que l'ajout soit effectif");
                bdgSrcVisiteur.CancelEdit(); // Annule l'ajout dans le cas ou le nouveau visiteur n'a pas d'info
            }
        }
    }
}
