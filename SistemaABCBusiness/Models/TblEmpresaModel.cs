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
    public class TblEmpresaModel
    {

        private TblEmpresaRepository empresaRepository = new TblEmpresaRepository();
        public long? idCompany { get; set; }
        public string nmCompany { get; set; }
        public string nuRegistration { get; set; }
        public string state { get; set; }
        public EntityState State { get; set; }
        public int? idAddress { get; set; }
        public long? tel { get; set; }

        public TblEmpresaModel()
        {
        }
        public TblEmpresaModel(string nmCompany, string nuRegistration, string state, int? idAddress, long? tel)
        {
            this.nmCompany = nmCompany;
            this.nuRegistration = nuRegistration;
            this.state = state;
            this.idAddress = idAddress;
            this.tel = tel;
        }

        public string saveChange()
        {
            string message = "";

            try
            {
                TblEmpresaDAO tblEmpresaDataRepository = new TblEmpresaDAO
                {
                    idCompany = idCompany,
                    nmCompany = nmCompany,
                    nuRegistration = nuRegistration,
                    state = state,
                    tel = tel,
                    idAddress = idAddress,
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
                        empresaRepository.Remove((int)idAddress);
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

        public List<TblEmpresaModel> GetAll()
        {

            var listTblEmpresa = new List<TblEmpresaModel>();
            var tblEmpresaDataRepository = empresaRepository.GetAll();

            foreach (TblEmpresaDAO item in tblEmpresaDataRepository)
            {
                listTblEmpresa.Add(new TblEmpresaModel
                {
                     idCompany = item.idCompany,
                     nmCompany = item.nmCompany,
                     nuRegistration = item.nuRegistration,
                     state = item.state,
                     tel = item.tel,
                     idAddress = item.idAddress
                     
                });
            }

            return listTblEmpresa;
        }

        public List<TblEmpresaModel> GetSelectAll(long idCompany)
        {

            var listTblEmpresa = new List<TblEmpresaModel>();
            var tblEmpresaDataRepository = empresaRepository.GetSelectAll(idCompany);

            foreach (TblEmpresaDAO item in tblEmpresaDataRepository)
            {
                listTblEmpresa.Add(new TblEmpresaModel
                {
                    idCompany = item.idCompany,
                    nmCompany = item.nmCompany,
                    nuRegistration = item.nuRegistration,
                    state = item.state,
                    tel = item.tel,
                    idAddress = item.idAddress

                });
            }

            return listTblEmpresa;
        }
    }
}
