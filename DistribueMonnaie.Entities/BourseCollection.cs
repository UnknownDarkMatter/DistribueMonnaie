using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribueMonnaie.Entities
{
    public class BourseCollection
    {
        public List<IMonnaie> GetMonnaies()
        {
            return new List<IMonnaie>()
            {
                new Billet(){ Montant = 5 },
                new Billet(){ Montant = 10 },
                new Billet(){ Montant = 20 },
                new Billet(){ Montant = 50 },
                new Piece(){ Montant = 2 },
                new Piece(){ Montant = 1 },
            };
        }
    }
}
