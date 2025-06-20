using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Text;



namespace SERCCS.Includes
{
    public class DBConfig
    {
        //2,147,483,647(max pool size limit)
        // ccs main 
        //static string oradb = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST =PDC)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME =ORACLE)));User Id= iccs_se;Password=dvision; Connection Timeout=6000;Min Pool Size=5;Max Pool Size=500;";
        static string oradb = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST =192.168.137.1)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME =ORCL)));User Id= iccs_se;Password=dvision; Connection Timeout=6000;Min Pool Size=5;Max Pool Size=500;";
        //ccs Static
        //static string oradb = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = 202.142.95.138)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME =ORACLE)));User Id= iccs;Password=dvision; Connection Timeout=6000;Min Pool Size=5;Max Pool Size=500;";
        //rishi
         //static string oradb = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST =192.168.137.1)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME =ORCL)));User Id= iccs;Password=dvision;Connection Timeout=6000;Min Pool Size=5;Max Pool Size=500;";
       // This Pc
       //static string oradb = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST =192.168.137.92)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME =ORCL)));User Id= iccs;Password=dvision;Connection Timeout=6000;Min Pool Size=5;Max Pool Size=500;";
       //ccs 2nd
       //static string oradb = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST =192.50.40.8)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME =ORCL)));User Id= iccs;Password=dvision;Connection Timeout=6000;Min Pool Size=5;Max Pool Size=500;";
       //static string oradb = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST =115.187.62.28)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME =ORCL)));User Id= iccs;Password=dvision;Connection Timeout=6000;Min Pool Size=5;Max Pool Size=500;";
       //static string oradb = "Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST =115.187.62.28)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME =ORCL)));User Id= iccs;Password=dvision;Connection Timeout=6000;Min Pool Size=5;Max Pool Size=500;";


        public OracleConnection con;
        private OracleCommand cmd;
        private OracleDataAdapter da;
        public DataTable dt;
        int result;
        object lastInsertID;
        private OracleConnection OpenConnection()
        {
            if (this.con != null) con = null;// return con;

            this.con = new OracleConnection(oradb);
            try
            {
                con.Open();
                return con;
            }
            catch (OracleException ex)
            {
                throw new Exception("Unable to connect with database host. - " + ex.Message);
            }
        }

        public void Read(string sql, Dictionary<string, object> values, Action<IDataReader> rowReader, long startIndex = 0, long pageSize = 0)
        {

            OpenConnection();
            {
                using (var command = new OracleCommand(sql, con))
                {
                    if (values != null)
                    {
                        foreach (KeyValuePair<String, object> value in values)
                        {
                            if (value.Value == null)
                                command.Parameters.Add(new OracleParameter(value.Key, DBNull.Value));
                            else
                                command.Parameters.Add(new OracleParameter(value.Key, value.Value));
                        }
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        long idx = 0;
                        long finIdx = startIndex + pageSize - 1;
                        while (reader.Read())
                        {
                            if (pageSize != 0 && (idx < startIndex || idx > finIdx)) { idx++; continue; }
                            rowReader(reader);
                            idx++;
                        }
                        reader.Close();
                    }
                }
            }
        }

        public object ReadScalar(string sql, Dictionary<string, object> values = null)
        {
            OpenConnection();
            {
                using (var command = new OracleCommand(sql, con))
                {
                    if (values != null)
                    {
                        foreach (KeyValuePair<String, object> value in values)
                        {
                            if (value.Value == null)
                                command.Parameters.Add(new OracleParameter(value.Key, DBNull.Value));
                            else
                                command.Parameters.Add(new OracleParameter(value.Key, value.Value));
                        }
                    }
                    return command.ExecuteScalar();
                }
            }
        }



        public void Execute_Query(string sql)
        {
            try
            {
                OpenConnection();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public int Execute_Query_WithRetValue(string sql)
        {
            try
            {
                con.Open();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                string MSG = Convert.ToString(ex);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }

            return result;
        }

        public DataTable Load_DTG(string sql)
        {
            try
            {
                OpenConnection();
                cmd = new OracleCommand();
                da = new OracleDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);



            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
                con.Dispose();
            }

            return dt;
        }

       
        public void singleResult(string sql)

        {
            try
            {
                OpenConnection();
                cmd = new OracleCommand();
                da = new OracleDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                cmd.CommandTimeout = 6000;
                da.SelectCommand = cmd;

                da.Fill(dt);

            }
            catch (Exception ex)
            {
                throw new Exception("Unable to connect with database host. - " + ex.Message);
                //throw ex.Message.ToString();
                //  MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                if (da != null) da.Dispose();
                con.Dispose();
            }

        }

        public void loadReports(string sql)

        {
            try
            {
                con.Open();
                cmd = new OracleCommand();
                da = new OracleDataAdapter();
                dt = new DataTable();


                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                da.Dispose();
                con.Dispose();
            }
        }

        public object ReturnScalar(Hashtable hs, string StorProcName)
        {
            //  SqlCommand com = null;
            try
            {

                cmd = new OracleCommand(StorProcName);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (System.Collections.DictionaryEntry di in hs)
                    cmd.Parameters.Add("@" + di.Key.ToString(), di.Value);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                // LogErrorsInDB(ex.Message);
                return -1;
            }
            finally
            {
                cmd.Dispose();
            }
        }
        public DataTable ReturnScalar(string StorProcName, Hashtable hs)
        {
            //  SqlCommand com = null;
            try
            {
                da = new OracleDataAdapter();
                dt = new DataTable();
                con.Open();
                cmd = new OracleCommand(StorProcName, con);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (System.Collections.DictionaryEntry di in hs)
                    cmd.Parameters.Add("@" + di.Key.ToString(), di.Value);
                //  cmd.ExecuteScalar();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                // LogErrorsInDB(ex.Message);
                dt = null;
                return dt;
            }
            finally
            {
                con.Close();
                da.Dispose();
                cmd.Dispose();
            }
        }

        public OracleDataReader ReturnScalar(string StorProcName, DataTable dt)
        {
            OracleDataReader reader;
            //  SqlCommand com = null;
            try
            {
                cmd = GetStoredProc(StorProcName);
                cmd.Parameters.Add("@tblDepents", dt);
                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                // LogErrorsInDB(ex.Message);
                return null;
            }
            finally
            {
                cmd.Dispose();
            }
        }


     
        public DataTable ReturnScalar(String qry, string StorProcName)
        {
            OracleDataReader reader;
            //  SqlCommand com = null;
            try
            {
                da = new OracleDataAdapter();
                dt = new DataTable();
                //con.Open();
                //cmd = new SqlCommand(StorProcName, con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd = GetStoredProc(StorProcName);
                cmd.Parameters.Add("@qry", qry);
                // return cmd.ExecuteReader();
                //  Message = "Incorrect syntax near 'UPADATE labourmaster set balsickleavedays=11, coincf=5 Where id=2;'."
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                // LogErrorsInDB(ex.Message);
                dt = null;
                return dt;
            }
            finally
            {
                cmd.Dispose();
            }
        }
        public OracleDataReader ReturnScalar(string sql)
        {
            // OracleDataReader reader;
            //  SqlCommand com = null;
            try
            {
                OpenConnection();
                cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = sql;

                return cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                // LogErrorsInDB(ex.Message);
                return null;
            }
            finally
            {
                cmd.Dispose();
            }
        }




       
        public OracleCommand GetStoredProc(string sProcName)
        {
            // if (!bOpen) Connect();

            try
            {
                OpenConnection();
                cmd = new OracleCommand(sProcName, con);
                cmd.CommandType = CommandType.StoredProcedure;		// Mark the Command as a SPROC
                return cmd;
            }
            catch (Exception ex)
            {
                // LogErrorsInDB(ex.Message);
                return null;
            }
        }



        public int Insert(string tableName, Dictionary<string, object> fieldValues)
        {
            string[] fields = fieldValues.Keys.ToArray();
            StringBuilder insertFieldsStr = new StringBuilder();
            StringBuilder insertParamsStr = new StringBuilder();
            for (int i = 0; i < fields.Length; i++)
            {
                insertFieldsStr.AppendFormat("{0},", fields[i]);
                insertParamsStr.AppendFormat(":{0},", fields[i]);
            }

            var fieldParams = new Dictionary<string, object>(fieldValues);
            string sql = string.Format("INSERT INTO {0} ({1}) VALUES({2})", tableName, insertFieldsStr.ToString().TrimEnd(','), insertParamsStr.ToString().TrimEnd(','));
            return Execute(sql, fieldParams);
        }



        public int Execute(string sql, Dictionary<string, object> paramValues)
        {
           
                OpenConnection();
                {
                    using (var command = new OracleCommand(sql, con))
                    {
                        foreach (KeyValuePair<String, object> value in paramValues)
                        {
                            if (value.Value == null)
                                command.Parameters.Add(new OracleParameter(value.Key, DBNull.Value));
                            else
                                command.Parameters.Add(new OracleParameter(value.Key, value.Value));
                        }

                        var result = command.ExecuteNonQuery();
                        if (sql.IndexOf("INSERT") == 0 && result > 0)
                        {
                            //       command.Parameters.Clear();
                            //     command.CommandText = $"SELECT LAST_INSERT_ID()";
                            //     lastInsertID = command.ExecuteScalar();
                        }
                        return result;
                    }
                }
           
           
            //con.Open();
           
        }



        public int Update(string tableName, Dictionary<string, object> fieldValues, Dictionary<string, object> criteriaValues = null)
        {
            string[] fields = fieldValues.Keys.ToArray();
            StringBuilder updateFieldsStr = new StringBuilder();
            for (int i = 0; i < fields.Length; i++)
                updateFieldsStr.AppendFormat("{0}=:{0},", fields[i]);

            var fieldParams = new Dictionary<string, object>(fieldValues);
            var crfieldParams = new Dictionary<string, object>();

            StringBuilder criteriaStr = new StringBuilder();
            if (criteriaValues != null)
            {
                criteriaStr.Append(" WHERE ");
                string[] crfields = criteriaValues.Keys.ToArray();
                for (int i = 0; i < crfields.Length; i++)
                {
                    if (i > 0) criteriaStr.Append(" AND ");
                    criteriaStr.AppendFormat("{0}=:{0}", crfields[i]);
                    crfieldParams.Add(crfields[i], criteriaValues[crfields[i]]);
                }
            }

            string sql = string.Format("UPDATE {0} SET {1} {2}", tableName, updateFieldsStr.ToString().TrimEnd(','), criteriaStr.ToString());
            return ExecuteUpdate(sql, fieldParams, crfieldParams);
        }

        public int ExecuteUpdate(string sql, Dictionary<string, object> paramValues, Dictionary<string, object> crParamValues)
        {



            OpenConnection();
            {
                using (var command = new OracleCommand(sql, con))
                {
                    foreach (KeyValuePair<String, object> value in paramValues)
                    {
                        if (value.Value == null)
                            command.Parameters.Add(new OracleParameter(value.Key, DBNull.Value));
                        else
                            command.Parameters.Add(new OracleParameter(value.Key, value.Value));
                    }
                    foreach (KeyValuePair<String, object> value in crParamValues)
                    {
                        if (value.Value == null)
                            command.Parameters.Add(new OracleParameter(value.Key, DBNull.Value));
                        else
                            command.Parameters.Add(new OracleParameter(value.Key, value.Value));
                    }

                    var result = command.ExecuteNonQuery();
                    if (sql.IndexOf("INSERT") == 0 && result > 0)
                    {
                        //command.Parameters.Clear();
                        //command.CommandText = $"SELECT LAST_INSERT_ID()";
                        //lastInsertID = command.ExecuteScalar();
                    }

                }
            }



            return result;
        }


        


        public int Delete(string tableName, Dictionary<string, object> criteriaValues = null)
        {
            var fieldParams = new Dictionary<string, object>();

            StringBuilder criteriaStr = new StringBuilder();
            if (criteriaValues != null)
            {
                criteriaStr.Append(" WHERE ");
                var fields = criteriaValues.Keys.ToArray();
                for (int i = 0; i < fields.Length; i++)
                {
                    if (i > 0) criteriaStr.Append(" AND ");
                    criteriaStr.AppendFormat("{0}=:{0}", fields[i]);
                    fieldParams.Add(fields[i], criteriaValues[fields[i]]);
                }
            }

            string sql = string.Format("DELETE FROM {0} {1}", tableName, criteriaStr.ToString());
            return Execute(sql, fieldParams);
        }

        public int InsertOrUpdateOnDuplicate(string tableName, Dictionary<string, object> fieldValues, string[] uniqueColumns)
        {
            string[] fields = fieldValues.Keys.ToArray();
            StringBuilder insertFieldsStr = new StringBuilder();
            StringBuilder insertParamsStr = new StringBuilder();
            StringBuilder updateParamsStr = new StringBuilder();
            for (int i = 0; i < fields.Length; i++)
            {
                insertFieldsStr.AppendFormat("{0},", fields[i]);
                insertParamsStr.AppendFormat(":{0},", fields[i]);
                if (!uniqueColumns.Contains(fields[i]))
                {
                    updateParamsStr.AppendFormat("{0}=VALUES({0}),", fields[i]);
                }
            }

            //var fieldParams = new Dictionary<string, object>(fieldValues);
            string sql = string.Format("INSERT INTO {0} ({1}) VALUES({2}) ON DUPLICATE KEY UPDATE {3}",
                tableName, insertFieldsStr.ToString().TrimEnd(','), insertParamsStr.ToString().TrimEnd(','), updateParamsStr.ToString().TrimEnd(','));
            return Execute(sql, fieldValues);
        }
        public object GetLastInsertID()
        {
            if (lastInsertID != null && !(lastInsertID is System.DBNull))
                return lastInsertID;

            return null;
        }

        public void Dispose()
        {
            if (con != null && con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
