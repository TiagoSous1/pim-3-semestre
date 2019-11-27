using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCDAO.Entities
{
    public class TblEmpresaDAO
    {
        public long? idCompany { get; set; }
        public string nmCompany { get; set; }
        public string nuRegistration { get; set; }
        public string state { get; set; }
        public int? idAddress { get; set; }
        public long? tel { get; set; }

        public TblEmpresaDAO()
        {
        }

        public TblEmpresaDAO(long? idCompany, string nmCompany, string nuRegistration, string state, int? idAddress, long? tel)
        {
            this.idCompany = idCompany;
            this.nmCompany = nmCompany;
            this.nuRegistration = nuRegistration;
            this.state = state;
            this.idAddress = idAddress;
            this.tel = tel;
        }
    }
}
