using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace ConexaoBanco
{
    public static class ConexaoSQL
    {
        public static string vsql;
        //  public static string Servidor;
        // public  static  string BaseDados;
        //  public static string connString = "Data Source=" + Servidor + ";Initial Catalog=" + BaseDados + " ;Integrated Security=True"; 
        //public static string teste = connString;
        private static SqlConnection conn = null;
        public static string CampoCondicaoFiltro, condicao, operador;


        public static string BaseDados { get; set; }
        public static string NomeServidor { get; set; }


        public static SqlConnection conexao()
        {
            string connString = string.Format("Data Source={0} ;Initial Catalog={1} ;Integrated Security= true", NomeServidor, BaseDados);

            SqlConnection cn = new SqlConnection(connString);

            return cn;
        }

        public static DataSet retornarRegistrosDataSet(string consulta)
        {
            DataSet ds = new DataSet();
            SqlCommand objcmd = null;

            objcmd = new SqlCommand(consulta, abrirConexao());
            //      var Retorno=null;

            SqlDataAdapter data = new System.Data.SqlClient.SqlDataAdapter(objcmd);

            data.Fill(ds);
            return ds;
        }


        public static SqlConnection abrirConexao()
        {
            SqlConnection cn = conexao();

            try
            {
                cn.Open();
                return cn;
            }


            catch (Exception e)
            {
                throw e;

            }


        }


        public static SqlConnection FecharConexao()
        {
            SqlConnection cn = conexao();

            try
            {
                cn.Close();
                return cn;
            }


            catch (Exception e)
            {
                throw e;

            }
        }


        /// <summary>
        /// Metodo para preencher a string de conexão com o banco de dados 
        /// </summary>
        /// <param name="servidor"></param>
        /// Parametro que conterá o servidor que será conectado do sql server
        /// <param name="baseDados"></param>
        /// Parametro para preencher o banco de dados que será acessado .





        public static bool insert(string sql)
        {

            try
            {

                executaQuery(sql);

                return true;
            }

            catch (Exception ex)
            {

                throw ex;
                return false;

            }

            finally
            {
                FecharConexao();
            }
        }

        /// <summary>
        /// Metodo para retornar um registro atraves de select 
        /// </summary>
        /// <param name="Tabela"></param>
        /// Tabela do banco que será utilizada
        /// <param name="campo"></param>
        /// Campo da tabela que será utilizada
        /// <param name="CampoCondicaoFiltro"></param>
        /// Campo que será utilizado após o where para definir a condição de busca
        /// <param name="condicao"></param>
        /// Qual será o valor que será filtrado para condição 
        /// <returns></returns>
        public static string RetornarUmRegistro(string consulta)
        {
            try
            {
                string Retorno = "";
                SqlCommand objcmd = null;

                string sql = consulta;

                try
                {
                    objcmd = new SqlCommand(sql, abrirConexao());

                }
                catch
                {
                    throw new System.ArgumentException("Erro a abrir coneção!");
                }

                Retorno = Convert.ToString(objcmd.ExecuteScalar());
                FecharConexao();
                return Retorno;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static SqlDataReader RetornarRegistros(string Consulta)
        {
            try
            {
                SqlCommand objcmd = null;

                objcmd = new SqlCommand(Consulta, abrirConexao());

                SqlDataReader adoDR = objcmd.ExecuteReader();

                return adoDR;
            }

            catch (Exception ex)
            {
                throw new System.ArgumentException(ex.Message + ex.StackTrace);
            }

            finally
            {
                FecharConexao();
            }
        }

        public static string RetornarUmRegistroSemFiltro(string consulta)
        {

            string Retorno = "";
            SqlCommand objcmd = null;

            string sql = consulta;

            try
            {
                objcmd = new SqlCommand(sql, abrirConexao());

                Retorno = Convert.ToString(objcmd.ExecuteScalar());
                FecharConexao();
                return Retorno;
            }

            catch (Exception ex)
            {
                throw new System.ArgumentException(ex.Message + ex.StackTrace);
            }

        }


        public static void deletar(string consulta)
        {


            string sql = consulta;


            SqlCommand objcmd = null;
            objcmd = new SqlCommand(sql, abrirConexao());



            objcmd.ExecuteNonQuery();
            FecharConexao();

        }
        public static bool Update(string consulta)
        {
            string sql = consulta;


            SqlCommand objcmd = null;
            objcmd = new SqlCommand(sql, abrirConexao());



            objcmd.ExecuteNonQuery();
            FecharConexao();
            return true;

        }


        public static DataTable ListarGridComWhere(string consulta)
        {
            string sql = consulta;



            SqlCommand objcmd = null;
            objcmd = new SqlCommand(sql, abrirConexao());

            SqlDataAdapter adp = new SqlDataAdapter(objcmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            FecharConexao();

            return dt;
        }



        public static object ListarGrid(string consulta)
        {
            string sql = consulta;



            SqlCommand objcmd = null;
            objcmd = new SqlCommand(sql, abrirConexao());

            SqlDataAdapter adp = new SqlDataAdapter(objcmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            FecharConexao();

            return dt;
        }




        public static void executaQuery(string query)
        {
            try
            {
                //Instância o sqlcommand com a query sql que será executada e a conexão.
                SqlCommand comando = new SqlCommand(query, abrirConexao());

                //Executa a query sql.
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

    }
}
