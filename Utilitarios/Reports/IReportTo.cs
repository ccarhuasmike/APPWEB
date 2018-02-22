using System.Web.Mvc;

namespace Utilitarios.Reports
{
    interface IReportTo
    {
        FileContentResult Export(object reportModel, PageSize pageSizes);
        void Print(object reportModel, PageSize pageSize);

        FileContentResult Export(object reportModel, double pageWidth, double pageHeight, double marginTop,
            double marginBottom, double marginLeft, double marginRight);
    }
}
