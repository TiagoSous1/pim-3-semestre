using SistemaABCBusiness.ValueObjects;
using SistemaABCDAO.Entities;
using SistemaABCDAO.Repositories;
using System;
using System.Collections.Generic;

namespace SistemaABCBusiness.Models
{
    public class TblPecasModel
    {

        TblPecasRepository pecasRepository = new TblPecasRepository();

        public long idPiece { get; set; }
        public float price { get; set; }
        public DateTime? dtBuy { get; set; }
        public DateTime? dtStart { get; set; }
        public DateTime? dtFinish { get; set; }
        public string descPiece { get; set; }
        public EntityState State { get; set; }

        public TblPecasModel()
        { 
        }

        public TblPecasModel(float price, DateTime? dtBuy, DateTime? dtStart, DateTime? dtFinish, string descPiece)
        {
            this.price = price;
            this.dtBuy = dtBuy;
            this.dtStart = dtStart;
            this.descPiece = descPiece;
            this.dtFinish = dtFinish;
        }

        public string saveChange()
        {
            string message = "";

            try
            {
                TblPecasDAO tblPecasDataRepository = new TblPecasDAO
                {
                    idPiece = idPiece,
                    dtBuy = dtBuy,
                    dtFinish = dtFinish,
                    dtStart = dtStart,
                    price = price,
                    descPiece = descPiece
                };

                switch (State)
                {
                    //Execulta reglas comerciais / calculos
                    case EntityState.Add:
                        pecasRepository.Add(tblPecasDataRepository);
                        message = "Usuário Cadastrado com sucesso!";
                        break;
                    case EntityState.Modified:
                        pecasRepository.Edit(tblPecasDataRepository);
                        message = "Usuário alterado com sucesso!";
                        break;
                    case EntityState.Delete:
                        pecasRepository.Remove((int)idPiece);
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
        public List<TblPecasModel> GetAll()
        {
            try
            {
                var listPecas = new List<TblPecasModel>();
                var tblRoleDataModel = pecasRepository.GetAll();

                foreach (TblPecasDAO item in tblRoleDataModel)
                {
                    listPecas.Add(new TblPecasModel
                    {
                        idPiece = item.idPiece,
                        dtBuy = item.dtBuy,
                        dtStart = item.dtStart,
                        dtFinish = item.dtFinish,
                        price = item.price,
                        descPiece = item.descPiece                        
                    });
                }
                return listPecas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TblPecasModel> GetSelected(int idPiece)
        {
            try
            {
                var listTblRole = new List<TblPecasModel>();
                var tblRoleDataModel = pecasRepository.GetSelected(idPiece);

                foreach (TblPecasDAO item in tblRoleDataModel)
                {
                    listTblRole.Add(new TblPecasModel
                    {
                        idPiece = item.idPiece,
                        dtBuy = item.dtBuy,
                        dtStart = item.dtStart,
                        dtFinish = item.dtFinish,
                        price = item.price,
                        descPiece = item.descPiece                        
                    });
                }
                return listTblRole;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
