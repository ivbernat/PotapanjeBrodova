using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class KružniPucač : IPucač
    {
        public KružniPucač(Polje prvoPogođeno, Mreža mreža)
        {
            this.prvoPogođeno = prvoPogođeno;
            this.mreža = mreža;
        }

        public Polje UputiPucanj()
        {
            throw new NotImplementedException();
        }

        Polje prvoPogođeno;
        Mreža mreža;
    }
}
