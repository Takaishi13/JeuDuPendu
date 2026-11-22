using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDuPendu
{
    public partial class Form1 : Form
    {
        static string mot;
        static int number;
        public Form1()
        {
            InitializeComponent();
        }
        public void Alphabet()
        {
            cmbLettres.Items.Clear();

            // déclaration
            char Caractere = 'A';

            // remplissage du combo
            for (int k = 0; k < 26; k++)
            {

                Caractere = (char)('A' + k);
                cmbLettres.Items.Add(Caractere);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // initialisation du jeu
            TxtMot.Enabled = true;
            TxtMot.Clear();
            TxtMot.Focus();
            ImgPendu.Image = (Image)Properties.Resources.ResourceManager.GetObject("pendu0");
            number = 1;

            Alphabet();
            cmbLettres.Enabled = false;
            btnReset.Enabled = false;
            btnTest1.Enabled = false;
            lblLettreUtilise.Text = "";
        }

        private void TxtMot_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (TxtMot.Text.Length == 0)
                {
                    MessageBox.Show("Veuillez entrer un mot !");
                    return;
                }
                // vérification (rien d'autre que l'alphabet, pas plus que 15 lettres)
                foreach (char c in TxtMot.Text)
                {
                    if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')))
                    {
                        MessageBox.Show("Le texte contient autre chose que des lettres !");
                        TxtMot.Clear();
                        return;
                    }
                }
                if (TxtMot.Text.Length > 15)
                {
                    MessageBox.Show("Le mot ne doit pas dépasser 15 caractères.");
                    TxtMot.Clear();
                    return;
                }
                else
                {
                    // début de partie
                    mot = TxtMot.Text;
                    TxtMot.Enabled = false;
                    TxtMot.Clear();
                    for (int k = 1; k <= mot.Length; k++)
                    {
                        TxtMot.Text = TxtMot.Text + "-";
                    }
                    cmbLettres.Enabled = true;
                    btnTest1.Enabled = true;
                    btnReset.Enabled = true;
                }
            }
        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            if (cmbLettres.Text.Length != 1)
            {
                MessageBox.Show("Veuillez sélectionner une lettre !");
                return;
            }
            char lettre = char.Parse(cmbLettres.Text);
            string motcache = TxtMot.Text;
            for (int k = 0; k < mot.Length; k++)
            {
                if (char.ToUpper(mot[k]) == char.ToUpper(lettre))
                {
                    motcache = motcache.Remove(k, 1).Insert(k, lettre.ToString());
                }
            }
            if (mot.ToUpper().IndexOf(char.ToUpper(lettre)) == -1)
            {
                ImgPendu.Image = (Image)Properties.Resources.ResourceManager.GetObject("pendu"+ number);
                number += 1;
            }
            TxtMot.Text = motcache;
            lblLettreUtilise.Text = lblLettreUtilise.Text + cmbLettres.Text;
            if (cmbLettres.SelectedIndex != -1)
            {
                cmbLettres.Items.RemoveAt(cmbLettres.SelectedIndex);
            }
            cmbLettres.Focus();
            if (number == 11)
            {
                MessageBox.Show("Vous avez perdu !", "Le mot à chercher était " + mot +" !");
                btnReset.Focus();
                btnTest1.Enabled = false;
                cmbLettres.Enabled = false;
            }
            if (motcache.IndexOf('-') == -1)
            {
                MessageBox.Show("Vous avez gagné !", "Le mot était bel et bien " + mot + " !");
                btnTest1.Enabled = false;
                cmbLettres.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Etes vous sur de vouloir recommencer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                mot = "";
                cmbLettres.Items.Clear();
                Form1_Load(null, null);
            }
            else
            {
                return;
            }

        }
    }
}
