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
    public class TblEnderecoRepository : MasterRepository, ITblEnderecoRepository
    {
        private string insert, selectAll, update, delete, select;

        public TblEnderecoRepository()
        {
            insert = "INSERT INTO PIM..TBL_ENDERECO VALUES(@P0,@P1,@P2,@P3,@P4,@P5";

            //CONCAT(STREET,' - ',NUMBER, ', Cep: ' ,CODEZIP, ', Bairro:',NEIGHBORHOOD, ', Cidade: ', CITY, ', Estado: ', NM_STATE) 'ENDERECO' 
            
            selectAll = "SELECT ID_ADDRESS, STREET, NUMBER, CODEZIP,NEIGHBORHOOD,CITY,NM_STATE " +
                        "FROM PIM..TBL_ENDERECO(NOLOCK)";

            select = "SELECT ID_ADDRESS, STREET, NUMBER, CODEZIP,NEIGHBORHOOD,CITY,NM_STATE FROM PIM..TBL_ENDERECO WHERE ID_ADDRESS = @P0";

            delete = "DELETE A FROM PIM..TBL_ENDERECO A WHERE ID_ADDRESS = @P0";

            update = "UPDATE PIM..TBL_ENDERECO SET" +
                     "[STREET] = @P1" +
                     ",[NUMBER] = @P2" +
                     ",[CODEZIP] = @P3" +
                     ",[NEIGHBORHOOD] = @P4" +
                     ",[CITY] = @P5" +
                     ",[NM_STATE] = @P6" +
                     " WHERE ID_ADDRESS = @P0";
        }

        public int Add(TblEnderecoDAO entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@P0", entity.street));
            parameters.Add(new SqlParameter("@P1", entity.number));
            parameters.Add(new SqlParameter("@P2", entity.codeZip));
            parameters.Add(new SqlParameter("@P3", entity.neighborhood));
            parameters.Add(new SqlParameter("@P4", entity.city));
            parameters.Add(new SqlParameter("@P5", entity.nmState));
            return ExecuteNonQuery(insert);
        }

        public int Edit(TblEnderecoDAO entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@P0", entity.street));
            parameters.Add(new SqlParameter("@P1", entity.number));
            parameters.Add(new SqlParameter("@P2", entity.codeZip));
            parameters.Add(new SqlParameter("@P3", entity.neighborhood));
            parameters.Add(new SqlParameter("@P4", entity.city));
            parameters.Add(new SqlParameter("@P5", entity.nmState));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<TblEnderecoDAO> GetAll()
        {
            try
            {
                var listTblEndenreco = new List<TblEnderecoDAO>();
                var tableResult = ExecuteRead(selectAll);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblEndenreco.Add(new TblEnderecoDAO
                    {
                        street = item["STREET"].ToString(),
                        number = int.Parse(item["NUMBER"].ToString()),
                        idAddress = int.Parse(item["ID_ADDRESS"].ToString()),
                        codeZip = item["CODEZIP"].ToString(),
                        neighborhood = item["NEIGHBORHOOD"].ToString(),
                        city = item["CITY"].ToString(),
                        nmState = item["NM_STATE"].ToString()
                    });
                }
                return listTblEndenreco;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<TblEnderecoDAO> GetSelectEndereco(int idAddress)
        {
            try
            {

                var listTblEndenreco = new List<TblEnderecoDAO>();
                parameters = new List<SqlParameter>();
                parameters.Add(new SqlParameter("@P0", idAddress));
                var tableResult = ExecuteRead(select);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblEndenreco.Add(new TblEnderecoDAO
                    {   
                        street = item["STREET"].ToString(),
                        number = int.Parse(item["NUMBER"].ToString()),
                        idAddress = int.Parse(item["ID_ADDRESS"].ToString()),
                        codeZip = item["CODEZIP"].ToString(),
                        neighborhood = item["NEIGHBORHOOD"].ToString(),
                        city = item["CITY"].ToString(),
                        nmState = item["NM_STATE"].ToString()
                    });
                }
                return listTblEndenreco;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Remove(int entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@P0", entity));
            return ExecuteNonQuery(delete);
        }
    }
}

