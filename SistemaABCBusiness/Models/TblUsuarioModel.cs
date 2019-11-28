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
    public class TblUsuarioModel
    {
        private TblUsuarioRepository tblUsuarioRepository = new TblUsuarioRepository();
        public long? idUser { get; set; }
        public string deLogin { get; set; }
        public string nmUser { get; set; }
        public string nuRegistration { get; set; }
        public string rgRegistration { get; set; }
        public string cnhRegistration { get; set; }
        public string dePassword { get; set; }
        public string deEmail { get; set; }
        public EntityRole? idRole { get; set; }
        public int? idAddress { get; set; }
        public bool isActive { get; set; }
        public EntityState State { get; set; }

        public TblUsuarioModel()
        {
        }

        public TblUsuarioModel(long? idUser, string deLogin, string nmUser, string nuRegistration, string rgRegistration, string cnhRegistration, string dePassword, string deEmail, EntityRole? idRole, int? idAddress, bool isActive)
        {
            this.idUser = idUser;
            this.deLogin = deLogin;
            this.nmUser = nmUser;
            this.nuRegistration = nuRegistration;
            this.rgRegistration = rgRegistration;
            this.cnhRegistration = cnhRegistration;
            this.dePassword = dePassword;
            this.deEmail = deEmail;
            this.idRole = idRole;
            this.idAddress = idAddress;
            this.isActive = isActive;
        }

        public TblUsuarioModel(string deLogin, string nmUser, string nuRegistration, string rgRegistration, string cnhRegistration, string dePassword, string deEmail, EntityRole? idRole, int? idAddress, bool isActive)
        {    
            this.deLogin = deLogin;
            this.nmUser = nmUser;
            this.nuRegistration = nuRegistration;
            this.rgRegistration = rgRegistration;
            this.cnhRegistration = cnhRegistration;
            this.dePassword = dePassword;
            this.deEmail = deEmail;
            this.idRole = idRole;
            this.idAddress = idAddress;
            this.isActive = isActive;
        }

        public string saveChange()
        {
            string message = "";

            try
            { 
                TblUsuarioDAO tblUsuarioDataRepository = new TblUsuarioDAO();
                tblUsuarioDataRepository.idUser = idUser;
                tblUsuarioDataRepository.deLogin = deLogin;
                tblUsuarioDataRepository.nmUser = nmUser;
                tblUsuarioDataRepository.nuRegistration = nuRegistration;
                tblUsuarioDataRepository.rgRegistration = rgRegistration;
                tblUsuarioDataRepository.cnhRegistration = cnhRegistration;
                tblUsuarioDataRepository.dePassword = dePassword;
                tblUsuarioDataRepository.deEmail = deEmail;
                tblUsuarioDataRepository.idRole = (int)idRole;
                tblUsuarioDataRepository.idAddress = idAddress;
                tblUsuarioDataRepository.isActive = isActive;

                switch (State)
                {
                    //Execulta reglas comerciais / calculos
                    case EntityState.Add:
                        tblUsuarioRepository.Add(tblUsuarioDataRepository);
                        message = "Usuário Cadastrado com sucesso!";
                        break;
                    case EntityState.Modified:
                        tblUsuarioRepository.Edit(tblUsuarioDataRepository);
                        message = "Usuário alterado com sucesso!";
                        break;
                    case EntityState.Delete:
                        tblUsuarioRepository.Remove((int)idUser);
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

        public List<TblUsuarioModel> GetAll()
        {
            try
            {
                var listTblUsuarios = new List<TblUsuarioModel>();
                var tblUsuarioDataModel = tblUsuarioRepository.GetAll();

                foreach (TblUsuarioDAO item in tblUsuarioDataModel)
                {
                    listTblUsuarios.Add(new TblUsuarioModel
                    {
                        idUser = item.idUser,
                        deLogin = item.deLogin,
                        nmUser = item.nmUser,
                        nuRegistration = item.nuRegistration,
                        rgRegistration = item.rgRegistration,
                        cnhRegistration = item.cnhRegistration,
                        dePassword = item.dePassword,
                        deEmail = item.deEmail,
                        idRole = (EntityRole)item.idRole,
                        idAddress = item.idAddress,
                        isActive = item.isActive
                    });
                }
                return listTblUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TblUsuarioModel> GetSelectUser(long idUser)
        {
            try
            {
                var listTblUsuarios = new List<TblUsuarioModel>();
                var tblUsuarioDataModel = tblUsuarioRepository.GetSelectUser(idUser);

                foreach (TblUsuarioDAO item in tblUsuarioDataModel)
                {
                    listTblUsuarios.Add(new TblUsuarioModel
                    {
                        idUser = item.idUser,
                        deLogin = item.deLogin,
                        nmUser = item.nmUser,
                        nuRegistration = item.nuRegistration,
                        rgRegistration = item.rgRegistration,
                        cnhRegistration = item.cnhRegistration,
                        dePassword = item.dePassword,
                        deEmail = item.deEmail,
                        idRole = (EntityRole)item.idRole,
                        idAddress = item.idAddress,
                        isActive = item.isActive

                    });
                }
                return listTblUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TblUsuarioModel> GetSelectUser(string deLogin)
        {
            try
            {
                var listTblUsuarios = new List<TblUsuarioModel>();
                var tblUsuarioDataModel = tblUsuarioRepository.GetSelectUser(deLogin);

                foreach (TblUsuarioDAO item in tblUsuarioDataModel)
                {
                    listTblUsuarios.Add(new TblUsuarioModel
                    {
                        idUser = item.idUser,
                        deLogin = item.deLogin,
                        nmUser = item.nmUser,
                        nuRegistration = item.nuRegistration,
                        rgRegistration = item.rgRegistration,
                        cnhRegistration = item.cnhRegistration,
                        dePassword = item.dePassword,
                        deEmail = item.deEmail,
                        idRole = (EntityRole)item.idRole,
                        idAddress = item.idAddress,
                        isActive = item.isActive

                    });
                }
                return listTblUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
