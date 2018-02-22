using System.Reflection;
using System.Security;
using System.Security.Permissions;
using Microsoft.Reporting.WebForms;

namespace Utilitarios.Reports
{
    public class ReportParametersInitiliazer
    {
        public void InitParameters(LocalReport localReport, object o)
        {            
            PropertyInfo[] props = o.GetType().GetProperties();
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            foreach (PropertyInfo prop in props)
            {
                var nombre = prop.Name;
                var value = prop.GetValue(o, null);
                reportParameters.Add(new ReportParameter(nombre, "" + value));
            }
            localReport.SetParameters(reportParameters);
            localReport.SetBasePermissionsForSandboxAppDomain(new PermissionSet(PermissionState.Unrestricted));
        }
    }
}