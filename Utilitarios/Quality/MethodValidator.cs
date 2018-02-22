using System;
using System.Data;
using System.Data.Common;
using Oracle.DataAccess.Client;
using Utilitarios.Mail;

namespace Utilitarios.Quality
{
    public static class MethodValidator
    {
        #region BUSINESS 

        //public static ValidationResponse ValidateBusinessMethod(Func<object[]> method)
        //{
        //    return MakeBusinessMethodValidation_NoParams(method);
        //}       

        //public static ValidationResponse ValidateBusinessMethod(Func<object[], object[]> method, object[] parameters)
        //{
        //    return MakeBusinessMethodValidation(method, parameters);
        //}

        //private static ValidationResponse MakeBusinessMethodValidation_NoParams(Func<object[]> method)
        //{
        //    var vr = new ValidationResponse();
        //    var errorMode = false;
        //    try
        //    {
        //        if (method != null)
        //        {
        //            var result = method();
        //            if (result != null && result.Length > 0)
        //            {
        //                vr.Exito(result[0]);
        //            }
        //            else
        //            {
        //                vr.Error("Error");
        //                errorMode = true;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        if (errorMode) return vr;
        //        vr.Error(ex.Message);
        //        MailSender.SendErrorMail(ex);
        //    }
        //    return vr;
        //}

        //private static ValidationResponse MakeBusinessMethodValidation(Func<object[], object[]> method,
        //    object[] parameters)
        //{
        //    var vr = new ValidationResponse();
        //    var errorMode = false;
        //    try
        //    {
        //        if (method != null)
        //        {
        //            var result = method(parameters);
        //            if (result != null && result.Length > 0)
        //            {
        //                vr.Exito(result[0]);
        //            }
        //            else
        //            {
        //                vr.Error("Error");
        //                errorMode = true;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        if (errorMode) return vr;
        //        vr.Error(ex.Message);
        //        MailSender.SendErrorMail(ex);
        //    }
        //    return vr;
        //}

        public static ValidationResponse ValidateBusinessMethod(Func<ValidationResponse> method)
        {
            return MakeBusinessMethodValidation_NoParams(method);
        }

        public static ValidationResponse ValidateBusinessMethod(Func<object[], ValidationResponse> method,
            object[] parameters)
        {
            return MakeBusinessMethodValidation(method, parameters);
        }

        private static ValidationResponse MakeBusinessMethodValidation_NoParams(Func<ValidationResponse> method)
        {
            var vr = new ValidationResponse();
            try
            {
                if (method != null)
                {
                    vr = method();
                }
            }
            catch (Exception ex)
            {
                vr.Error(ex.Message);
                MailSender.SendErrorMail(ex);
            }
            return vr;
        }

        private static ValidationResponse MakeBusinessMethodValidation(Func<object[], ValidationResponse> method,
            object[] parameters)
        {
            var vr = new ValidationResponse();
            try
            {
                if (method != null)
                {
                    vr = method(parameters);
                }
            }
            catch (Exception ex)
            {
                vr.Error(ex.Message);
                MailSender.SendErrorMail(ex);
            }
            return vr;
        }

        private static ValidationResponse MakeOracleDataAccessValidation2(Func<object[], object> method, object[] parameters)
        {
            var vr = new ValidationResponse();
            try
            {
                if (method != null)
                {
                    vr = (ValidationResponse)method(parameters);
                }
            }
            catch (Exception ex)
            {
                vr.Error(ex.Message);
                MailSender.SendErrorMail(ex);
            }
            return vr;
        }

        #endregion

        #region DATA ACCESS

        public static ValidationResponse ValidateDataAccess(Func<object[], object> method, object[] parameters)
        {
            return MakeDataAccessValidation(method, parameters);
        }

        //public static ValidationResponse ValidateOracleDataAccess(OracleConnection connection, Func<OracleConnection, object[], object> method, object[] parameters)
        //{
        //    return MakeOracleDataAccessValidation(connection, method, parameters);
        //}

        public static ValidationResponse ValidateDataAccess(Func<object> method)
        {
            return MakeDataAccessMethodValidation_NoParams(method);
        }

        private static ValidationResponse MakeDataAccessValidation(Func<object[], object> method, object[] parameters)
        {
            var vr = new ValidationResponse();
            try
            {
                //abrir conexion
                //iniciar la conexion
                if (method != null)
                {
                    var result = method(parameters);
                    vr.Exito(result);
                }
                //commit
            }
            catch (Exception ex)
            {
                //rollback
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                
                vr.Error(ex.Message);
                MailSender.SendErrorMail(ex);
            }
            return vr;
        }
        //CLEVER
        //private static ValidationResponse MakeOracleDataAccessValidation(OracleConnection connection, Func<OracleConnection, object[], object> method, object[] parameters)
        //{
        //    var vr = new ValidationResponse();
        //    try
        //    {
        //        if (method != null)
        //        {
        //            using (var cnx = connection)
        //            {
        //                // Iniciar la conexion
        //                if (cnx.State != ConnectionState.Open)
        //                    cnx.Open();
        //                // Iniciar la transacción
        //                var tx = cnx.BeginTransaction(IsolationLevel.ReadCommitted);
        //                try
        //                {
        //                    // Ejecutamos la lógica de Acceso a Datos
        //                    var result = method(cnx, parameters);
        //                    vr.Exito(result);
        //                    // Realizamos el Commit
        //                    tx.Commit();
        //                }
        //                catch (Exception ex)
        //                {
        //                    //rollback
        //                    tx.Rollback();
        //                    vr.Error(ex.Message);
        //                    MailSender.SendErrorMail(ex);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        vr.Error(ex.Message);
        //        MailSender.SendErrorMail(ex);
        //    }
        //    return vr;
        //}

        private static ValidationResponse MakeDataAccessMethodValidation_NoParams(Func<object> method)
        {
            var vr = new ValidationResponse();
            try
            {
                if (method != null)
                {
                    var result = method();
                    vr.Exito(result);
                }
            }
            catch (Exception ex)
            {
                vr.Error(ex.Message);
                MailSender.SendErrorMail(ex);
            }
            return vr;
        }

        #endregion
    }
}