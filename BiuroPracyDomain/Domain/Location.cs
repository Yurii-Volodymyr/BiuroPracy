using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPracyDomain
{
  public class Location
    {
        public virtual int Id { get; set; }
        public virtual string Street { get; set; }
        public virtual string ZipCode { get; set; }
        public virtual  City City { get; set; }
        public virtual Country Country { get; set; }
    }
}
