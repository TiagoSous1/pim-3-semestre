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
    public class TblInfracaoRepository : MasterRepository, ITblInfracaoRepository
    {
        private readonly string select, selectAll, delete, update, insert;

        public TblInfracaoRepository()
        {
            insert = "INSERT INTO PIM..TBL_INFRACAO VALUES (@P0, 1, @P1)";

            delete = "DELETE FROM PIM..TBL_INFRACAO WHERE ID_INFRACTION = @P0";

            select = "SELECT ID_INFRACTION,NM_INFRACTION,DESC_INFRACTION,IS_ACTIVE PIM..TBL_INFRACAO WITH(NOLOCK) WHERE ID_INFRACTION = @P0";

            selectAll = "SELECT ID_INFRACTION,NM_INFRACTION,DESC_INFRACTION,IS_ACTIVE FROM PIM..TBL_INFRACAO WITH(NOLOCK) ";

            update = "UPDATE PIM..TBL_INFRACAO ";
        }

        public int Add(TblInfracaoDAO entity)
        {
            try
            {
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P0", entity.descInfraction),
                    new SqlParameter("@P1", entity.nmInfraction)
                };
                return ExecuteNonQuery(insert);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Edit(TblInfracaoDAO entity)
        {
            try
            {
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P0", entity.descInfraction),
                    new SqlParameter("@P1", entity.nmInfraction),
                    new SqlParameter("@P2", entity.isActive)
                };
                return ExecuteNonQuery(update);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TblInfracaoDAO> GetAll()
        {
            try
            {
                var listTblInfracao = new List<TblInfracaoDAO>();
                var tableResult = ExecuteRead(selectAll);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblInfracao.Add(new TblInfracaoDAO
                    {
                        idInfraction = int.Parse(item["ID_INFRACTION"].ToString()),
                        descInfraction = item["DESC_INFRACTION"].ToString(),
                        nmInfraction = item["NM_INFRACTION"].ToString(),
                        isActive = bool.Parse(item["IS_ACTIVE"].ToString())
                    });
                }
                return listTblInfracao;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<TblInfracaoDAO> GetSelected(int idVehicle)
        {
            try
            {
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P0",idVehicle)
                };

                var listTblInfracao = new List<TblInfracaoDAO>();
                var tableResult = ExecuteRead(select);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblInfracao.Add(new TblInfracaoDAO
                    {
                        idInfraction = int.Parse(item["ID_INFRACTION"].ToString()),
                        descInfraction = item["DESC_INFRACTION"].ToString(),
                        nmInfraction = item["NM_INFRACTION"].ToString(),
                        isActive = bool.Parse(item["IS_ACTIVE"].ToString())
                    });
                }
                return listTblInfracao;

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
