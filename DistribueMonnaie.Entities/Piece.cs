using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistribueMonnaie.Entities
{
    public class Piece : IMonnaie
    {
        public int Montant { get; set; }
    }
}
