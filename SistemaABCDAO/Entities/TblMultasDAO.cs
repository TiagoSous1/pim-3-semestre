using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCDAO.Entities
{
    public class TblMultasDAO
    {

        /*
         
            ID_FINES	bigint
            ID_VEHICLE	bigint
            ID_INFRACTION	int
            ID_COMPANY	bigint
            DT_FINES	datetime
            PRICE	numeric
            CODE_BAR	varchar 

         */

        public long? idFines { get; set; }
        public long? idVehicle { get; set; }
        public int? idInfraction { get; set; }
        public DateTime? dtFines { get; set; }
        public string codeBar { get; set; }

        public TblMultasDAO()
        {
        }

        public TblMultasDAO(long? idFines, long? idVehicle, int? idInfraction, DateTime? dtFines, string codeBar)
        {
            this.idFines = idFines;
            this.idVehicle = idVehicle;
            this.idInfraction = idInfraction;
            this.dtFines = dtFines;
            this.codeBar = codeBar;
        }
    }
}
