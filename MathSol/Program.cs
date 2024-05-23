using ClosedXML.Excel;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace MathSol
{
    internal static class Program
    {
        #region checkDbIfNotExist
        static void checkDataBaseIfNotExist()
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
        #endregion


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            checkDataBaseIfNotExist();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm myLgoinForm = new LoginForm();
            /*myLgoinForm.Show();*/
            Application.Run(myLgoinForm);
        }
    }


}
