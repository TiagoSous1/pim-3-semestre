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
    public class TblAbastecimentoRepository : MasterRepository, ITblAbastecimentoRepository
    {
        private readonly string select, insert, delete, update, selected;

        public TblAbastecimentoRepository()
        {
            select = "SELECT * FROM PIM..TBL_ABASTECIMENTO (NOLOCK)";

            insert = "INSERT INTO PIM..TBL_ABASTECIMENTO VALUES (@P0,@P1,@P2,@P3,@P4)";

            delete = "DELETE A FROM PIM..TBL_ABASTECIMENTO A WHERE A.ID_SUPPLY = @P0";

            update = "UPDATE FROM PIM..TBL_ABASTECIMENTO SET COD_INVOICE = @P1, ID_VEHICLE = @P2, ID_COMPANY = @P3, DT_SUPPLY = @P4,PRICE = @P5 WHERE ID_SUPPLY = @P0";

            selected = "SELECT * FROM PIM..TBL_ABASTECIMENTO (NOLOCK) WHERE A.ID_SUPPLY";

        }

        public int Add(TblAbastecimentoDAO entity)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@P0", entity.codInvoice),
                new SqlParameter("@P1",entity.idVehicle),
                new SqlParameter("@P2",entity.idCompany),
                new SqlParameter("@P3",entity.dtSupply),
                new SqlParameter("@P4",entity.price),
            };

            return ExecuteNonQuery(insert);

        }

        public int Edit(TblAbastecimentoDAO entity)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@P0",entity.idSupply),
                new SqlParameter("@P1",entity.codInvoice),
                new SqlParameter("@P2",entity.idVehicle),
                new SqlParameter("@P3",entity.idCompany),
                new SqlParameter("@P4",entity.dtSupply),
                new SqlParameter("@P5",entity.price),
            };

            return ExecuteNonQuery(update);
        }

        public IEnumerable<TblAbastecimentoDAO> GetAll()
        {
            try
            {
                var listTblAbastecimento = new List<TblAbastecimentoDAO>();
                var tableResult = ExecuteRead(select);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblAbastecimento.Add(new TblAbastecimentoDAO
                    {
                        idSupply = long.Parse(item["ID_SUPPLY"].ToString()),
                        codInvoice = long.Parse(item["COD_INVOICE"].ToString()),
                        idCompany = long.Parse(item["ID_COMPANY"].ToString()),
                        idVehicle = long.Parse(item["ID_VEHICLE"].ToString()),
                        dtSupply = DateTime.Parse(item["DT_SUPPLY"].ToString()),
                        price = float.Parse(item["PRICE"].ToString())
                    });
                }
                return listTblAbastecimento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TblAbastecimentoDAO> GetSelected(int idSupply)
        {
            try
            {
                var listTblAbastecimento = new List<TblAbastecimentoDAO>();
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P0", idSupply)
                };
                var tableResult = ExecuteRead(selected);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblAbastecimento.Add(new TblAbastecimentoDAO
                    {
                        idSupply = long.Parse(item["ID_SUPPLY"].ToString()),
                        codInvoice = long.Parse(item["COD_INVOICE"].ToString()),
                        idCompany = long.Parse(item["ID_COMPANY"].ToString()),
                        idVehicle = long.Parse(item["ID_VEHICLE"].ToString()),
                        dtSupply = DateTime.Parse(item["DT_SUPPLY"].ToString()),
                        price = float.Parse(item["PRICE"].ToString()),
                    });
                }
                return listTblAbastecimento;
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
