using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCDAO.Entities
{
    public class TblSinistroDAO
    {
        /*
         
        ID_SINISTER	bigint
        ID_VEHICLE	bigint
        DT_DAY	datetime
        ID_COMPANY	bigint
        DESC_SINISTER	varchar         

         */

        public long? idSinister { get; set; }
        public long? idVehicle { get; set; }
        public DateTime? dtDay { get; set; }
        public long? idCompany { get; set; }
        public string descSinister { get; set; }

        public TblSinistroDAO()
        {
        }

        public TblSinistroDAO(long? idSinister, long? idVehicle, DateTime? dtDay, long? idCompany, string descSinister)
        {
            this.idSinister = idSinister;
            this.idVehicle = idVehicle;
            this.dtDay = dtDay;
            this.idCompany = idCompany;
            this.descSinister = descSinister;
        }
    }
}
