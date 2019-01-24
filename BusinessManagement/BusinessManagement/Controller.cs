using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;


namespace BusinessManagement
{
    class Controller
    {
        //Controls the amount of encryption garbage characters between each letter
        const int MAX = 33;
        private string pathName;
        private List<Employee> employees;

        public Controller(string path)
        {
            pathName = path;
            employees = LoadFile();
        }

        public List<Employee> GetAllEmployees()
        {
            employees = LoadFile();
            return employees;
        }

        public bool isEmpty()
        {
            if (employees.Count == 0)
                return true;
            else
                return false;
        }

        public void FirstOpen(string firstName, string lastName, string idNumber, string position, 
            string department, string username, string password)
        {
            Employee e = new Employee(firstName, lastName, idNumber, position, department, "", username, password, true);
            File.WriteAllText(pathName, "");
        }

        public void SaveToFile()
        {
            try
            {
                //Create a FileStream
                FileStream filestream = File.Create(pathName);

                //Create a new instance of the RijndaelManaged class  
                // and encrypt the stream.  
                RijndaelManaged RMCrypto = new RijndaelManaged();

                byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
                byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };

                //Create a CryptoStream, pass it the NetworkStream, and encrypt   
                //it with the Rijndael class.  
                CryptoStream CryptStream = new CryptoStream(filestream,
                RMCrypto.CreateEncryptor(Key, IV),
                CryptoStreamMode.Write);

                //Create a StreamWriter for easy writing to the   
                //network stream.  
                StreamWriter SWriter = new StreamWriter(CryptStream);

                //Write to the stream.  
                foreach(Employee e in employees)
                {
                    SWriter.Write(e.username + '%');
                    SWriter.Write(e.password + '%');
                    SWriter.Write(e.firstName + '%');
                    SWriter.Write(e.lastName + '%');
                    SWriter.Write(e.idNumber + '%');
                    SWriter.Write(e.position + '%');
                    SWriter.Write(e.department + '%');
                    SWriter.Write(e.numberOfWriteups + '%');
                    SWriter.Write(e.isAdmin);
                    SWriter.Write('%' + Environment.NewLine);
                }

                //Inform the user that the message was written  
                //to the stream.  
                Console.WriteLine("File saved.");

                //Close all the connections.  
                SWriter.Close();
                CryptStream.Close();
                filestream.Close();
            }
            catch
            {
                //Inform the user that an exception was raised.  
                Console.WriteLine("The saving failed.");
            }
        }

        public List<Employee> LoadFile()
        {
            Employee e;
            string value = "";
            string line;
            List<Employee> employeeList = new List<Employee>();
            //The key and IV must be the same values that were used  
            //to encrypt the stream.    
            byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
            byte[] IV = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
            try
            {
                FileStream filestream = File.OpenRead(pathName);
                //Create a new instance of the RijndaelManaged class  
                // and decrypt the stream.  
                RijndaelManaged RMCrypto = new RijndaelManaged();

                //Create a CryptoStream, pass it the NetworkStream, and decrypt   
                //it with the Rijndael class using the key and IV.  
                CryptoStream CryptStream = new CryptoStream(filestream,
                   RMCrypto.CreateDecryptor(Key, IV),
                   CryptoStreamMode.Read);

                //Read the stream.  
                StreamReader SReader = new StreamReader(CryptStream);
                
                //Load the file
                while (!SReader.EndOfStream)
                {
                    e = new Employee();
                    line = SReader.ReadLine();
                    for (int i = 0; i < line.Length; ++i)
                    {
                        if (line[i] == '%' && e.username == "")
                        {
                            e.username = value;
                            value = "";
                        }
                        else if (line[i] == '%' && e.password == "")
                        {
                            e.password = value;
                            value = "";
                        }
                        else if (line[i] == '%' && e.firstName == "")
                        {
                            e.firstName = value;
                            value = "";
                        }
                        else if (line[i] == '%' && e.lastName == "")
                        {
                            e.lastName = value;
                            value = "";
                        }
                        else if (line[i] == '%' && e.idNumber == "")
                        {
                            e.idNumber = value;
                            value = "";
                        }
                        else if (line[i] == '%' && e.position == "")
                        {
                            e.position = value;
                            value = "";
                        }
                        else if (line[i] == '%' && e.department == "")
                        {
                            e.department = value;
                            value = "";
                        }
                        else if (line[i] == '%' && e.numberOfWriteups == "")
                        {
                            e.numberOfWriteups = value;
                            value = "";
                        }
                        else if (line[i] == '%')
                        {
                            if (value == "True")
                                e.isAdmin = true;
                            else
                                e.isAdmin = false;
                            value = "";
                        }
                        else
                            value += line[i];
                    }
                    employeeList.Add(e);
                }

                //Close the streams
                SReader.Close();
                filestream.Close();
                return employeeList;
            }
            //Catch any exceptions.   
            catch
            {
                Console.WriteLine("Loading file failed.");
                return new List<Employee>();
            }
        }

        public void AddEmployee(Employee e)
        {
            employees.Add(e);
        }

        public void RemoveEmployee(Employee e)
        {
            employees.Remove(e);
        }

        public Employee FindEmployee(string id)
        {
            foreach (Employee e in employees)
            {
                if (e.idNumber == id)
                    return e;
            }
            return new Employee();
        }
    }
}