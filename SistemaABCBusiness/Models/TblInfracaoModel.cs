using SistemaABCBusiness.ValueObjects;
using SistemaABCDAO.Entities;
using SistemaABCDAO.Repositories;
using System;
using System.Collections.Generic;

namespace SistemaABCBusiness.Models
{
    public class TblInfracaoModel
    {

        TblInfracaoRepository InfracaoRepository = new TblInfracaoRepository();


        public int? idInfraction { get; set; }
        public string descInfraction { get; set; }
        public string nmInfraction { get; set; }
        public bool isActive { get; set; }
        public EntityState State { get; set; }

        public TblInfracaoModel()
        {
        }

        public TblInfracaoModel(int? idInfraction, string descInfraction, string nmInfraction, bool isActive)
        {
            this.idInfraction = idInfraction;
            this.descInfraction = descInfraction;
            this.nmInfraction = nmInfraction;
            this.isActive = isActive;
        }

        public string saveChange()
        {
            string message = "";

            try
            {
                TblInfracaoDAO tblInfracaoDataRepository = new TblInfracaoDAO();
                {
                    tblInfracaoDataRepository.idInfraction = idInfraction;
                    tblInfracaoDataRepository.nmInfraction = nmInfraction;
                    tblInfracaoDataRepository.descInfraction = descInfraction;
                    tblInfracaoDataRepository.isActive = isActive;
                }

                switch (State)
                {
                    //Execulta reglas comerciais / calculos
                    case EntityState.Add:
                        InfracaoRepository.Add(tblInfracaoDataRepository);
                        message = "Usuário Cadastrado com sucesso!";
                        break;
                    case EntityState.Modified:
                        InfracaoRepository.Edit(tblInfracaoDataRepository);
                        message = "Usuário alterado com sucesso!";
                        break;
                    case EntityState.Delete:
                        InfracaoRepository.Remove((int)idInfraction);
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
        public List<TblInfracaoModel> GetAll()
        {
            try
            {
                var listPecas = new List<TblInfracaoModel>();
                var tblRoleDataModel = InfracaoRepository.GetAll();

                foreach (TblInfracaoDAO item in tblRoleDataModel)
                {
                    listPecas.Add(new TblInfracaoModel
                    {
                        idInfraction = item.idInfraction,
                        descInfraction = item.descInfraction,
                        nmInfraction = item.nmInfraction,
                        isActive = item.isActive
                    });
                }
                return listPecas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TblInfracaoModel> GetSelected(int idInfraction)
        {
            try
            {
                var listTblInfration = new List<TblInfracaoModel>();
                var tblVeiculoDataModel = InfracaoRepository.GetSelected(idInfraction);

                foreach (TblInfracaoDAO item in tblVeiculoDataModel)
                {
                    listTblInfration.Add(new TblInfracaoModel
                    {
                        idInfraction = item.idInfraction,
                        descInfraction = item.descInfraction,
                        nmInfraction = item.nmInfraction,
                        isActive = item.isActive
                    });
                }
                return listTblInfration;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
