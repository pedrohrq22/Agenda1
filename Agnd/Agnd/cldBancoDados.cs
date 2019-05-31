using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Agnd
{
    class cldBancoDados
    {
        public static OracleConnection AbreBanco()
        {
            string StringConexao = "Data Source=LOCALHOST;User Id=UserAgenda;Password=123456;";

            try
            {
                OracleConnection conm = new OracleConnection(StringConexao);
                conm.Open();
                return conm;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void FechaBanco(OracleConnection conm)
        {
            try
            {
                if (conm.State == ConnectionState.Open)
                { conm.Close(); }
            }
            catch (Exception e)
            { throw e; }

        }

        public DataSet RetornaDataSet(string strQuery)
        {
            OracleConnection conm;
            conm = AbreBanco();
            try
            {
                DataSet ds = new DataSet();
                OracleCommand cmdComando = new OracleCommand(strQuery, conm);
                OracleDataAdapter da = new OracleDataAdapter(cmdComando);
                da.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                FechaBanco(conm);
            }
        }

        public OracleDataReader RetornaDataReader(string strQuery)
        {
            try
            {
                OracleDataReader dr;
                OracleCommand sqlCommando = new OracleCommand(strQuery, AbreBanco());
                dr = sqlCommando.ExecuteReader();
                return dr;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ExecutaComando(string strQuery)
        {
            OracleConnection conm;
            conm = AbreBanco();
            try
            {
                OracleCommand sqlConm = new OracleCommand(strQuery, conm);
                sqlConm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            { FechaBanco(conm); }
        }
    }
}