using SistemaABCBusiness.ValueObjects;
using SistemaABCDAO.Entities;
using SistemaABCDAO.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCBusiness.Models
{
    public class TblAbastecimentoModel
    {

        private TblAbastecimentoRepository abastecimentoRepository = new TblAbastecimentoRepository();

        public long? idSupply { get; set; }
        public long? codInvoice { get; set; }
        public long? idVehicle { get; set; }
        public long? idCompany { get; set; }
        public DateTime? dtSupply { get; set; }
        public float price { get; set; }
        public EntityState State { get; set; }

        public TblAbastecimentoModel()
        {
        }

        public TblAbastecimentoModel(long? idSupply, long? codInvoice, long? idVehicle, long? idCompany, DateTime? dtSupply, float price)
        {
            this.idSupply = idSupply;
            this.codInvoice = codInvoice;
            this.idVehicle = idVehicle;
            this.idCompany = idCompany;
            this.dtSupply = dtSupply;
            this.price = price;
        }

        public string saveChange()
        {
            string message = "";

            try
            {
                TblAbastecimentoDAO tblAbastecimentoDataRepository = new TblAbastecimentoDAO
                {
                    idSupply = idSupply,
                    idVehicle = idVehicle,
                    codInvoice = codInvoice,
                    dtSupply = dtSupply,
                    idCompany = idCompany,
                    price    = price
                };

                switch (State)
                {
                    //Execulta reglas comerciais / calculos
                    case EntityState.Add:
                        abastecimentoRepository.Add(tblAbastecimentoDataRepository);
                        message = "Usuário Cadastrado com sucesso!";
                        break;
                    case EntityState.Modified:
                        abastecimentoRepository.Edit(tblAbastecimentoDataRepository);
                        message = "Usuário alterado com sucesso!";
                        break;
                    case EntityState.Delete:
                        abastecimentoRepository.Remove((int)idSupply);
                        message = "Usuário removido com sucesso!";
                        break;
                }

                return message;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<TblAbastecimentoModel> GetAll()
        {

            var listTblAbastecimento = new List<TblAbastecimentoModel>();
            var tblEmpresaDataRepository = abastecimentoRepository.GetAll();

            foreach (TblAbastecimentoDAO item in tblEmpresaDataRepository)
            {
                listTblAbastecimento.Add(new TblAbastecimentoModel
                {
                    idSupply = item.idSupply,
                    idVehicle = item.idVehicle,
                    codInvoice = item.codInvoice,
                    dtSupply = item.dtSupply,
                    idCompany = item.idCompany,
                    price = item.price
                });
            }

            return listTblAbastecimento;
        }

        public List<TblAbastecimentoModel> GetSelectAll(long idSupply)
        {
            var listTblAbastecimento = new List<TblAbastecimentoModel>();
            var tblAbastecimentoDataRepository = abastecimentoRepository.GetSelected((int)idSupply);

            foreach (TblAbastecimentoDAO item in tblAbastecimentoDataRepository)
            {
                listTblAbastecimento.Add(new TblAbastecimentoModel
                {
                    idSupply = item.idSupply,
                    idVehicle = item.idVehicle,
                    codInvoice = item.codInvoice,
                    dtSupply = item.dtSupply,
                    idCompany = item.idCompany,
                    price = item.price
                });
            }

            return listTblAbastecimento;
        }
    }
}
