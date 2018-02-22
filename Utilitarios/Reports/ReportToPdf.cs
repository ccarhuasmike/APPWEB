using System;
using System.Text;
using System.Web.Mvc;
using Microsoft.Reporting.WebForms;

namespace Utilitarios.Reports
{
    public class ReportToPdf : Controller, IReportTo
    {
        private readonly PrinterHelper _printerHelper = new PrinterHelper();
        private readonly ReportParametersInitiliazer _parametersInitiliazer = new ReportParametersInitiliazer();
        private readonly LocalReport _localReport;

        public LocalReport GetLocalReport()
        {
            return _localReport;
        }
        public ReportToPdf(string reportServerPath)
        {
            _localReport = new LocalReport {ReportPath = reportServerPath};
        }
        public FileContentResult Export(object reportModel, double pageWidth, double pageHeight, double marginTop,
            double marginBottom, double marginLeft, double marginRight)
        {
            try
            {            
            _parametersInitiliazer.InitParameters(_localReport, reportModel);
            const string reportType = "PDF";
            string mimeType, encoding, fileNameExtension;
            StringBuilder deviceInfo =new StringBuilder();
            Warning[] warnings;
            string[] streams;

            deviceInfo.Append("<DeviceInfo>");
            deviceInfo.Append("<OutputFormat>PDF</OutputFormat>");
            deviceInfo.Append("<PageWidth>" + pageWidth + "in</PageWidth><PageHeight>" + pageHeight + "in</PageHeight>");
            deviceInfo.Append("<MarginTop>" + marginTop + "in</MarginTop><MarginLeft>" + marginLeft + "in</MarginLeft>");
            deviceInfo.Append("<MarginRight>" + marginRight + "in</MarginRight><MarginBottom>" + marginBottom + "in</MarginBottom></DeviceInfo>");            

            var renderedBytes = _localReport.Render(reportType, deviceInfo.ToString(), out mimeType, out encoding, out fileNameExtension, out streams, out warnings);
            return File(renderedBytes, "application/pdf");
            }
            catch (Exception ex)
            {
                return new FileContentResult(null, "application/pdf");
            }
        }

        public FileContentResult Export(object reportModel, PageSize pageSizes)
        {
            switch (pageSizes)
            {
                case PageSize.A3:
                    return null;
                case PageSize.A4:
                    return Export(reportModel, 8.7, 11.7, 0, 0, 0, 0);
                case PageSize.Oficio:
                    return null;
                default:
                    return null;
            }
        }

        public void Print(object reportModel, PageSize pageSize)
        {
            _printerHelper.PrintDocument(_localReport, pageSize);
        }
    }
}