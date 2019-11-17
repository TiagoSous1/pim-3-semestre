using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCDAO.Entities
{
    public class TblEnderecoDAO
    {

        public int? idAddress { get; set; }
        public string street { get; set; }
        public int? number { get; set; }
        public string codeZip { get; set; }
        public string neighborhood { get; set; }
        public string city { get; set; }
        public string nmState { get; set; }

        public TblEnderecoDAO()
        {
        }

        public TblEnderecoDAO(int? idAddress, string street, int? number, string codeZip, string neighborhood, string city, string nmState)
        {
            this.idAddress = idAddress;
            this.street = street;
            this.number = number;
            this.codeZip = codeZip;
            this.neighborhood = neighborhood;
            this.city = city;
            this.nmState = nmState;
        }
    }
}
