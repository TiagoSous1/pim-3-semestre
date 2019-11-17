using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCDAO.Entities
{
    public class TblAluguelDAO
    {
        /**
         * ID_RENTAL	bigint
           ID_VEHICLE	bigint
           ID_COMPANY	bigint
           DT_START	datetime
           DT_FINISH	datetime
         */

        public long? idRental { get; set; }
        public long? idVehicle { get; set; }
        public long? idCompany { get; set; }
        public DateTime? dtStart { get; set; }
        public DateTime? dtFinish { get; set; }

        public TblAluguelDAO()
        {
        }

        public TblAluguelDAO(long? idRental, long? idVehicle, long? idCompany, DateTime? dtStart, DateTime? dtFinish)
        {
            this.idRental = idRental;
            this.idVehicle = idVehicle;
            this.idCompany = idCompany;
            this.dtStart = dtStart;
            this.dtFinish = dtFinish;
        }
    }
}
