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
    class clnAgenda
    {
        private int _cod;
        private string _nome, _tel, _cep, _endereco, _UF, _nr, _bairro, _cidade;

        public int Cod
        {
            get { return _cod; }
            set { _cod = value; }
        }
      
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value.ToUpper(); }
        }

        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value.ToUpper(); }
        }

        public string Nr
        {
            get { return _nr; }
            set { _nr = value.ToUpper(); }
        }

        public string UF
        {
            get { return _UF; }
            set { _UF = value.ToUpper(); }
        }

        public string Endereco
        {
            get { return _endereco; }
            set { _endereco = value.ToUpper(); }
        }

        public string Cep
        {
            get { return _cep; }
            set { _cep = value.ToUpper(); }
        }

        public string Tel
        {
            get { return _tel; }
            set { _tel = value.ToUpper(); }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value.ToUpper(); }
        }

        public DataSet Listar(string strDescricao)
        {
            string strQuery;
            strQuery = "Select cod,nome,tel From t_dadosAgenda Where nome like'%" + strDescricao + "%' and Ativo='1' order by cod";
            cldBancoDados ObjBancoDados = new cldBancoDados();
            return ObjBancoDados.RetornaDataSet(strQuery);

        }
        public OracleDataReader ListarUsuario()
        {
            string strQuery = "Select * from t_dadosAgenda where cod='" + _cod + "'";
            cldBancoDados objBancoDados = new cldBancoDados();
            return objBancoDados.RetornaDataReader(strQuery);
        }

        public DataSet PreencherUF()
        {
            cldBancoDados objBancoDados = new cldBancoDados();
            return objBancoDados.RetornaDataSet("Select UF From T_UF");
        }

        public void Gravar()
        {
            StringBuilder QueryGravar = new StringBuilder();
            QueryGravar.Append("insert into t_dadosAgenda");
            QueryGravar.Append(" (cod, Nome, Tel, Endereco, ");
            QueryGravar.Append("Nr, Bairro, Cidade, cep, UF, Ativo)");
            QueryGravar.Append(" values (");
            QueryGravar.Append("Seq_DadosAgenda.NEXTVAL,");
            QueryGravar.Append("'" + _nome + "',");
            QueryGravar.Append("'" + _tel + "',");
            QueryGravar.Append("'" + _endereco + "',");
            QueryGravar.Append("'" + _nr + "',");
            QueryGravar.Append("'" + _bairro + "',");
            QueryGravar.Append("'" + _cidade + "',");
            QueryGravar.Append("'" + _cep + "',");
            QueryGravar.Append("'" + _UF + "',");
            QueryGravar.Append("'1'");
            QueryGravar.Append(")");
            cldBancoDados ObjCldBancoDados = new cldBancoDados();
            ObjCldBancoDados.ExecutaComando(QueryGravar.ToString());
        }

        public void Alterar()
        {
            string strQuery;
            strQuery = (" UPDATE t_dadosAgenda");
            strQuery += (" SET ");
            strQuery += (" Nome = '" + _nome + "' ");
            strQuery += (", Tel = '" + _tel + "' ");
            strQuery += (", Endereco = '" + _endereco + "' ");
            strQuery += (", Nr = '" + _nr + "' ");
            strQuery += (", Bairro = '" + _bairro + "' ");
            strQuery += (", Cidade = '" + _cidade + "' ");
            strQuery += (", cep = '" + _cep + "' ");
            strQuery += (", UF = '" + _UF + "' ");
            strQuery += (", Ativo = '1'");
            strQuery += (" WHERE ");
            strQuery += (" cod = '" + _cod + "' ");
            cldBancoDados ObjCldBancoDados = new cldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }

        public void ExcluirLogicamente()
        {
            string strQuery;
            strQuery = (" UPDATE t_dadosAgenda ");
            strQuery += (" SET ");
            strQuery += (" Ativo = '" + 0 + "' ");
            strQuery += (" WHERE ");
            strQuery += (" cod = '" + _cod + "' ");
            cldBancoDados ObjCldBancoDados = new cldBancoDados();
            ObjCldBancoDados.ExecutaComando(strQuery);
        }
    }
}