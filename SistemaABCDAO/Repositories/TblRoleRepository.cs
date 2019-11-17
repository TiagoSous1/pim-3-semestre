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
    public class TblRoleRepository : MasterRepository, ITblRoleRepository
    {
        private readonly string select, selectAll, delete, update, insert;

        public TblRoleRepository()
        {
            insert = "INSERT INTO PIM..TBL_ROLE VALUES (@P0, @P1)";

            delete = "DELETE FROM PIM..TBL_ROLE WHERE ID_ROLE = @P0";

            select = "SELECT ID_ROLE, NM_ROLE, IS_ACTIVE PIM..TBL_ROLE WITH(NOLOCK) WHERE ID_ROLE = @P0";

            selectAll = "SELECT ID_ROLE,NM_ROLE,IS_ACTIVE FROM PIM..TBL_ROLE WITH(NOLOCK) ";

            update = "UPDATE PIM..TBL_ROLE SET NM_ROLE = @P1, IS_ACTIVE = @P2 WHERE ID_ROLE = @P0";
        }

        public int Add(TblRoleDAO entity)
        {
            try
            {
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P0", entity.nmRole),
                    new SqlParameter("@P1", entity.isActive)
                };
                return ExecuteNonQuery(insert);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int Edit(TblRoleDAO entity)
        {
            try
            {
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P0", entity.nmRole),
                    new SqlParameter("@P0", entity.isActive)
                };
                return ExecuteNonQuery(update);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TblRoleDAO> GetAll()
        {
            try
            {
                var listTblRole = new List<TblRoleDAO>();
                var tableResult = ExecuteRead(selectAll);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblRole.Add(new TblRoleDAO
                    {
                        idRole = int.Parse(item["ID_ROLE"].ToString()),
                        nmRole = item["NM_ROLE"].ToString(),
                        isActive = bool.Parse(item["IS_ACTIVE"].ToString())
                    });
                }
                return listTblRole;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<TblRoleDAO> GetSelectRole(int idRole)
        {
            try
            {
                var listTblRole = new List<TblRoleDAO>();
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P0", idRole)
                };
                var tableResult = ExecuteRead(select);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblRole.Add(new TblRoleDAO
                    {
                        idRole = int.Parse(item["ID_ROLE"].ToString()),
                        nmRole = item["NM_ROLE"].ToString(),
                        isActive = bool.Parse(item["IS_ACTIVE"].ToString())
                    });
                }
                return listTblRole;

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
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P0", entity)
                };
                return ExecuteNonQuery(delete);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
