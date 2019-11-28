using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCDAO.Entities
{
    public class TblVeiculoDAO
    {

        public long? idVehicle { get; set; }
        public string descVehicle { get; set; }
        public string board { get; set; }
        public long? idCompany { get; set; }
        public int? kilometro { get; set; }
        public int? year { get; set; }

        public TblVeiculoDAO()
        {
        }

        public TblVeiculoDAO(long? idVehicle, string descVehicle, string board, long? idCompany, int? kilometro, int? year)
        {
            this.idVehicle = idVehicle;
            this.descVehicle = descVehicle;
            this.board = board;
            this.idCompany = idCompany;
            this.kilometro = kilometro;
            this.year = year;
        }
    }
}
