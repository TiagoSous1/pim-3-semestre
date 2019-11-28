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
    public class TblVeiculoRepository : MasterRepository, ITblVeiculoRepository
    {
        private readonly string select, selectAll, delete, update, insert;

        public TblVeiculoRepository()
        {
            insert = "INSERT INTO PIM..TBL_VEICULO VALUES (@P0, @P1, @P2, @P3, @P4 )";

            delete = "DELETE FROM PIM..TBL_VEICULO WHERE ID_VEHICLE = @P0";

            select = "SELECT ID_VEHICLE,DESC_VEHICLE,BOARD,ID_COMPANY,KILOMETRO,YEAR PIM..TBL_PTBL_VEICULOECA WITH(NOLOCK) WHERE ID_VEHICLE = @P0";

            selectAll = "SELECT ID_VEHICLE,DESC_VEHICLE,BOARD,ID_COMPANY,KILOMETRO,YEAR FROM PIM..TBL_VEICULO WITH(NOLOCK) ";

            update = "UPDATE PIM..TBL_VEICULO DESC_VEHICLE = @P1 ,BOARD = @P2 ,ID_COMPANY = @P3 ,KILOMETRO = @P4 ,YEAR  = @P5 WHERE ID_VEHICLE = @P0";
        }

        public int Add(TblVeiculoDAO entity)
        {
            try
            {
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P0", entity.descVehicle),
                    new SqlParameter("@P1", entity.board),
                    new SqlParameter("@P2", entity.idCompany),
                    new SqlParameter("@P3", entity.kilometro),
                    new SqlParameter("@P4", entity.year)
                };
                return ExecuteNonQuery(insert);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Edit(TblVeiculoDAO entity)
        {
            try
            {
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P0", entity.idVehicle),
                    new SqlParameter("@P1", entity.descVehicle),
                    new SqlParameter("@P2", entity.board),
                    new SqlParameter("@P3", entity.idCompany),
                    new SqlParameter("@P4", entity.kilometro),
                    new SqlParameter("@P5", entity.year)
                };
                return ExecuteNonQuery(update);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TblVeiculoDAO> GetAll()
        {
            try
            {
                var listTblVeiculo = new List<TblVeiculoDAO>();
                var tableResult = ExecuteRead(selectAll);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblVeiculo.Add(new TblVeiculoDAO
                    {
                        idVehicle = long.Parse(item["ID_VEHICLE"].ToString()),
                        descVehicle = item["DESC_VEHICLE"].ToString(),
                        board = item["BOARD"].ToString(),
                        idCompany = long.Parse(item["ID_COMPANY"].ToString()),
                        kilometro = int.Parse(item["KILOMETRO"].ToString()),
                        year = int.Parse(item["YEAR"].ToString())
                    });
                }
                return listTblVeiculo;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<TblVeiculoDAO> GetSelected(int idVehicle)
        {
            try
            {
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P0",idVehicle)
                };

                var listTblVeiculo = new List<TblVeiculoDAO>();
                var tableResult = ExecuteRead(select);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblVeiculo.Add(new TblVeiculoDAO
                    {
                        idVehicle = long.Parse(item["ID_VEHICLE"].ToString()),
                        descVehicle = item["DESC_VEHICLE"].ToString(),
                        board = item["BOARD"].ToString(),
                        idCompany = long.Parse(item["ID_COMPANY"].ToString()),
                        kilometro = int.Parse(item["KILOMETRO"].ToString()),
                        year = int.Parse(item["YEAR"].ToString())
                    });
                }
                return listTblVeiculo;

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
