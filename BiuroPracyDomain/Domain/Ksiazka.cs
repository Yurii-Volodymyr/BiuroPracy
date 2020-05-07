using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPracyDomain
{
   public class Ksiazka
    {
        public virtual int Id { get; set; }
        public virtual string Tytul { get; set; }
        public virtual string Opis { get; set; }
    }
}
