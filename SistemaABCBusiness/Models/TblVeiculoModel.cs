using SistemaABCBusiness.ValueObjects;
using SistemaABCDAO.Entities;
using SistemaABCDAO.Repositories;
using System;
using System.Collections.Generic;

namespace SistemaABCBusiness.Models
{
    public class TblVeiculoModel
    {

        TblVeiculoRepository veiculoRepository = new TblVeiculoRepository();

        public long? idVehicle { get; set; }
        public string descVehicle { get; set; }
        public string board { get; set; }
        public long? idCompany { get; set; }
        public int? kilometro { get; set; }
        public int? year { get; set; }

        public EntityState State { get; set; }

        public TblVeiculoModel()
        {
        }
        public TblVeiculoModel(long? idVehicle, string descVehicle, string board, long? idCompany, int? kilometro, int? year)
        {
            this.idVehicle = idVehicle;
            this.descVehicle = descVehicle;
            this.board = board;
            this.idCompany = idCompany;
            this.kilometro = kilometro;
            this.year = year;
        }

        public string saveChange()
        {
            string message = "";

            try
            {
                TblVeiculoDAO tblVeiculoDataRepository = new TblVeiculoDAO();
                {
                    tblVeiculoDataRepository.idVehicle = idVehicle;
                    tblVeiculoDataRepository.descVehicle = descVehicle;
                    tblVeiculoDataRepository.board = board;
                    tblVeiculoDataRepository.idCompany = idCompany;
                    tblVeiculoDataRepository.kilometro = kilometro;
                    tblVeiculoDataRepository.year = year;
                }

                switch (State)
                {
                    //Execulta reglas comerciais / calculos
                    case EntityState.Add:
                        veiculoRepository.Add(tblVeiculoDataRepository);
                        message = "Usuário Cadastrado com sucesso!";
                        break;
                    case EntityState.Modified:
                        veiculoRepository.Edit(tblVeiculoDataRepository);
                        message = "Usuário alterado com sucesso!";
                        break;
                    case EntityState.Delete:
                        veiculoRepository.Remove((int)idVehicle);
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
        public List<TblVeiculoModel> GetAll()
        {
            try
            {
                var listPecas = new List<TblVeiculoModel>();
                var tblRoleDataModel = veiculoRepository.GetAll();

                foreach (TblVeiculoDAO item in tblRoleDataModel)
                {
                    listPecas.Add(new TblVeiculoModel
                    {
                        idVehicle = item.idVehicle,
                        descVehicle = item.descVehicle,
                        board = item.board,
                        idCompany = item.idCompany,
                        kilometro = item.kilometro,
                        year = item.year
                    });
                }
                return listPecas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TblVeiculoModel> GetSelected(int idVehicle)
        {
            try
            {
                var listTblRole = new List<TblVeiculoModel>();
                var tblVeiculoDataModel = veiculoRepository.GetSelected(idVehicle);

                foreach (TblVeiculoDAO item in tblVeiculoDataModel)
                {
                    listTblRole.Add(new TblVeiculoModel
                    {
                        idVehicle = item.idVehicle,
                        descVehicle = item.descVehicle,
                        board = item.board,
                        idCompany = item.idCompany,
                        kilometro = item.kilometro,
                        year = item.year
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
