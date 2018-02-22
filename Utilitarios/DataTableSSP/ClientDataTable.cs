using System;
using System.Linq;
using System.Reflection;

namespace Utilitarios.DataTableSSP
{
    public class ClientDataTable
    {
        public static int GetPage(DataTableSsp datatable)
        {
            var start = datatable.start;
            var length = datatable.length;
            var page = (start == 0) ? 1 : (start / length) + 1;

            return page;
        }

        public static int GetLength(DataTableSsp datatable)
        {
            var length = datatable.length;

            return length;
        }

        public static object SetDataTable(DataTableSsp datatable, object[] dataResult)
        {
            var draws = datatable.draw;
            var total = 0;
            if (dataResult.Length != 0)
                total = (int)GetTotalRegistros(dataResult[0]);
            return new { draw = draws, recordsFiltered = total, recordsTotal = total, data = dataResult };
        }

        public static object Bind(DataTableSsp datatable, Func<int, int, string, object[]> method)
        {
            var draws = datatable.draw;
            var start = datatable.start;
            var length = datatable.length;
            var page = (start == 0) ? 1 : (start / length) + 1;
            var dataResult = method(page, length, datatable.search.value);
            var total = 0;
            if (dataResult.Length != 0)
                total = (int)GetTotalRegistros(dataResult[0]);
            return new { draw = draws, recordsFiltered = total, recordsTotal = total, data = dataResult };
        }

        public static object Bind(DataTableSsp datatable, Func<int, string, int, int, object[]> method,
            object extraParameter)
        {
            var draws = datatable.draw;
            var start = datatable.start;
            var length = datatable.length;
            var page = (start == 0) ? 1 : (start/length) + 1;
            var dataResult = method((int) extraParameter, datatable.search.value, page, length);
            var total = 0;
            if (dataResult.Length != 0)
                total = (int) GetTotalRegistros(dataResult[0]);
            return new {draw = draws, recordsFiltered = total, recordsTotal = total, data = dataResult};
        }
        public static object Bind(DataTableSsp datatable, Func<string, string, int, int, object[]> method,
            object extraParameter)
        {
            var draws = datatable.draw;
            var start = datatable.start;
            var length = datatable.length;
            var page = (start == 0) ? 1 : (start / length) + 1;
            var dataResult = method((string)extraParameter, datatable.search.value, page, length);
            var total = 0;
            if (dataResult.Length != 0)
                total = (int)GetTotalRegistros(dataResult[0]);
            return new { draw = draws, recordsFiltered = total, recordsTotal = total, data = dataResult };
        }
        public static object Bind(DataTableSsp datatable, object[] data)
        {
            var draws = datatable.draw;            
            var dataResult = data;
            var total = 0;
            if (dataResult.Length != 0)
                total = (int)GetTotalRegistros(dataResult[0]);
            return new { draw = draws, recordsFiltered = total, recordsTotal = total, data = dataResult };
        }

        private static object GetTotalRegistros(object o)
        {
            var total = -1;
            var props = o.GetType().GetProperties();
            foreach (var prop in props.Where(prop => prop.Name == "TotalRegisters"))
            {
                total = int.Parse(prop.GetValue(o, null).ToString());
            }
            return total;
        }
    }
}