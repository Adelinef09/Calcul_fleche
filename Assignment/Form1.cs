using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Assignment
{
    public partial class Form1 : Form
    {
        private DataExport logger;
        private DataImport dataImport;
        public Form1()
        {
            InitializeComponent();
            this.logger = new DataExport();
            dataImport = new DataImport();


        }

        // Lorque l'on clique sur le bouton "ouvrir l'abaque", on ouvre une fenêtre pour choisir le fichier
        // A l'aide de de la fonction importAbaqueFile, on charge les matériaux et leur module d'Young dans un dictionnaire
        // Enfin on rempli la combobox avec les noms de matériaux
        private void abaqueButton_Click(object sender, EventArgs e)
        {
            materiauxComboBox.Items.Clear();
            openFileDialog1.ShowDialog();
            /// charge les materiaux
            Dictionary<string, string> dictionnaire;
            dictionnaire = dataImport.ImportAbaqueFile(openFileDialog1.FileName);
            
            foreach (var entry in dictionnaire)
            {
                materiauxComboBox.Items.Add(entry.Key);
            }
        }

        //Cette fonction permet de calculer les deux flèches (maximale et associée)
        //Elle comporte en premier lieu les messages d'alerte lorsqu'il y a une exception comme le manque d'une donnée par exemple
        //Ensuite selon si la section est circulaire ou rectangulaire on procède au calcul des flèches
        //Elle écrit ensuite le calcul dans le fichier log.txt
        // Et enfin elle affiche un message en vert ou en rouge selon si la poutre peut supporté ou non la charge
        private void calculFlecheButton_Click(object sender, EventArgs e)
        {
            //Exceptions
            if (formeComboBox.Text=="")
            {
                MessageBox.Show("Veuillez choisir un type de section puis entrer les paramètres correspondant");
            }
            if (longueurTextBox.Text == "")
            {
                MessageBox.Show("Veuillez saisir une longueur");
            }
            if (formeComboBox.Text == "Rectangulaire" && largeurTextBox.Text == "")
            {
                MessageBox.Show("Veuillez saisir une largeur");
            }
            if (formeComboBox.Text == "Rectangulaire" && hauteurTextBox.Text == "")
            {
                MessageBox.Show("Veuillez saisir une hauteur");
            }
            if (formeComboBox.Text == "Circulaire" && rayonTextBox.Text == "")
            {
                MessageBox.Show("Veuillez saisir un rayon");
            }
            if (momentTextBox.Text == "")
            {
                MessageBox.Show("Veuillez saisir un moment quadratique");
            }
            if (moduleTextBox.Text == "")
            {
                MessageBox.Show("Veuillez saisir un module d'Young");
            }
            if (chargeTextBox.Text == "")
            {
                MessageBox.Show("Veuillez saisir une charge");
            }

            else
            {
                if (formeComboBox.Text == "Rectangulaire")
                {
                    rayonTextBox.Text = "0";
                    Calcul calculateur = new Calcul(Int32.Parse(longueurTextBox.Text), Double.Parse(largeurTextBox.Text), Double.Parse(hauteurTextBox.Text), Double.Parse(rayonTextBox.Text), Double.Parse(momentTextBox.Text), Double.Parse(chargeTextBox.Text), Double.Parse(moduleTextBox.Text));
                    associeeTextBox.Text = calculateur.CalculFlecheAssocieeRectangulaire().ToString();
                    maximaleTextBox.Text = calculateur.CalculFlecheMaxRectangulaire().ToString();
                    //écrire le calcul dans le fichier log.txt grâce à la concaténation de variables
                    // et de textes fixes
                    logger.Log(DateTime.Now + "\n" + "Forme Rectangulaire" + ":" + "\n " + "Longueur = " + longueurTextBox.Text + "\n Largeur = " + largeurTextBox.Text + "\n Hauteur = " + hauteurTextBox.Text + "\n Moment quadratique = " + momentTextBox.Text + "\n Charge = " + chargeTextBox.Text + "\n Module d'Young = " + moduleTextBox.Text + "\n Résultats : Flèche associée : " + associeeTextBox.Text + " Flèche maximale : " + maximaleTextBox.Text);
                    if (calculateur.CalculFlecheAssocieeRectangulaire() > calculateur.CalculFlecheMaxRectangulaire())
                    {
                        resultatVertLabel.Visible = false;
                        resultatRougeLabel.Visible = true;
                    }
                    else
                    {
                        resultatRougeLabel.Visible = false;
                        resultatVertLabel.Visible = true;
                    }
                }

                if (formeComboBox.Text == "Circulaire")
                {
                    largeurTextBox.Text = "0";
                    hauteurTextBox.Text = "0";
                    Calcul calculateur = new Calcul(Int32.Parse(longueurTextBox.Text), Double.Parse(largeurTextBox.Text), Double.Parse(hauteurTextBox.Text), Double.Parse(rayonTextBox.Text), Double.Parse(momentTextBox.Text), Double.Parse(chargeTextBox.Text), Double.Parse(moduleTextBox.Text));
                    associeeTextBox.Text = calculateur.CalculFlecheAssocieeCirculaire().ToString();
                    maximaleTextBox.Text = calculateur.CalculFlecheMaxCirculaire().ToString();
                    //écrire le calcul dans le fichier log.txt grâce à la concaténation de variables
                    // et de textes fixes
                    logger.Log(DateTime.Now + "\n" + "Forme circulaire" + ":" + "\n " + "Longueur = " + longueurTextBox.Text + "\n Rayon = " + rayonTextBox.Text + "\n Moment quadratique = " + momentTextBox.Text + "\n Charge = " + chargeTextBox.Text + "\n Module d'Young = " + moduleTextBox.Text + "\n Résultats : Flèche associée : " + associeeTextBox.Text + " Flèche maximale : " + maximaleTextBox.Text);
                    if (calculateur.CalculFlecheAssocieeCirculaire() > calculateur.CalculFlecheMaxCirculaire())
                    {
                        resultatVertLabel.Visible = false;
                        resultatRougeLabel.Visible = true;
                    }
                    else
                    {
                        resultatRougeLabel.Visible = false;
                        resultatVertLabel.Visible = true;
                    }
                }
            
            }
            

           
        }



        
        
        // Cette fonction permet lorque le matériau change dans la combobox de mettre le module d'Young à jour
        //Pour cela, on parcourt le dictionnaire pour voir si la clé existe et ainsi récupérer la valeur correspondante
        private void materiauxComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /// change la combo boxe
            Dictionary<string, string> dictionnaire;
            Dictionary<string, string> dictionnaireInitial;
            dictionnaireInitial = dataImport.ImportAbaqueFile("moduleYoung.abaque");
            dictionnaire = dataImport.ImportAbaqueFile(openFileDialog1.FileName);
            string a = materiauxComboBox.Text;
            string value = "";
            
            if (dictionnaire.TryGetValue(a, out value))
                moduleTextBox.Text=value;

            if (dictionnaireInitial.TryGetValue(a, out value))
                moduleTextBox.Text = value;

            else
            {
                Console.WriteLine("Key = \"a\" is not found.");
            }
        }

        //Cette fonction permet selon la forme de griser les valeurs ne correspondant pas à celle-ci
        //Par exemple, si la forme choisie est rectangulaire on grise le rayon et on affiche la photo correspondante
        private void formeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = formeComboBox.Text;
            if (text=="Rectangulaire")
            {
                rayonTextBox.Enabled = false;
                rayonHScrollBar.Enabled = false;
                rayonLabel.Enabled = false;
                largeurHScrollBar.Enabled=true;
                largeurTextBox.Enabled = true;
                hauteurHScrollBar.Enabled = true;
                hauteurTextBox.Enabled = true;
                hauteurLabel.Enabled = true;
                largeurLabel.Enabled = true;
                circulairePictureBox.Visible = false;
                rectangulairePictureBox.Visible = true;

            }
            else
            {
                rayonTextBox.Enabled = true;
                rayonHScrollBar.Enabled = true;
                rayonLabel.Enabled = true;
                largeurHScrollBar.Enabled = false;
                largeurTextBox.Enabled = false;
                hauteurHScrollBar.Enabled = false;
                hauteurTextBox.Enabled = false;
                hauteurLabel.Enabled = false;
                largeurLabel.Enabled = false;
                circulairePictureBox.Visible = true;
                rectangulairePictureBox.Visible = false;
            }
        }

        //Cette fonction permet d'importer automatiquement l'abaque moduleYoung.abaque et de la charger dans la combobox
        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> dictionnaire;
            dictionnaire = dataImport.ImportAbaqueFile("moduleYoung.abaque");
            foreach (var entry in dictionnaire)
            {
                materiauxComboBox.Items.Add(entry.Key);
            }
            
        }


        /// Paramétrage des HScrollBar et des TextBox
        /// On procède de la même manière pour chacunes d'entre elles
        /// Sera donc détaillé seulement le code de la longueur
        
        /// Lorsque la valeur de l'HscrollBar change, on change également celle de la TextBox correspondante
        private void longueurHScrollBar_ValueChanged(object sender, EventArgs e)
        {
            longueurTextBox.Text = longueurHScrollBar.Value.ToString();
        }

        //Gérer les exceptions dans la TextBox
        //Avertir que des lettres ne sont pas acceptées 
        //Lorsqu'on revient sur un string vide, laisser la même valeur à la HScrollBar
        //Lorsqu'un "-" est saisi, spécifié que les négatifs ne sont pas acceptés
        //Lorsque la borne supérieure est passée, le préciser
        private void longueurTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in longueurTextBox.Text)
            {
                if (Char.IsLetter(c))
                {
                    MessageBox.Show("Veuillez saisir un nombre et non une lettre");
                    longueurTextBox.Text = "";
                }
            }
                    
            if (longueurTextBox.Text == "")
            {
                longueurHScrollBar.Value = longueurHScrollBar.Value;
            }

            if (longueurTextBox.Text=="-")
            {
                MessageBox.Show("Veuillez saisir un nombre positif");
                longueurTextBox.Text="";
            }
            if (longueurTextBox.Text != "" && Int32.Parse(longueurTextBox.Text) > 1000)
            {
                MessageBox.Show("Veuillez saisir un nombre inférieur à 1000");
                longueurTextBox.Text = "";
            }
            
            if (longueurTextBox.Text != "" && Int32.Parse(longueurTextBox.Text) < 1000)
            {
                longueurHScrollBar.Value = Int32.Parse(longueurTextBox.Text);
            }

        }

        private void rayonHScrollBar_ValueChanged(object sender, EventArgs e)
        {
            rayonTextBox.Text = rayonHScrollBar.Value.ToString();
        }

        private void rayonTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in rayonTextBox.Text)
            {
                if (Char.IsLetter(c))
                {
                    MessageBox.Show("Veuillez saisir un nombre et non une lettre");
                    rayonTextBox.Text = "";
                }
            }
            if (rayonTextBox.Text == "")
            {
                rayonHScrollBar.Value = rayonHScrollBar.Value;
            }
            if (rayonTextBox.Text == "-")
            {
                MessageBox.Show("Veuillez saisir un nombre positif");
                rayonTextBox.Text = "";
            }
            if (rayonTextBox.Text != "" && Int32.Parse(rayonTextBox.Text) > 1000)
            {
                MessageBox.Show("Veuillez saisir un nombre inférieur à 1000");
                rayonTextBox.Text = "";
            }
            
            if (rayonTextBox.Text != "" && Int32.Parse(rayonTextBox.Text) < 1000)
            {
                rayonHScrollBar.Value = Int32.Parse(rayonTextBox.Text);
            }
        }

        private void largeurHScrollBar_ValueChanged(object sender, EventArgs e)
        {

            largeurTextBox.Text = largeurHScrollBar.Value.ToString();
        }
        private void largeurTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in largeurTextBox.Text)
            {
                if (Char.IsLetter(c))
                {
                    MessageBox.Show("Veuillez saisir un nombre et non une lettre");
                    largeurTextBox.Text = "";
                }
            }
            if (largeurTextBox.Text == "")
            {
                largeurHScrollBar.Value = largeurHScrollBar.Value;
            }
            if (largeurTextBox.Text == "-")
            {
                MessageBox.Show("Veuillez saisir un nombre positif");
                largeurTextBox.Text = "";
            }
            
            if (largeurTextBox.Text != "" && Int32.Parse(largeurTextBox.Text) > 1000)
            {
                MessageBox.Show("Veuillez saisir un nombre inférieur à 1000");
                largeurTextBox.Text = "";
            }
            if (largeurTextBox.Text != "" && Int32.Parse(largeurTextBox.Text) < 1000)
            {
                largeurHScrollBar.Value = Int32.Parse(largeurTextBox.Text);
            }
            
        }

        private void hauteurHScrollBar_ValueChanged(object sender, EventArgs e)
        {
            hauteurTextBox.Text = hauteurHScrollBar.Value.ToString();
        }
        private void hauteurTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in hauteurTextBox.Text)
            {
                if (Char.IsLetter(c))
                {
                    MessageBox.Show("Veuillez saisir un nombre et non une lettre");
                    hauteurTextBox.Text = "";
                }
            }
            if (hauteurTextBox.Text == "")
            {
                hauteurHScrollBar.Value = hauteurHScrollBar.Value;
            }
            if (hauteurTextBox.Text == "-")
            {
                MessageBox.Show("Veuillez saisir un nombre positif");
                hauteurTextBox.Text = "";
            }
            
            if (hauteurTextBox.Text != "" && Int32.Parse(hauteurTextBox.Text) > 1000)
            {
                MessageBox.Show("Veuillez saisir un nombre inférieur à 1000");
                hauteurTextBox.Text = "";
            }
            if (hauteurTextBox.Text != "" && Int32.Parse(hauteurTextBox.Text) < 1000)
            {
                hauteurHScrollBar.Value = Int32.Parse(hauteurTextBox.Text);
            }
            
        }

        private void momentHScrollBar_ValueChanged(object sender, EventArgs e)
        {
            momentTextBox.Text = momentHScrollBar.Value.ToString();
        }

        private void momentTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in momentTextBox.Text)
            {
                if (Char.IsLetter(c))
                {
                    MessageBox.Show("Veuillez saisir un nombre et non une lettre");
                    momentTextBox.Text = "";
                }
            }
            if (momentTextBox.Text == "")
            {
                momentHScrollBar.Value = momentHScrollBar.Value;
            }
            if (momentTextBox.Text == "-")
            {
                MessageBox.Show("Veuillez saisir un nombre positif");
                momentTextBox.Text = "";
            }
           
            if (momentTextBox.Text != "" && Int32.Parse(momentTextBox.Text) > 1000)
            {
                MessageBox.Show("Veuillez saisir un nombre inférieur à 1000");
                momentTextBox.Text = "";
            }
            if (momentTextBox.Text != "" && Int32.Parse(momentTextBox.Text) < 1000)
            {
                momentHScrollBar.Value = Int32.Parse(momentTextBox.Text);
            }
            
        }

        private void chargeHScrollBar_ValueChanged(object sender, EventArgs e)
        {
            chargeTextBox.Text = chargeHScrollBar.Value.ToString();
        }
        private void chargeTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in chargeTextBox.Text)
            {
                if (Char.IsLetter(c))
                {
                    MessageBox.Show("Veuillez saisir un nombre et non une lettre");
                    chargeTextBox.Text = "";
                }
            }
            if (chargeTextBox.Text == "")
            {
                chargeHScrollBar.Value = chargeHScrollBar.Value;
            }
            if (chargeTextBox.Text=="-")
            {
                MessageBox.Show("Veuillez saisir un nombre positif");
                chargeTextBox.Text = "";
            }
            
            if (chargeTextBox.Text != "" && Int32.Parse(chargeTextBox.Text) > 1000)
            {
                MessageBox.Show("Veuillez saisir un nombre inférieur à 1000");
                chargeTextBox.Text = "";
            }
            if (chargeTextBox.Text != "" && Int32.Parse(chargeTextBox.Text) < 1000)
            {
                chargeHScrollBar.Value = Int32.Parse(chargeTextBox.Text);
            }
        }


        //Cette fonction permet d'enregistrer les calculs dans un fichier log.txt
        //Deux cas distincte selon si la forme est rectangulaire ou circulaire
        //Grâce à la fonction log de DataExport, on peut remplir le fichier
        // On enregistre la date et l'heure, les variables, et les résultats
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            this.logger = new DataExport(saveFileDialog1.FileName);

            if (formeComboBox.Text == "Rectangulaire")
            {
                logger.Log(DateTime.Now + "\n" + "Forme Rectangulaire" + ":" + "\n " + "Longueur = " + longueurTextBox.Text + "\n Largeur = " + largeurTextBox.Text + "\n Hauteur = " + hauteurTextBox.Text + "\n Moment quadratique = " + momentTextBox.Text + "\n Charge = " + chargeTextBox.Text + "\n Module d'Young = " + moduleTextBox.Text + "\n Résultats : Flèche associée : " + associeeTextBox.Text + " Flèche maximale : " + maximaleTextBox.Text);
            }

            else
            {
                logger.Log(DateTime.Now + "\n" + "Forme circulaire" + ":" + "\n " + "Longueur = " + longueurTextBox.Text + "\n Rayon = " + rayonTextBox.Text + "\n Moment quadratique = " + momentTextBox.Text + "\n Charge = " + chargeTextBox.Text + "\n Module d'Young = " + moduleTextBox.Text + "\n Résultats : Flèche associée : " + associeeTextBox.Text + " Flèche maximale : " + maximaleTextBox.Text);
            }
        }

        //Lorque l'on clique sur enregistrer les calculs, une fenêtre s'ouvre et le choix du fichier log.txt peut être fait
        private void ouvrirLogButton_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.ShowDialog();

        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
