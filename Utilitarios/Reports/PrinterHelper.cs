using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using Microsoft.Reporting.WebForms;

namespace Utilitarios.Reports
{
    public class PrinterHelper
    {
        private int _mCurrentPageIndex;
        private IList<Stream> _mStreams;

        private void Export(LocalReport report, PageSize pageSize)
        {
            string deviceInfo = GetDeviceInfo(pageSize);
            Warning[] warnings;
            _mStreams = new List<Stream>();

            report.Render("Image", deviceInfo, CreateStream, out warnings);
            foreach (Stream stream in _mStreams)
                stream.Position = 0;
        }

        private string GetDeviceInfo(PageSize pageSize)
        {
            string deviceInfo = null;
            switch (pageSize)
            {
                case PageSize.A3:
                    break;
                case PageSize.A4:
                    deviceInfo =
                        @"<DeviceInfo>
                            <OutputFormat>EMF</OutputFormat>
                            <PageWidth>8.7in</PageWidth>
                            <PageHeight>11.7in</PageHeight>
                            <MarginTop>0in</MarginTop>
                            <MarginLeft>0in</MarginLeft>
                            <MarginRight>0in</MarginRight>
                            <MarginBottom>0in</MarginBottom>
                        </DeviceInfo>";
                    break;
                case PageSize.Oficio:
                    break;
                default:
                    deviceInfo =
                        @"<DeviceInfo>
                            <OutputFormat>EMF</OutputFormat>
                            <PageWidth>8.7in</PageWidth>
                            <PageHeight>11.7in</PageHeight>
                            <MarginTop>0in</MarginTop>
                            <MarginLeft>0in</MarginLeft>
                            <MarginRight>0in</MarginRight>
                            <MarginBottom>0in</MarginBottom>
                        </DeviceInfo>";
                    break;
            }
            return deviceInfo;
        }

        private Stream CreateStream(string name, string fileNameExtension, Encoding encoding, string mimeType,
            bool willSeek)
        {
            Stream stream = new MemoryStream();
            _mStreams.Add(stream);
            return stream;
        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            Metafile pageImage = new Metafile(_mStreams[_mCurrentPageIndex]);
            Rectangle adjustedRect = new Rectangle(ev.PageBounds.Left - (int) ev.PageSettings.HardMarginX,
                ev.PageBounds.Top - (int) ev.PageSettings.HardMarginY, ev.PageBounds.Width, ev.PageBounds.Height);
            ev.Graphics.FillRectangle(Brushes.White, adjustedRect);
            ev.Graphics.DrawImage(pageImage, adjustedRect);
            _mCurrentPageIndex++;
            ev.HasMorePages = (_mCurrentPageIndex < _mStreams.Count);
        }

        private void Print()
        {
            if (_mStreams == null || _mStreams.Count == 0)
                throw new Exception("Error: no stream to print.");
            PrintDocument printDoc = new PrintDocument();
            if (!printDoc.PrinterSettings.IsValid)
            {
                throw new Exception("Error: cannot find the default printer.");
            }
            else
            {
                printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
                _mCurrentPageIndex = 0;
                printDoc.Print();
            }
        }

        public void PrintDocument(LocalReport localReport, PageSize pageSize)
        {
            Export(localReport, pageSize);
            Print();
        }
    }
}