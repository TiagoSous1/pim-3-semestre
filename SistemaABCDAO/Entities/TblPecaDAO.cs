using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCDAO.Entities
{
    public class TblPecaDAO
    {
        /*
         
            ID_PIECE	bigint
            PRICE	numeric
            DESC_PIECE	varchar
            DT_BUY	datetime
            DT_START	datetime
            DT_FINISH	datetime
         
         */


        public long idPiece { get; set; }
        public float price { get; set; }
        public DateTime? dtBuy { get; set; }
        public DateTime? DtStart { get; set; }
        public DateTime? dtFinish { get; set; }

        public TblPecaDAO()
        {
        }

        public TblPecaDAO(long idPiece, float price, DateTime? dtBuy, DateTime? dtStart, DateTime? dtFinish)
        {
            this.idPiece = idPiece;
            this.price = price;
            this.dtBuy = dtBuy;
            DtStart = dtStart;
            this.dtFinish = dtFinish;
        }
    }
}
