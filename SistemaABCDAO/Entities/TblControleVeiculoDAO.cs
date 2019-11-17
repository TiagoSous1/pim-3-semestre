using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCDAO.Entities
{
    public class TblControleVeiculoDAO
    {
        /*
         * ID_CONTROL_VEHICLE	bigint
            ID_USER	bigint
            ID_VEHICLE	bigint
            ID_COMPANY	bigint
            DT_START	datetime
            DT_FINISH	datetime
         *
         */


        public long? idControlVehicle { get; set; }
        public long? idUser { get; set; }
        public long? idVehicle { get; set; }
        public long? idCompany { get; set; }
        public DateTime? dtStart { get; set; }
        public DateTime? dtFinish { get; set; }

        public TblControleVeiculoDAO()
        {
        }

        public TblControleVeiculoDAO(long? idControlVehicle, long? idUser, long? idVehicle, long? idCompany, DateTime? dtStart, DateTime? dtFinish)
        {
            this.idControlVehicle = idControlVehicle;
            this.idUser = idUser;
            this.idVehicle = idVehicle;
            this.idCompany = idCompany;
            this.dtStart = dtStart;
            this.dtFinish = dtFinish;
        }
    }
}
