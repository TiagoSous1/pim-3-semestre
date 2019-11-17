using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCDAO.Entities
{
    public class TblAbastecimentoDAO
    {

        /**
         * 
         * ID_SUPPLY	bigint
         * COD_INVOICE	bigint
         * ID_VEHICLE	bigint
         * ID_COMPANY	bigint
         * DT_SUPPLY	datetime
         * PRICE	numeric
         * 
         * */


        public long? idSupply { get; set; }
        public long? codInvoice { get; set; }
        public long? idVehicle { get; set; }
        public long? idCompany { get; set; }
        public DateTime? dtSupply { get; set; }
        public float price { get; set; }

        public TblAbastecimentoDAO()
        {
        }

        public TblAbastecimentoDAO(long? idSupply, long? codInvoice, long? idVehicle, long? idCompany, DateTime? dtSupply, float price)
        {
            this.idSupply = idSupply;
            this.codInvoice = codInvoice;
            this.idVehicle = idVehicle;
            this.idCompany = idCompany;
            this.dtSupply = dtSupply;
            this.price = price;
        }

    }
}
