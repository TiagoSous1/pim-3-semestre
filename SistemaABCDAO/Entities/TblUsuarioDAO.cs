using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCDAO.Entities
{
    public class TblUsuarioDAO
    {
        /*

        ID_USER	bigint
        DE_LOGIN	varchar
        NM_USER	varchar
        NU_REGISTRATION	varchar
        RG_REGISTRATION	varchar
        CNH_REGISTRATION	varchar
        DE_PASSWORD	varchar
        DE_EMAIL	varchar
        ID_ROLE	int
        ID_ADDRESS	int
        IS_ACTIVE	bit

         */

        public long? idUser { get; set; }
        public string deLogin { get; set; }
        public string nmUser { get; set; }
        public string nuRegistration { get; set; }
        public string rgRegistration { get; set; }
        public string cnhRegistration { get; set; }
        public string dePassword { get; set; }
        public string deEmail { get; set; }
        public int? idRole { get; set; }
        public int? idAddress { get; set; }
        public bool isActive { get; set; }

        public TblUsuarioDAO()
        {
        }

        public TblUsuarioDAO(long? idUser, string deLogin, string nmUser, string nuRegistration, string rgRegistration, string cnhRegistration, string dePassword, string deEmail, int? idRole, int? idAddress, bool isActive)
        {
            this.idUser = idUser;
            this.deLogin = deLogin;
            this.nmUser = nmUser;
            this.nuRegistration = nuRegistration;
            this.rgRegistration = rgRegistration;
            this.cnhRegistration = cnhRegistration;
            this.dePassword = dePassword;
            this.deEmail = deEmail;
            this.idRole = idRole;
            this.idAddress = idAddress;
            this.isActive = isActive;
        }
    }
}
