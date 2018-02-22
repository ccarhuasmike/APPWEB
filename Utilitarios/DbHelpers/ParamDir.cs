using System.Data;

namespace Utilitarios.DbHelpers
{
    public enum ParamDir
    {
        Out = ParameterDirection.Output,
        In = ParameterDirection.Input,
        InOut = ParameterDirection.InputOutput,
        Rv = ParameterDirection.ReturnValue
    }
}
