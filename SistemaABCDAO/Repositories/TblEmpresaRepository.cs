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
    public class TblEmpresaRepository : MasterRepository, ITblEmpresaRepository
    {
        private string select, insert, update, delete, selected;
        public TblEmpresaRepository()
        {
            select = "SELECT * FROM PIM..TBL_EMPRESA (NOLOCK) ";

            selected = "SELECT * FROM PIM..TBL_EMPRESA (NOLOCK) WHERE ID_COMPANY @P0";

            insert = "INSERT INTO PIM..TBL_EMPRESA VALUES(@P0,@P1,@P2,@P3,@P4)";

            update = "UPDATE PIM.dbo.TBL_EMPRESA SET NM_COMPANY = @P0,NU_REGISTRATION = @P1 ,STATE = @P2 ,ID_ADDRESS = @P3,TEL = @P4 WHERE ID_COMPANY = @P5";

            delete = "DELETE A FROM PIM.dbo.TBL_EMPRESA  A WHERE ID_COMPANY = @P0";
        }

        public int Add(TblEmpresaDAO entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@P0", entity.nmCompany));
            parameters.Add(new SqlParameter("@P1", entity.nuRegistration));
            parameters.Add(new SqlParameter("@P2", entity.state));
            parameters.Add(new SqlParameter("@P3", entity.idAddress));
            parameters.Add(new SqlParameter("@P4", entity.tel));
            return ExecuteNonQuery(insert);
        }

        public int Edit(TblEmpresaDAO entity)
        {
            parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@P0", entity.nmCompany));
            parameters.Add(new SqlParameter("@P1", entity.nuRegistration));
            parameters.Add(new SqlParameter("@P2", entity.state));
            parameters.Add(new SqlParameter("@P3", entity.idAddress));
            parameters.Add(new SqlParameter("@P4", entity.tel));
            parameters.Add(new SqlParameter("@P5", entity.idCompany));
            return ExecuteNonQuery(update);
        }

        public IEnumerable<TblEmpresaDAO> GetAll()
        {
            try
            {

                var listTblEmpresa = new List<TblEmpresaDAO>();
                var tableResult = ExecuteRead(select);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblEmpresa.Add(new TblEmpresaDAO
                    {
                        idCompany = long.Parse(item["ID_COMPANY"].ToString()),
                        nmCompany = item["NM_COMPANY"].ToString(),
                        nuRegistration = item["NU_REGISTRATION"].ToString(),
                        state = item["STATE"].ToString(),
                        idAddress = int.Parse(item["ID_ADDRESS"].ToString()),
                        tel = long.Parse(item["TEL"].ToString()),
                        
                    });
                }
                return listTblEmpresa;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<TblEmpresaDAO> GetSelectAll(long idCompany)
        {
            try
            {
                var listTblEmpresa = new List<TblEmpresaDAO>();
                var tableResult = ExecuteRead(select);

                foreach (DataRow item in tableResult.Rows)
                {
                    listTblEmpresa.Add(new TblEmpresaDAO
                    {
                        idCompany = long.Parse(item["ID_COMPANY"].ToString()),
                        nmCompany = item["NM_COMPANY"].ToString(),
                        nuRegistration = item["NU_REGISTRATION"].ToString(),
                        state = item["STATE"].ToString(),
                        idAddress = int.Parse(item["ID_ADDRESS"].ToString()),
                        tel = long.Parse(item["TEL"].ToString()),

                    });
                }
                return listTblEmpresa;

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
