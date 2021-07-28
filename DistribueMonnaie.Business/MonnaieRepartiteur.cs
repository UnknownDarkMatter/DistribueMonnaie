using DistribueMonnaie.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribueMonnaie.Business
{
    public class MonnaieRepartiteur
    {
        public List<IMonnaie> RépartitMontant(int montantARepartir)
        {
            List<IMonnaie> resultat = new List<IMonnaie>();
            var bourse = new BourseCollection();
            var monnaies = bourse.GetMonnaies().OrderByDescending(m => m.Montant);

            while (montantARepartir > 0)
            {
                IMonnaie currentMonnaie = null;
                foreach(var monnaie in monnaies)
                {
                    if(montantARepartir - monnaie.Montant >= 0)
                    {
                        currentMonnaie = monnaie;
                        break;
                    }
                }

                resultat.Add(currentMonnaie);
                montantARepartir -= currentMonnaie.Montant;
            }
            return resultat;
        }

        public Dictionary<int, int> RepartieParDivision(int montantARepartir)
        {
            var monnaies = new List<int>() { 50, 20, 10, 5, 2, 1 };
            var repartition = new Dictionary<int, int>();
            int reste = montantARepartir;
            foreach (var monnaie in monnaies)
            {
                int diviseurEntier = reste / monnaie;
                if (diviseurEntier > 0)
                {
                    repartition.Add(monnaie, diviseurEntier);
                    reste -= (diviseurEntier * monnaie);
                }
            }
            return repartition;
        }


    }
}
