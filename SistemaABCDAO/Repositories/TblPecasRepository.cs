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
    public class TblPecasRepository : MasterRepository, ITblPecasRepository
    {
        private readonly string select, selectAll, delete, update, insert;

        public TblPecasRepository()
        {
            insert = "INSERT INTO PIM..TBL_PECA VALUES (@P0, @P1, @P2, @P3, @P4)";

            delete = "DELETE FROM PIM..TBL_PECA WHERE ID_PIECE = @P0";

            select = "SELECT PRICE,DESC_PIECE,DT_BUY,DT_START,DT_FINISH PIM..TBL_PECA WITH(NOLOCK) WHERE ID_PIECE = @P0";

            selectAll = "SELECT PRICE,DESC_PIECE,DT_BUY,DT_START,DT_FINISH FROM PIM..TBL_PECA WITH(NOLOCK) ";

            update = "UPDATE PIM..TBL_PECA SET PRICE = @P1,DESC_PIECE = @P2,DT_BUY = @P3,DT_START = @P4,DT_FINISH = @P5 WHERE ID_PIECE = @P0";
        }

        public int Add(TblPecasDAO entity)
        {
            try
            {
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P0", entity.price),
                    new SqlParameter("@P1", entity.descPiece),
                    new SqlParameter("@P2", entity.dtBuy),
                    new SqlParameter("@P3", entity.dtStart),
                    new SqlParameter("@P4", entity.dtFinish)
                };
                return ExecuteNonQuery(insert);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Edit(TblPecasDAO entity)
        {
            try
            {
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P0", entity.idPiece),
                    new SqlParameter("@P1", entity.price),
                    new SqlParameter("@P2", entity.descPiece),
                    new SqlParameter("@P3", entity.dtBuy),
                    new SqlParameter("@P4", entity.dtStart),
                    new SqlParameter("@P5", entity.dtFinish)
                };
                return ExecuteNonQuery(update);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TblPecasDAO> GetAll()
        {
            try
            {
                var listTblPecas = new List<TblPecasDAO>();
                var tableResult = ExecuteRead(selectAll);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblPecas.Add(new TblPecasDAO
                    {
                        idPiece = long.Parse(item["ID_PIECE"].ToString()),
                        dtBuy = DateTime.Parse(item["DT_BUY"].ToString()),
                        dtFinish = DateTime.Parse(item["DT_FINISH"].ToString()),
                        dtStart = DateTime.Parse(item["DT_START"].ToString()),
                        price = float.Parse(item["PRICE"].ToString()),
                        descPiece = item["DESC_PIECE"].ToString()
                    });
                }
                return listTblPecas;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<TblPecasDAO> GetSelected(int idPiece)
        {
            try
            {
                var listTblPecas = new List<TblPecasDAO>();
                parameters = new List<SqlParameter>
                {
                    new SqlParameter("@P0", idPiece)
                };
                var tableResult = ExecuteRead(select);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblPecas.Add(new TblPecasDAO
                    {

                        idPiece = long.Parse(item["ID_PIECE"].ToString()),
                        dtBuy = DateTime.Parse(item["DT_BUY"].ToString()),
                        dtFinish = DateTime.Parse(item["DT_FINISH"].ToString()),
                        dtStart = DateTime.Parse(item["DT_START"].ToString()),
                        price = float.Parse(item["PRICE"].ToString()),
                        descPiece = item["DESC_PIECE"].ToString()

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
