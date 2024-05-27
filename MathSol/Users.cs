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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;

namespace MathSol
{
    internal class Users
    {
        private string _name = "";
        private string _username = "";
        private string _password = "";
        private string _image = "";
        private string filePath = "Resources/database.xlsx";

        public string Name { get => _name; set => _name = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Image { get => _image; set => _image = value; }

        public Users() { }

        private bool getUser(string searchName)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (var workbook = new XLWorkbook(filePath))
                    {
                        var worksheet = workbook.Worksheet(1); 

                        foreach (var row in worksheet.RowsUsed())
                        {
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

        public bool updateUser(string searchName, string newPassword)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (var workbook = new XLWorkbook(filePath))
                    {
                        var worksheet = workbook.Worksheet(1);
                        int count = 1;
                        foreach (var row in worksheet.RowsUsed())
                        {
                            if (row.Cell(2).Value.ToString() == searchName)
                            {
                                worksheet.Cell(count, 3).Value = newPassword;
                                workbook.SaveAs(filePath);
                                Console.WriteLine("Update successfully.");

                                this._password = newPassword;
                                return true;

                            }
                            count++;
                        }
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

                System.Console.WriteLine("Can't update user. Error:\n" + ex);
                return false;
            }
        }

        public bool updateImage(string searchName , string image)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    using (var workbook = new XLWorkbook(filePath))
                    {
                        var worksheet = workbook.Worksheet(1);
                        int count = 1;
                        foreach (var row in worksheet.RowsUsed())
                        {
                            if (row.Cell(2).Value.ToString() == searchName)
                            {
                                worksheet.Cell(count, 4).Value = image;
                                workbook.SaveAs(filePath);
                                Console.WriteLine("Update successfully.");

                                this._image = image;
                                return true;
                            }
                            count++;
                        }
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

                System.Console.WriteLine("Can't update user. Error:\n" + ex);
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
