using System;
using System.Collections.Generic;
namespace RNetApp
{
    public static class ConvertClasse
    {
        private static string[] jusqueSeize = { "zéro", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze", "treize", "quatorze", "quinze", "seize" };

        private static string[] dizaines = { "rien", "dix", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante", "quatre-vingt", "quatre-vingt" };

        private static List<string> resultat;

        /// <summary>
        /// Méthode d'extension de la classe double écrivant le nombre en lettres
        /// </summary>
        /// <param name="Nombre">Nombre à écrire</param>
        /// <param name="LePays">Pays d'utilisation, pour spécificitées régionnales</param>
        /// <param name="LaDevise">Devise à utliser</param>
        /// <returns></returns>
        public static string ToLettres(this double Nombre, Pays LePays = Pays.France, Devise LaDevise = Devise.Dirham)
        {

            resultat = new List<string>();

            switch (Math.Sign(Nombre))
            {
                case -1:
                    resultat.Add("moins ");
                    Nombre *= -1;
                    break;

                case 0:
                    return jusqueSeize[0];
            }

            if (Nombre >= 1e16)
                return "Nombre trop grand";


            Int64 partieEntiere = (Int64)(Nombre);
            double partieDecimale = Nombre - partieEntiere;

            string[] milliers = { "", "mille", "million", "milliard", "billion", "billiard" };

            if (partieEntiere > 0)
            {
                List<int> troisChiffres = new List<int>();//liste qui scinde la partie entière en morceaux de 3 chiffres

                while (partieEntiere > 0)
                {
                    troisChiffres.Add((int)(partieEntiere % 1000));
                    partieEntiere /= 1000;
                }

                double reste = Nombre - partieEntiere;



                for (int i = troisChiffres.Count - 1; i >= 0; i--)
                {
                    int nombre = troisChiffres[i];

                    if (nombre > 1)//valeurs de milliers au pluriel
                    {
                        resultat.Add(Ecrit3Chiffres(troisChiffres[i], LePays, i == 0));
                        if (i > 1)// mille est invariable et "" ne prend pas de s 
                            resultat.Add(milliers[i] + "s");
                        else if (i == 1)
                            resultat.Add(milliers[i]);
                    }
                    else if (nombre == 1)
                    {
                        if (i != 1) resultat.Add("un");//on dit un million, mais pas un mille
                        resultat.Add(milliers[i]);
                    }
                    //on ne traite pas le 0, car on ne dit pas X millions zéro mille Y.
                }
            }
            else
                resultat.Add(jusqueSeize[0]);

            switch (LaDevise)
            {
                case Devise.Dollar:
                    resultat.Add("$");
                    break;

                case Devise.Euro:
                    resultat.Add("€");
                    break;

                case Devise.FrancSuisse:
                    resultat.Add("CHF");
                    break;
                case Devise.Dirham:
                     resultat.Add("MAD");
                    break;

            }

            if (LaDevise != Devise.Aucune)
            {
                partieDecimale = Math.Round(partieDecimale, 2);
                if (partieDecimale != 0)
                {
                    resultat.Add("et");
                    resultat.Add(Ecrire2Chiffres((int)(partieDecimale * 100), LePays));
                    resultat.Add("centimes");
                }
            }
            return string.Join(" ", resultat);
        }

        /// <summary>
        /// Ecrit les nombres de 0 à 999
        /// </summary>
        /// <param name="Nombre">Nombre à écrire</param>
        /// <param name="LePays">Pays d'utilisation, pour spécificitées régionnales</param>
        /// <param name="RegleDuCent">pour 400 cent prend un s alors que pour 400 000 ou 0.400 non </param>
        private static string Ecrit3Chiffres(int Nombre, Pays LePays, bool RegleDuCent)
        {
            if (Nombre == 100)
                return "cent";

            if (Nombre < 100)
                return Ecrire2Chiffres(Nombre, LePays);

            int centaine = Nombre / 100;
            int reste = Nombre % 100;

            if (reste == 0)
                if (RegleDuCent)//Cent prend un s quand il est multiplié et non suivi d'un nombre, comme le cas de 100 est déjà traité on est face à un multiple
                    return jusqueSeize[centaine] + " cents";
                else
                    return jusqueSeize[centaine] + " cent";// par contre s'il est suivi de mille, millions, millièmes etc... pas de s

            if (centaine == 1)
                return "cent " + Ecrire2Chiffres(reste, LePays);//on ne dit pas un cent X, mais cent X

            return jusqueSeize[centaine] + " cent " + Ecrire2Chiffres(reste, LePays);
        }

        /// <summary>
        /// Ecrit les nombres de 0 à 99
        /// </summary>
        /// <param name="Nombre">Nombre à écrire</param>
        /// <param name="LePays">Pays d'utilisation, pour spécificitées régionnales</param>
        /// <returns></returns>
        private static string Ecrire2Chiffres(int Nombre, Pays LePays)
        {
            if (LePays != Pays.France)
            {
                dizaines[7] = "septante";
                dizaines[9] = "nonante";
            }
            if (LePays == Pays.Suisse)
                dizaines[8] = "huitante";

            if (Nombre < 17)
                return jusqueSeize[Nombre];

            switch (Nombre)//cas particuliers de 71, 80 et 81
            {
                case 71://en France 71 prend un et
                    if (LePays == Pays.France)
                        return "soixante et onze";
                    break;

                case 80://en France et Belgique le vingt prend un s
                    if (LePays == Pays.Suisse)
                        return dizaines[8];
                    else
                        return dizaines[8] + "s";

                case 81://en France et Belgique il n'y a pas de et
                    if (LePays != Pays.Suisse)
                        return dizaines[8] + "-un";
                    break;
            }


            int dizaine = Nombre / 10;
            int unite = Nombre % 10;

            string laDizaine = dizaines[dizaine];

            if (LePays == Pays.France && (dizaine == 7 || dizaine == 9))
            {
                dizaine--;
                unite += 10;
            }


            switch (unite)
            {
                case 0:
                    return laDizaine;

                case 1:
                    return laDizaine + " et un";

                case 17://pour 77 à 79 et 97 à 99
                case 18:
                case 19:
                    unite = unite % 10;
                    return laDizaine + "-dix-" + jusqueSeize[unite];

                default:
                    return laDizaine + "-" + jusqueSeize[unite];
            }
        }
    }

    public enum Pays
    {
        France,
        Belgique,
        Suisse
    }

    public enum Devise
    {
        Aucune,
        Euro,
        FrancSuisse,
        Dollar,
        Dirham
    }
}