using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClosedXML.Excel;
using System.IO;
using System.Threading.Tasks;

namespace MathSol
{
    internal class publicFunction
    {
        public void checkDataBaseIfNotExist()
        {
            string filePath = "Resources/database.xlsx";
            if (!File.Exists(filePath))
            {
                // Create a new workbook and worksheet
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Sheet1");

                    // Add column headers
                    worksheet.Cell(1, 1).Value = "name";
                    worksheet.Cell(1, 1).Value = "userName";
                    worksheet.Cell(1, 2).Value = "password";
                    worksheet.Cell(1, 3).Value = "image";

                    // Save the workbook
                    workbook.SaveAs(filePath);
                }

                System.Console.WriteLine("File created successfully.");
            }
            else
            {
                System.Console.WriteLine("File already exists.");
            }
        }

        public void getUserName()
        {
            string filePath = "Resources/database.xlsx";
            if (!File.Exists(filePath))
            {
                // Create a new workbook and worksheet
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Sheet1");

                    // Add column headers
                    worksheet.Cell(1, 1).Value = "name";
                    worksheet.Cell(1, 1).Value = "userName";
                    worksheet.Cell(1, 2).Value = "password";
                    worksheet.Cell(1, 3).Value = "image";

                    // Save the workbook
                    workbook.SaveAs(filePath);
                }

                System.Console.WriteLine("File created successfully.");
            }
            else
            {
                System.Console.WriteLine("File already exists.");
            }
        }
    }
}
