using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using System.IO;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Wordprocessing;

namespace MathSol
{
    internal class Users
    {
        private string _name = "";
        private string _username = "";
        private string _password = "";
        private string _image = "";
        private string filePath = "Resources/database.xlsx";



        public Users() { }

        private bool getUser(string searchName)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    // Open the workbook
                    using (var workbook = new XLWorkbook(filePath))
                    {
                        var worksheet = workbook.Worksheet(1); // Assuming data is in the first worksheet

                        // Iterate through rows to find the matching

                        foreach (var row in worksheet.RowsUsed())
                        {
                            // Check if the name in the first column matches the search name
                            if (row.Cell(2).Value.ToString() == searchName)
                            {
                                string name = row.Cell(1).Value.ToString();
                                string userName = row.Cell(2).Value.ToString();
                                string password = row.Cell(3).Value.ToString();
                                string image = row.Cell(4).Value.ToString();

                                Console.WriteLine($"Name: {name},UserName: {userName}, Password: {password}, Image: {image}");
                                this._name = name;
                                this._username = userName;
                                this._password = password;
                                this._image = image;
                                return true;
                            }
                        }


                        // If no matching name is found
                        
                        throw new Exception($"Name '{searchName}' not found.");

                    }
                }
                else
                {
                    
                    throw new Exception("Cannot open file!");
                }
            }
            catch (Exception ex)
            {

                System.Console.WriteLine("Can't get username. Error:\n" + ex);
                return false;
            }
        }

        private void addNewUser(string name, string userName, string password, string image)
        {
            if (File.Exists(filePath))
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1); 
      
                    var firstUnusedRow = worksheet.LastRowUsed().RowNumber() + 1;

                    worksheet.Cell(firstUnusedRow, 1).Value = name;
                    worksheet.Cell(firstUnusedRow, 2).Value = userName;
                    worksheet.Cell(firstUnusedRow, 3).Value = password;
                    worksheet.Cell(firstUnusedRow, 4).Value = image;
                    workbook.SaveAs(filePath);
                    Console.WriteLine("New row added successfully.");
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }

        public bool login(string searchName, string password) {
            getUser(searchName);

            if (this._username != "" && this._password != "" && searchName != "" && password != "")
            {
                if (this._username == searchName && this._password == password)
                {
                    return true;
                }
            }
            

            return false;
        }

        public bool register(string name, string username, string password)
        {
            if(name == null || username == null || password == null) { return false; }
            if (name == "" || username == "" || password == "") { return false; }
            
            
            if (getUser(username))
            {
                return false;
            }
            addNewUser(name, username, password, "default.jpg");

            Console.WriteLine("Register successfully");

            return true;
        }
    }
}
