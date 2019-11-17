using SistemaABCDAO.Contrats;
using SistemaABCDAO.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaABCDAO.Repositories
{
    public class TblUsuarioRepository : MasterRepository, ITblUsuarioRepository
    {
        private readonly string insert, selectAll, update, delete, select;
        public TblUsuarioRepository()
        {
            insert = "INSERT INTO PIM..TBL_USUARIO VALUES(@P0,@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8,@P9)";

            update = "UPDATE [dbo].[TBL_USUARIO]" +
                " SET[DE_LOGIN] = @P0" +
                " ,[NM_USER] = @P1" +
                " ,[NU_REGISTRATION] = @P2" +
                " ,[RG_REGISTRATION] = @P3" +
                " ,[CNH_REGISTRATION] = @P4" +
                " ,[DE_PASSWORD] = @P5" +
                " ,[DE_EMAIL] = @P6" +
                " ,[ID_ROLE] = @P7" +
                " ,[ID_ADDRESS] = @P8" +
                " ,[IS_ACTIVE] = @P9" +
                " WHERE ID_USER = @P10";

            select = "SELECT ID_USER,DE_LOGIN,NM_USER,NU_REGISTRATION,RG_REGISTRATION,CNH_REGISTRATION,DE_PASSWORD,DE_EMAIL,ID_ROLE,ID_ADDRESS,IS_ACTIVE FROM dbo.TBL_USUARIO (NOLOCK) WHERE ID_USER = @P0 ";

            selectAll = "SELECT ID_USER,DE_LOGIN,NM_USER,NU_REGISTRATION,RG_REGISTRATION,CNH_REGISTRATION,DE_PASSWORD,DE_EMAIL,ID_ROLE,ID_ADDRESS,IS_ACTIVE FROM dbo.TBL_USUARIO (NOLOCK) ";

            delete = "DELETE A FROM PIM..TBL_USUARIO A WHERE ID_USER = @P0";
        }
        public int Add(TblUsuarioDAO entity)
        {
            try
            {
                parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@P0", entity.deLogin));
                parameters.Add(new SqlParameter("@P1", entity.nmUser));
                parameters.Add(new SqlParameter("@P2", entity.nuRegistration));
                parameters.Add(new SqlParameter("@P3", entity.rgRegistration));
                parameters.Add(new SqlParameter("@P4", entity.cnhRegistration));
                parameters.Add(new SqlParameter("@P5", entity.dePassword));
                parameters.Add(new SqlParameter("@P6", entity.deEmail));
                parameters.Add(new SqlParameter("@P7", entity.idRole));
                parameters.Add(new SqlParameter("@P8", entity.idAddress));
                parameters.Add(new SqlParameter("@P9", entity.isActive));
                return ExecuteNonQuery(insert);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int Edit(TblUsuarioDAO entity)
        {
            try
            {
                parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@P0", entity.deLogin));
                parameters.Add(new SqlParameter("@P1", entity.nmUser));
                parameters.Add(new SqlParameter("@P2", entity.nuRegistration));
                parameters.Add(new SqlParameter("@P3", entity.nuRegistration));
                parameters.Add(new SqlParameter("@P4", entity.cnhRegistration));
                parameters.Add(new SqlParameter("@P5", entity.dePassword));
                parameters.Add(new SqlParameter("@P6", entity.deEmail));
                parameters.Add(new SqlParameter("@P7", entity.idRole));
                parameters.Add(new SqlParameter("@P8", entity.idAddress));
                parameters.Add(new SqlParameter("@P9", entity.isActive));
                parameters.Add(new SqlParameter("@P10", entity.idUser));
                return ExecuteNonQuery(update);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TblUsuarioDAO> GetAll()
        {
            try
            {

                var listTblUsuarios = new List<TblUsuarioDAO>();
                var tableResult = ExecuteRead(selectAll);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblUsuarios.Add(new TblUsuarioDAO
                    {
                        idUser = long.Parse(item["ID_USER"].ToString()),
                        deLogin = item["DE_LOGIN"].ToString(),
                        nmUser = item["NM_USER"].ToString(),
                        nuRegistration = item["NU_REGISTRATION"].ToString(),
                        rgRegistration = item["RG_REGISTRATION"].ToString(),
                        cnhRegistration = item["CNH_REGISTRATION"].ToString(),
                        dePassword = item["DE_PASSWORD"].ToString(),
                        deEmail = item["DE_EMAIL"].ToString(),
                        idRole = int.Parse(item["ID_ROLE"].ToString()),
                        idAddress = int.Parse(item["ID_ADDRESS"].ToString()),
                        isActive = bool.Parse(item["IS_ACTIVE"].ToString())

                    });
                }
                return listTblUsuarios;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<TblUsuarioDAO> GetSelectUser(long idUser)
        {
            try
            {
                parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@P0", idUser));

                var listTblUsuarios = new List<TblUsuarioDAO>();
                var tableResult = ExecuteRead(select);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblUsuarios.Add(new TblUsuarioDAO
                    {
                        idUser = long.Parse(item["ID_USER"].ToString()),
                        deLogin = item["DE_LOGIN"].ToString(),
                        nmUser = item["NM_USER"].ToString(),
                        nuRegistration = item["NU_REGISTRATION"].ToString(),
                        rgRegistration = item["RG_REGISTRATION"].ToString(),
                        cnhRegistration = item["CNH_REGISTRATION"].ToString(),
                        dePassword = item["DE_PASSWORD"].ToString(),
                        deEmail = item["DE_EMAIL"].ToString(),
                        idRole = int.Parse(item["ID_ROLE"].ToString()),
                        idAddress = int.Parse(item["ID_ADDRESS"].ToString()),
                        isActive = bool.Parse(item["IS_ACTIVE"].ToString())
                    });
                }
                return listTblUsuarios;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Remove(int entity)
        {
            try
            {
                parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@P0", entity));
                return ExecuteNonQuery(delete);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
