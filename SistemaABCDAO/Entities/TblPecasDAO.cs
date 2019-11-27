using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCDAO.Entities
{
    public class TblPecasDAO
    {
     
        public long idPiece { get; set; }
        public float price { get; set; }
        public DateTime? dtBuy { get; set; }
        public DateTime? dtStart { get; set; }
        public DateTime? dtFinish { get; set; }
        public string descPiece { get; set; }

        public TblPecasDAO()
        {
        }

        public TblPecasDAO(long idPiece, float price, DateTime? dtBuy, DateTime? dtStart, DateTime? dtFinish, string descPiece)
        {
            this.idPiece = idPiece;
            this.price = price;
            this.dtBuy = dtBuy;
            this.dtStart = dtStart;
            this.dtFinish = dtFinish;
            this.descPiece = descPiece;
        }
    }
}
