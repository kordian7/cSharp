using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wypozyczalnia {
    abstract class KlientState {
        public abstract int liczPunkty(Wypozyczenie wyp);
    }
}
