using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCDAO.Entities
{
    public class TblInfracaoDAO
    {

        public int? idInfraction { get; set; }
        public string descInfraction { get; set; }
        public string nmInfraction { get; set; }
        public bool isActive { get; set; }

        public TblInfracaoDAO()
        {
        }

        public TblInfracaoDAO(int? idInfraction, string descInfraction, bool isActive,string nmInfraction)
        {
            this.idInfraction = idInfraction;
            this.descInfraction = descInfraction;
            this.isActive = isActive;
            this.nmInfraction = nmInfraction;
        }
    }
}
