﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBus.Model
{
    public class Linija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int PolazisteId { get; set; }
        public int OdredisteId { get; set; }
        public int KorisnikId { get; set; }

        public virtual Korisnici Korisnik { get; set; }
        public virtual Grad Odrediste { get; set; }
        public virtual Grad Polaziste { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
