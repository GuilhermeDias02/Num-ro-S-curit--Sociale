using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumSs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string extraction(string numSS, int premierCarac, int nombreCarac)
        { 
            return (numSS.Substring(premierCarac, nombreCarac));
        }
        private bool isNumeric(string numSS)
        {
            int i = 0;
            bool digit = true;
            while (i<=numSS.Length-1 && digit == true) {
                
                if (char.IsNumber(numSS[i]) == false) {
                    digit = false;
                }

                i++;
            }
            return digit;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Il y a une erreur. Voulez-vous la corriger ?", "Erreur", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes) {
                this.Close();
            }
            else {
                this.Close();
            }
        }
        
        private void btnEffacer_Click(object sender, EventArgs e)
        {
            TxtNumSS.Text = "";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerifier_Click(object sender, EventArgs e)
        {
            string erreur = "Erreur/s:\n";
            string temp;

            if (isNumeric(TxtNumSS.Text) != true/* && TxtNumSS.Text.Length == 15 && (Convert.ToInt64(TxtNumSS.Text.Substring(0, 1)) == 1 || Convert.ToInt64(TxtNumSS.Text.Substring(0, 1)) == 0) && (Convert.ToInt64(TxtNumSS.Text.Substring(3, 2)) >=1 || Convert.ToInt64(TxtNumSS.Text.Substring(3, 2)) <= 12) && Convert.ToInt64(TxtNumSS.Text.Substring(13, 2)) == (97 - (Convert.ToInt64(TxtNumSS.Text)%97))*/){
                temp = "N'utilisez que des chiffres.\n";
                erreur += temp;
            }
            if (TxtNumSS.Text.Length != 15) {
                temp = "Un numéro de sécurité sociale est composé de 15 chiffres.\n";
                erreur += temp;
            }
            else if (Convert.ToInt64(TxtNumSS.Text.Substring(0, 1)) != 1 || Convert.ToInt64(TxtNumSS.Text.Substring(0, 1)) != 2) {
                temp = "Le premier chiffre est 1 pour un homme et 2 pour une femme.\n";
                erreur += temp;
            }
            else if (Convert.ToInt64(TxtNumSS.Text.Substring(3, 2)) < 1 || Convert.ToInt64(TxtNumSS.Text.Substring(3, 2)) > 12) {
                temp = "Le deuxième et troisième chiffre représentent le mois de naissance.\n";
                erreur += temp;
            }
            else if (Convert.ToInt64(TxtNumSS.Text.Substring(13, 2)) != (97 - (Convert.ToInt64(TxtNumSS.Text) % 97))) {
                temp = "Les deux derniers chiffres représentent une clé de sécurité qui va jusqu'à 97.";
                erreur += temp;
            }

            MessageBox.Show(erreur);
        }
    }
}