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
    public class TblMultasModel
    {
        private TblMultasRepository empresaRepository = new TblMultasRepository();

        public long? idFines { get; set; }
        public long? idVehicle { get; set; }
        public int? idInfraction { get; set; }
        public DateTime? dtFines { get; set; }
        public string codeBar { get; set; }
        public long? idCompany { get; set; }
        public float price { get; set; }

        public EntityState State { get; set; }

        public string saveChange()
        {
            string message = "";

            try
            {
                TblMultasDAO tblEmpresaDataRepository = new TblMultasDAO
                {
                    idFines = idFines,
                    codeBar = codeBar,
                    dtFines = dtFines,
                    idInfraction = idInfraction,
                    idVehicle = idVehicle
                };

                switch (State)
                {
                    //Execulta reglas comerciais / calculos
                    case EntityState.Add:
                        empresaRepository.Add(tblEmpresaDataRepository);
                        message = "Usuário Cadastrado com sucesso!";
                        break;
                    case EntityState.Modified:
                        empresaRepository.Edit(tblEmpresaDataRepository);
                        message = "Usuário alterado com sucesso!";
                        break;
                    case EntityState.Delete:
                        empresaRepository.Remove((int)idFines);
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

        public List<TblMultasModel> GetAll()
        {

            var listTblMultas = new List<TblMultasModel>();
            var tblEmpresaDataRepository = empresaRepository.GetAll();

            foreach (TblMultasDAO item in tblEmpresaDataRepository)
            {
                listTblMultas.Add(new TblMultasModel
                {
                    idFines = item.idFines,
                    idInfraction = item.idInfraction,
                    codeBar = item.codeBar,
                    dtFines = item.dtFines,
                    idVehicle = item.idVehicle,
                    idCompany = item.idCompany,
                    price = item.price
                });
            }

            return listTblMultas;
        }

        public List<TblMultasModel> GetSelectAll(long idFines)
        {

            var listTblEmpresa = new List<TblMultasModel>();
            var tblEmpresaDataRepository = empresaRepository.GetSelectedAll(idFines.ToString());

            foreach (TblMultasDAO item in tblEmpresaDataRepository)
            {
                listTblEmpresa.Add(new TblMultasModel
                {
                    idFines = item.idFines,
                    idInfraction = item.idInfraction,
                    codeBar = item.codeBar,
                    dtFines = item.dtFines,
                    idVehicle = item.idVehicle,
                    idCompany = item.idCompany,
                    price = item.price
                });
            }

            return listTblEmpresa;
        }
    }
}
