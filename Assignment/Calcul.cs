using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment
{
    public class Calcul
    {
        public double longueur;
        public double largeur;
        public double hauteur;
        public double rayon;
        public double momentQuadratique;
        public double charge;
        public double moduleYoung;

        
        public Calcul(double longueur, double largeur, double hauteur, double rayon, double momentQuadratique, double charge, double moduleYoung)
        {
            this.longueur = longueur;
            this.largeur = largeur;
            this.hauteur = hauteur;
            this.rayon = rayon;
            this.momentQuadratique = momentQuadratique;
            this.charge = charge;
            this.moduleYoung = moduleYoung;
        }

        // Définition des fonctions de calcul des flèches max et associée pour une section circulaire
        public double CalculFlecheMaxCirculaire()
        {
            return (Math.PI * rayon * rayon * longueur*longueur*longueur) / (3 * momentQuadratique);
        }

        public double CalculFlecheAssocieeCirculaire()
        {
            return (charge * longueur * longueur * longueur) / (3 * moduleYoung * momentQuadratique);
        }

        // Définition des fonctions de calcul des flèches max et associée pour une section rectangulaire
        public double CalculFlecheMaxRectangulaire()
        {
            return (largeur* hauteur * longueur * longueur * longueur) / (3 * moduleYoung * momentQuadratique);
        }

        public double CalculFlecheAssocieeRectangulaire()
        {
            return (charge * longueur * longueur * longueur) / (3 * moduleYoung * momentQuadratique);
        }

    }
}
