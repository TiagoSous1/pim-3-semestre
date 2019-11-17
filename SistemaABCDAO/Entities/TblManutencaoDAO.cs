using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCDAO.Entities
{
    public class TblManutencaoDAO
    {
        /*
         *
         * 
         *  ID_MAINTENANCE	bigint
            ID_VEHICLE	bigint
            ID_PIECE	bigint
            DT_MAINTENANCE	datetime
            PRICE	numeric
            ID_COMPANY	bigint
            DESC_MANUTENCAO	varchar
            DT_MAINTENANCE_SCHEDULED	datetime
         *
         */

        public long? idMaintenance { get; set; }
        public long? idVehicle { get; set; }
        public long? idPiece { get; set; }
        public DateTime? dtMaintenance { get; set; }
        public float price { get; set; }
        public long? idCompany { get; set; }
        public string descMaintenance { get; set; }
        public DateTime? dtMaintenanceScheduled { get; set; }

        public TblManutencaoDAO()
        {
        }

        public TblManutencaoDAO(long? idMaintenance, long? idVehicle, long? idPiece, DateTime? dtMaintenance, float price, long? idCompany, string descMaintenance, DateTime? dtMaintenanceScheduled)
        {
            this.idMaintenance = idMaintenance;
            this.idVehicle = idVehicle;
            this.idPiece = idPiece;
            this.dtMaintenance = dtMaintenance;
            this.price = price;
            this.idCompany = idCompany;
            this.descMaintenance = descMaintenance;
            this.dtMaintenanceScheduled = dtMaintenanceScheduled;
        }
    }
}
