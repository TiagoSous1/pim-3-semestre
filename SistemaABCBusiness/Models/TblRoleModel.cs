using SistemaABCBusiness.ValueObjects;
using SistemaABCDAO.Entities;
using SistemaABCDAO.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCBusiness.Models
{
    public class TblRoleModel
    {
        private readonly TblRoleRepository roleRepository = new TblRoleRepository();
        public int? idRole { get; set; }
        public string nmRole { get; set; }
        public bool isActive { get; set; }
        public EntityState State { get; private set; }

        public TblRoleModel()
        {
        }

        public TblRoleModel(int? idRole, string nmRole, bool isActive)
        {
            this.idRole = idRole;
            this.nmRole = nmRole;
            this.isActive = isActive;
        }


        public string saveChange()
        {
            string message = "";

            try
            {
                TblRoleDAO tblRoleDataRepository = new TblRoleDAO
                {
                    idRole = idRole,
                    nmRole = nmRole,
                    isActive = isActive
                };


                switch (State)
                {
                    //Execulta reglas comerciais / calculos
                    case EntityState.Add:
                        roleRepository.Add(tblRoleDataRepository);
                        message = "Usuário Cadastrado com sucesso!";
                        break;
                    case EntityState.Modified:
                        roleRepository.Edit(tblRoleDataRepository);
                        message = "Usuário alterado com sucesso!";
                        break;
                    case EntityState.Delete:
                        roleRepository.Remove((int)idRole);
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
        public List<TblRoleModel> GetAll()
        {
            try
            {
                var listTblRole = new List<TblRoleModel>();
                var tblRoleDataModel = roleRepository.GetAll();

                foreach (TblRoleDAO item in tblRoleDataModel)
                {
                    listTblRole.Add(new TblRoleModel
                    {
                        idRole = item.idRole,
                        nmRole = item.nmRole,
                        isActive = item.isActive

                    });
                }
                return listTblRole;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TblRoleModel> GetSelectEndereco(int idRole)
        {
            try
            {
                var listTblRole = new List<TblRoleModel>();
                var tblRoleDataModel = roleRepository.GetSelectRole(idRole);

                foreach (TblRoleDAO item in tblRoleDataModel)
                {
                    listTblRole.Add(new TblRoleModel
                    {
                       idRole= item.idRole,
                       nmRole = item.nmRole,
                       isActive = item.isActive
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
