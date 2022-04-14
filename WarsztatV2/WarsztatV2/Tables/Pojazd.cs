﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WarsztatV2.Tables
{
    internal class Pojazd
    {
        public Pojazd()
        {
            //KlientNav = new Klient();
            NaprawaNav = new List<Naprawa>();
        }

        [Key]
        public string Numer_rejestracyjny { get; set; }
        public int ID_Klient { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Numer_VIN { get; set; }
        public int Rok_produkcji { get; set; }
        public string Typ_paliwa { get; set; }
        public virtual Klient KlientNav { get; set; }
        public virtual ICollection<Naprawa> NaprawaNav { get; set; }
    }
}
