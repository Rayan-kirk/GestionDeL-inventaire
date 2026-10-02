using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double poidsTotal = 0;
        int nbLourds = 0;
        int nbLegers = 0;

        Console.Write("Combien d'objets voulez-vous stocker dans votre sac ? ");
        int nbObjets = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nbObjets; i++)
        {
            Console.Write($"Poids de l'objet {i} (en kg) : ");
            double poids = double.Parse(Console.ReadLine().Replace('.', ','),
                                        new CultureInfo("fr-FR"));

            poidsTotal += poids;

            if (poids > 5)
                nbLourds++;
            else
                nbLegers++;
        }

        Console.WriteLine();
        Console.WriteLine($"Poids total : {poidsTotal:F2} kg");
        Console.WriteLine($"Objets lourds (> 5 kg) : {nbLourds}");
        Console.WriteLine($"Objets légers (<= 5 kg) : {nbLegers}");

        if (poidsTotal > 30)
            Console.WriteLine("[SURCHARGE] Votre sac est trop lourd, vous ne pouvez pas courir !");
        else
            Console.WriteLine("[OK] Votre inventaire est prêt pour l'aventure !");
    }
}