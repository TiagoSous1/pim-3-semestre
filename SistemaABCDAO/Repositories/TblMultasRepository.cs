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
    public class TblMultasRepository : MasterRepository, ITblMultasRepository
    {
        private readonly string select, selectAll, delete, update, insert;

        public TblMultasRepository()
        {
            insert = "INSERT INTO PIM..TBL_MULTAS VALUES (@P1, @P2, @P3, @P4, @P5, @P6)";

            delete = "DELETE FROM PIM..TBL_MULTAS WHERE ID_FINES = @P0";

            select = "SELECT ID_FINES,ID_VEHICLE,ID_INFRACTION,ID_COMPANY,DT_FINES,PRICE,CODE_BAR PIM..TBL_MULTAS WITH(NOLOCK) WHERE ID_FINES = @P0";

            selectAll = "SELECT ID_FINES,ID_VEHICLE,ID_INFRACTION,ID_COMPANY,DT_FINES,PRICE,CODE_BAR FROM PIM..TBL_MULTAS WITH(NOLOCK) ";

            update = "UPDATE PIM..TBL_MULTAS SET ID_VEHICLE = @P0, ID_INFRACTION = @P1 ,ID_COMPANY = @P2 ,DT_FINES = @P3 ,PRICE = @P4 ,CODE_BAR  = @P5 WHERE ID_FINES = @P6 ";
        }

        public int Add(TblMultasDAO entity)
        {
            try
            {
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P1", entity.idVehicle),
                    new SqlParameter("@P2", entity.idInfraction),
                    new SqlParameter("@P3", entity.idCompany),
                    new SqlParameter("@P4", entity.dtFines),
                    new SqlParameter("@P5", entity.price),
                    new SqlParameter("@P6", entity.codeBar)
                };
                return ExecuteNonQuery(insert);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Edit(TblMultasDAO entity)
        {
            try
            {
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P0", entity.idVehicle),
                    new SqlParameter("@P1", entity.idInfraction),
                    new SqlParameter("@P2", entity.idCompany),
                    new SqlParameter("@P3", entity.dtFines),
                    new SqlParameter("@P4", entity.price),
                    new SqlParameter("@P5", entity.codeBar),
                    new SqlParameter("@P6", entity.idFines)
                };
                return ExecuteNonQuery(update);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TblMultasDAO> GetAll()
        {
            try
            {
                var listTblPecas = new List<TblMultasDAO>();
                var tableResult = ExecuteRead(selectAll);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblPecas.Add(new TblMultasDAO
                    {
                        idFines = long.Parse(item["ID_FINES"].ToString()),
                        idInfraction  = int.Parse(item["ID_INFRACTION"].ToString()),
                        idVehicle = long.Parse(item["ID_VEHICLE"].ToString()),
                        idCompany = long.Parse(item["ID_COMPANY"].ToString()),
                        codeBar = item["CODE_BAR"].ToString(),
                        price = float.Parse(item["PRICE"].ToString()),
                        dtFines = DateTime.Parse(item["DT_FINES"].ToString())
                    });
                }
                return listTblPecas;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TblMultasDAO> GetSelectedAll(string id)
        {
            try
            {
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P0", id)
                };
                var listTblPecas = new List<TblMultasDAO>();
                var tableResult = ExecuteRead(select);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblPecas.Add(new TblMultasDAO
                    {
                        idFines = long.Parse(item["ID_FINES"].ToString()),
                        idInfraction = int.Parse(item["ID_INFRACTION"].ToString()),
                        idVehicle = long.Parse(item["ID_VEHICLE"].ToString()),
                        idCompany = long.Parse(item["ID_COMPANY"].ToString()),
                        codeBar = item["CODE_BAR"].ToString(),
                        price = float.Parse(item["PRICE"].ToString()),
                        dtFines = DateTime.Parse(item["DT_FINES"].ToString())
                    });
                }
                return listTblPecas;

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
