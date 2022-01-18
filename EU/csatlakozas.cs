using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU
{
    class csatlakozas
    {
        public string orsz { get; set; }
        public DateTime datum { get; set; }

        public csatlakozas(string sor)
        {
            string []db = sor.Split(';');
            orsz = db[0];
            datum = DateTime.Parse(db[1]);
        }
    }
}
