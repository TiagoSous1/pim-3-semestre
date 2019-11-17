using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCDAO.Entities
{
    public class TblRoleDAO
    {
        public int? idRole { get; set; }
        public string nmRole { get; set; }
        public bool isActive { get; set; }

        public TblRoleDAO()
        {
        }

        public TblRoleDAO(int? idRole, string nmRole, bool isActive)
        {
            this.idRole = idRole;
            this.nmRole = nmRole;
            this.isActive = isActive;
        }
    }
}
