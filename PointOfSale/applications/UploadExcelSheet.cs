using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.applications
{
    class UploadExcelSheet
    {
        public string[] getUploadFilePath(String path)
        {

            Microsoft.Office.Interop.Excel.Application xlsApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlsApp == null)
            {
                Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.");
                //    return null;
            }

            //Displays Excel so you can see what is happening
            //xlsApp.Visible = true;
        //    listView1.CheckBoxes = true;
            Workbook wb = xlsApp.Workbooks.Open(path, 0, true, 5, "", "", true, XlPlatform.xlWindows, "\t", false, false, 0, true);
            Sheets sheets = wb.Worksheets;
            Worksheet ws = (Worksheet)sheets.get_Item(1);

            Range firstColumn = ws.Cells[1, 1].EntireRow;
            System.Array myvalues = (System.Array)firstColumn.Cells.Value;
            string[] strArray = myvalues.OfType<object>().Select(o => o.ToString()).ToArray();
            Debug.WriteLine(strArray);
            Debug.WriteLine("My Size" + myvalues.Length);
            return strArray;
        }
    }
}
