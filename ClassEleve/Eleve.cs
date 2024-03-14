using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassEleve;

namespace ClassEleve
{
    /// <summary>
    /// Classe Eleve
    /// </summary>
    public class Eleve
    {
        // Déclaration des attributs
        private string nom;             // nom de l'eleve
        public string prenom;           // prenom de l'eleve
        private int anneeNaiss;         // annee de naissance de l'eleve
        private string ville;           // ville de l'eleve
        private double nbAbsences;      // nombre de demi-journees d'absence de l'eleve
        private List<double> lesNotes;  

        /// <summary>
        /// Constructeur: initialise les attributs avec les valeurs passées en paramètre. 
        /// Par défaut le nombre d'absences est initialisé à 0 et la liste des notes à une liste vide
        /// </summary>
        public Eleve(string unNom, string unPrenom, int uneAnnee, string uneVille)
        {
            // A COMPLETER
            this.nom = unNom;
            this.prenom = unPrenom;
            this.anneeNaiss = uneAnnee;
            this.ville = uneVille;
            this.nbAbsences = 0;
            this.lesNotes = new List<double>(); // initialisation de la liste des notes de l'eleve
        }
        /// <summary>
        /// Méthode qui calcule et retourne l'age de l'élève
        /// </summary>
        /// <returns>Age de l'élève</returns>
        public int CalculerAge()
        {
            int anneeCourante = DateTime.Now.Year;
            return anneeCourante - this.anneeNaiss;
        }
        /// <summary>
        /// Méthode qui indique si l'élève est majeur (18 ans ou plus) ou non
        /// </summary>
        /// <returns>true si l'élève est majeur ou false dans le cas contraire</returns>
        public bool EtreMajeur()
        {
            // A COMPLETER
            int age = CalculerAge();

            if (age >= 18)
            {
                return true;
            } else
            {
                return false;
            }
        }
        /// <summary>
        /// Méthode qui modifie la ville de l'élève si il déménage
        /// </summary>
        /// <param name="uneVille">Nouvelle ville, de type string</param>
        public void Demenager(string uneVille)
        {
            this.ville = uneVille;
        }
        /// <summary>
        /// Méthode qui permet d'ajouter un nombre de demi-journées d'absences à l'élève
        /// </summary>
        /// <param name="unNombre">nombre de demi-journées d'absence, de type int</param>
        public void AjouterAbsence(int unNombre)
        {
            // A COMPLETER
            this.nbAbsences += unNombre;
        }
        /// <summary>
        /// Méthode qui permet d'ajouter une note à la liste des notes de l'élève,
        /// à condition que cette note soit valide (comprise entre 0 et 20)
        /// </summary>
        /// <param name="uneNote">note ajoutée de type double</param>
        /// <returns>true si la note a été ajoutée ou false dans le cas contraire</returns>
        public bool AjouterNote(double uneNote)
        {
            if (uneNote >= 0 && uneNote <= 20)
            {
                this.lesNotes.Add(uneNote);
                return true;
            } else
            {
                return false;
            }
        }
        /// <summary>
      	/// Méthode qui retourne les informations de l'élève sous la forme d'une chaîne
      	/// </summary>
      	public string ObtenirDescription()
        {
            string valRetour = "FICHE ELEVE \n";
            valRetour += this.nom.ToUpper() + " " + this.prenom + " - " + CalculerAge() + " an(s) - " + this.ville.ToUpper() + "\nAbsences = " + this.nbAbsences + " (1/2 journées)";
            // A completer
            return valRetour;
        }
        /// <summary>
        /// Méthode qui calcule le nombre de notes supérieur à 10
        /// </summary>
        /// <returns>nombre de notes supérieur à 10</returns>
        public int CalculerNb()
        {
            int nb = 0;
            foreach (double note in this.lesNotes)
            {
                if (note < 10)
                    nb++;
            }
            return nb;
        }
        /// <summary>
        /// Méthode qui calcule et retourne la moyenne des notes de l'élève
        /// </summary>
        /// <returns>Moyenne de l'élève</returns>
        public double CalculerMoyenne()
        {
            // A COMPLETER
            double moyenne = 0;
            double somme = 0;
            int nbNote = 0;

            foreach (double note in this.lesNotes)
            {
                somme += note;
                nbNote++;
            }

            moyenne = somme / nbNote;
            return moyenne;
        }
    }
}
