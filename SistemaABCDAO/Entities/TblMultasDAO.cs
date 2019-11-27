using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCDAO.Entities
{
    public class TblMultasDAO
    {
        public long? idFines { get; set; }
        public long? idVehicle { get; set; }
        public int? idInfraction { get; set; }
        public long? idCompany { get; set; }
        public DateTime? dtFines { get; set; }
        public float price { get; set; }
        public string codeBar { get; set; }

        public TblMultasDAO()
        {
        }

        public TblMultasDAO(long? idFines, long? idVehicle, int? idInfraction, long? idCompany, DateTime? dtFines, string codeBar, float price)
        {
            this.idFines = idFines;
            this.idVehicle = idVehicle;
            this.idInfraction = idInfraction;
            this.idCompany = idCompany;
            this.dtFines = dtFines;
            this.codeBar = codeBar;
            this.price = price;
        }
    }
}
