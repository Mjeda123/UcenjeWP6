﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17KlasaObjekt.ZavrsniRad
{
    public class Dvorana
    {
        public int Sifra { get; set; }
        public string Naziv { get; set; } = "";

        public string NazivDvorane()
        {
            return Naziv;
        }
    }
}
