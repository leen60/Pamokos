﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SyntaxTest.Exercises
{
    public class Exercise11
    {
        /*
          Parašykite viešą metodą pavadinimu WhoCanDriveATractor, kuris grąžina string tipo sąrašo rezultatą. Įsidėmėkite, kad sąrašas yra aprašomas kitaip nei masyvas.
          Metodas turi priimti vieną  WhoCanDriveATractor tipo masyvo elementą pavadinimu licences.
          DrivingLicence tipas yra klasė, kuri dar neegzistuoja, jūs turite ją parašyti šalia šiame faile.
        */
        public List<string> WhoCanDriveATractor(DrivingLicence[] licences)
        {
           return licences.Where(x => x.kategorija == "C").Select(x=>x.name).ToList();
        }

    }
    public class DrivingLicence
    {
        public string name;
        public string kategorija;
    }
}