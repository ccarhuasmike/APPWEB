using System.Data;
using Oracle.DataAccess.Client;
using Utilitarios.Converters;

namespace Utilitarios.DbHelpers
{
    public class OracleDbHelper : DataUtil
    {
        #region VARIABLES DE AYUDA

        protected OracleDbType Int32
        {
            get { return OracleDbType.Int32; }
        }

        protected OracleDbType Varchar2
        {
            get { return OracleDbType.Varchar2; }
        }

        protected OracleDbType Char
        {
            get { return OracleDbType.Char; }
        }

        protected OracleDbType Date
        {
            get { return OracleDbType.Date; }
        }

        protected OracleDbType Double
        {
            get { return OracleDbType.Double; }
        }

        protected OracleDbType Decimal
        {
            get { return OracleDbType.Decimal; }
        }

        protected OracleDbType RefCursor
        {
            get { return OracleDbType.RefCursor; }
        }

        protected OracleDbType Clob
        {
            get { return OracleDbType.Clob; }
        }

        protected ParameterDirection In
        {
            get { return ParameterDirection.Input; }
        }

        protected ParameterDirection Out
        {
            get { return ParameterDirection.Output; }
        }

        protected ParameterDirection InOut
        {
            get { return ParameterDirection.InputOutput; }
        }

        protected ParameterDirection Rv
        {
            get { return ParameterDirection.ReturnValue; }
        }

        #endregion

        private OracleCommand _command;

        protected OracleCommand Cmd
        {
            set { _command = value; }
            get
            {
                _command.CommandType = CommandType.StoredProcedure;
                return _command;
            }
        }

        protected string PkgName { set; get; }

        protected OracleCommand AddInParam(string name, OracleDbType type, dynamic value)
        {
            Cmd.Parameters.Add(name, type).Value = value;
            return Cmd;
        }

        protected OracleCommand AddInParam(string name, OracleDbType type, dynamic value, int size = 4000)
        {
            Cmd.Parameters.Add(
                new OracleParameter
                {
                    Value = value,
                    OracleDbType = type,
                    Direction = In,
                    Size = size,
                    ParameterName = name
                }
            );
            return Cmd;
        }

        protected OracleCommand AddInOutParam(string name, OracleDbType type, dynamic value,int size = 4000)
        {
            Cmd.Parameters.Add(
                new OracleParameter
                {
                    Value = value, 
                    OracleDbType = type, 
                    Direction = InOut,
                    Size = size,
                    ParameterName = name
                }
            );
            return Cmd;
        }

        protected OracleCommand AddOutParam(string name, OracleDbType type)
        {
            Cmd.Parameters.Add(name, type).Direction = Out;
            return Cmd;
        }

        protected OracleCommand AddOutParam(string name, OracleDbType type, int size = 4000)
        {
            Cmd.Parameters.Add(new OracleParameter
            {
                OracleDbType = type,
                Direction = Out,
                Size = size,
                ParameterName = name
            });

            return Cmd;
        }

        protected void Open(OracleConnection cnx)
        {
            if (cnx.State != ConnectionState.Open)
                cnx.Open();
        }

        protected void Close(OracleConnection cnx)
        {
            cnx.Close();
        }

        protected string GetReturnValue(string name)
        {
            return Cmd.Parameters[name].Value.ToString();
        }

        protected int ExecuteNonQuery()
        {
            return Cmd.ExecuteNonQuery();
        }

        protected OracleDataReader ExecuteReader()
        {
            return Cmd.ExecuteReader();
        }
    }
}