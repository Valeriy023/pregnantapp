using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Test;
using System.Runtime.Remoting.Contexts;
using System.Data;
using System.Collections.Generic;

namespace Repository
{
    public class DBrepository
    {
        public DBrepository()
        {

        }

        public void createDB()
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
            {
                string commandText1 = "CREATE TABLE IF NOT EXISTS Patients (ID INTEGER NOT NULL, Имя TEXT NOT NULL,Фамилия   TEXT NOT NULL,Отчество  TEXT,Телефон  TEXT NOT NULL,Дата_рождения TEXT NOT NULL,Полис_ОМС TEXT NOT NULL,PRIMARY KEY(ID AUTOINCREMENT))";
                string commandText2 = "CREATE TABLE LabAnalysis (ID_пациента INTEGER NOT NULL, ID_обследования INTEGER NOT NULL, B12 TEXT NOT NULL, B9 TEXT NOT NULL,  Гемоглобин TEXT NOT NULL, FOREIGN KEY(ID_пациента) REFERENCES Patients(ID), PRIMARY KEY(ID_обследования AUTOINCREMENT))";
                string commandText3 = "CREATE TABLE InstAnalysis (ID_пациента INTEGER NOT NULL, ID_обследования INTEGER NOT NULL, КТГ TEXT, FOREIGN KEY(ID_пациента) REFERENCES Patients(ID), PRIMARY KEY(ID_обследования AUTOINCREMENT))";
                string commandText4 = "CREATE TABLE Settings (ID INTEGER NOT NULL PRIMARY KEY CHECK (ID = 1),B12_норм TEXT, B9_норм TEXT,Гемоглобин_норм TEXT )";
                //string commandText3 = "CREATE TABLE InstAnalysis (ID_пациента INTEGER NOT NULL, ID_обследования INTEGER NOT NULL, ЧСС_плода TEXT, Активность_матки TEXT, Температура INTEGER, АД INTEGER, FOREIGN KEY(ID_пациента) REFERENCES Patients(ID), PRIMARY KEY(ID_обследования AUTOINCREMENT))";
                SQLiteCommand Command1 = new SQLiteCommand(commandText1, Connect);
                SQLiteCommand Command2 = new SQLiteCommand(commandText2, Connect);
                SQLiteCommand Command3 = new SQLiteCommand(commandText3, Connect);
                SQLiteCommand Command4 = new SQLiteCommand(commandText4, Connect);
               
                Connect.Open();
                Command1.ExecuteNonQuery();
                Command2.ExecuteNonQuery();
                Command3.ExecuteNonQuery();
                Command4.ExecuteNonQuery();
                
            }
        }
        public void addPatient(Patient patient)
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
            {
                string commandText1 = $"INSERT INTO Patients (Имя, Фамилия, Отчество, Телефон, Дата_рождения, Полис_ОМС) VALUES ('{patient.FirstName}','{patient.LastName}','{patient.Patronymic}','{patient.PhoneNumber}','{patient.DateOfBirth}','{patient.OmsPolicyNumber}')";

                SQLiteCommand Command1 = new SQLiteCommand(commandText1, Connect);

                Connect.Open();
                Command1.ExecuteNonQuery();
            }
        }
        public DataSet readPatients() 
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db")) 
            {
                string commandText = "SELECT * FROM Patients";
                using (SQLiteDataAdapter Adapter = new SQLiteDataAdapter(commandText, Connect))
                {
                    DataSet ds = new DataSet();
                    Adapter.Fill(ds);
                    return ds;
                }
            }
        }
        public Patient getPatientWithId(string id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
                {
                    string commandText = $"SELECT * FROM Patients WHERE ID = {int.Parse(id)}";
                    using (SQLiteDataAdapter Adapter = new SQLiteDataAdapter(commandText, Connect))
                    {
                        DataSet ds = new DataSet();
                        Adapter.Fill(ds);
                        Patient temp = new Patient(ds.Tables[0].Rows[0].ItemArray[1].ToString(),
                        ds.Tables[0].Rows[0].ItemArray[2].ToString(),
                        ds.Tables[0].Rows[0].ItemArray[3].ToString(),
                        ds.Tables[0].Rows[0].ItemArray[5].ToString(),
                        ds.Tables[0].Rows[0].ItemArray[4].ToString(),
                        ds.Tables[0].Rows[0].ItemArray[6].ToString());
                        return temp;
                    }
                }
            }
            else return null;
        }
        public void deletePatient(string id) 
        {
            if (!String.IsNullOrEmpty(id))
            {
                using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
                {
                    string commandText1 = $"DELETE FROM Patients WHERE ID = {int.Parse(id)}";
                    SQLiteCommand Command1 = new SQLiteCommand(commandText1, Connect);
                    Connect.Open();
                    Command1.ExecuteNonQuery();
                }
                Globals.id = "";
            }
            else return;
        }
        public void updatePatient(Patient patient, string id)
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
                {
                    string commandText1 = $"UPDATE Patients SET Имя = '{patient.FirstName}'," +
                    $" Фамилия = '{patient.LastName}'," +
                    $" Отчество = '{patient.Patronymic}'," +
                    $" Телефон = '{patient.PhoneNumber}'," +
                    $" Дата_рождения = '{patient.DateOfBirth}'," +
                    $" Полис_ОМС = '{patient.OmsPolicyNumber}' WHERE ID = {int.Parse(id)} ";
                    SQLiteCommand Command1 = new SQLiteCommand(commandText1, Connect);
                    Connect.Open();
                    Command1.ExecuteNonQuery();
                }
                Globals.id = "";
        }
     // Работа с лабораторными анализами
        public void addLabAnalyzes(LabAnalyzes labAnalyzes)
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
            {
                string commandText1 = $"INSERT INTO LabAnalysis (ID_пациента, B12, B9, Гемоглобин) VALUES" +
                    $" ('{int.Parse(labAnalyzes.id)}'," +
                    $"'{labAnalyzes.B12}'," +
                    $"'{labAnalyzes.B9}'," +
                    $"'{labAnalyzes.Hgb}')";
                SQLiteCommand Command1 = new SQLiteCommand(commandText1, Connect);
                Connect.Open();
                Command1.ExecuteNonQuery();
            }
        }

        public DataSet readLabAnalyzes()
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
            {
                string commandText = "SELECT * FROM LabAnalysis";
                using (SQLiteDataAdapter Adapter = new SQLiteDataAdapter(commandText, Connect))
                {
                    DataSet ds = new DataSet();
                    Adapter.Fill(ds);
                    return ds;
                }
            }
        }
        public DataSet readDataWithPatientId(string id, string tablename)
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
            {
                string commandText = $"SELECT * FROM '{tablename}' WHERE ID_пациента = {int.Parse(id)}";              
                using (SQLiteDataAdapter Adapter = new SQLiteDataAdapter(commandText, Connect))
                {
                    DataSet ds = new DataSet();
                    Adapter.Fill(ds);
                    return ds;
                }
            }
        }
        public DataSet readDataWithExamId(string id,string examId, string tablename)
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
            {
                string commandText = $"SELECT * FROM '{tablename}' WHERE ID_обследования = {int.Parse(id)} AND ID_обследования = {int.Parse(examId)}";
                using (SQLiteDataAdapter Adapter = new SQLiteDataAdapter(commandText, Connect))
                {
                    DataSet ds = new DataSet();
                    Adapter.Fill(ds);
                    return ds;
                }
            }
        }

        public void deleteLabAnalyzes(string id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
                {
                    string commandText1 = $"DELETE FROM LabAnalysis WHERE ID_пациента = {int.Parse(id)}";
                    SQLiteCommand Command1 = new SQLiteCommand(commandText1, Connect);
                    Connect.Open();
                    Command1.ExecuteNonQuery();
                }
                
            }
            else return;
        }
        ////////////////////////////////////////////////
        ///
        // Работа с инструментальными анализами

        public void addInstAnalyzes(InstAnalyzes instAnalyzes)
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
            {
                string commandText1 = $"INSERT INTO InstAnalysis (ID_пациента, КТГ ) VALUES" +
                    $" ('{int.Parse(instAnalyzes.id)}'," +
                    $"'{instAnalyzes.Ktg}')";
                SQLiteCommand Command1 = new SQLiteCommand(commandText1, Connect);
                Connect.Open();
                Command1.ExecuteNonQuery();
            }
        }

        public DataSet readInstAnalyzes()
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
            {
                string commandText = "SELECT * FROM InstAnalysis";
                using (SQLiteDataAdapter Adapter = new SQLiteDataAdapter(commandText, Connect))
                {
                    DataSet ds = new DataSet();
                    Adapter.Fill(ds);
                    return ds;
                }
            }
        }
        public void deleteInstAnalyzes(string id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
                {
                    string commandText1 = $"DELETE FROM InstAnalysis WHERE ID_пациента = {int.Parse(id)}";
                    SQLiteCommand Command1 = new SQLiteCommand(commandText1, Connect);
                    Connect.Open();
                    Command1.ExecuteNonQuery();
                }
                
            }
            else return;
        }

        ////////////////////////////////////////////////
        public void deleteAnalysisWithId(string id)
        {
            if (!String.IsNullOrEmpty(id))
            {
                using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
                {
                    string commandText1 = $"DELETE FROM InstAnalysis WHERE ID_обследования = {int.Parse(id)}";
                    string commandText2 = $"DELETE FROM LabAnalysis WHERE ID_обследования = {int.Parse(id)}";
                    SQLiteCommand Command1 = new SQLiteCommand(commandText1, Connect);
                    SQLiteCommand Command2 = new SQLiteCommand(commandText2, Connect);
                    Connect.Open();
                    Command1.ExecuteNonQuery();
                    Command2.ExecuteNonQuery();
                }

            }
            else return;
        }
        // Работа с настройками

        public void addSettings (string B12Min,  string B12Max, string B9Min, string B9Max, string HGBMin, string HGBMax)
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
            {
                string b12 = $"{B12Min},{B12Max}";
                string b9 = $"{B9Min},{B9Max}";
                string hgb = $"{HGBMin},{HGBMax}";
                string commandText1 = $"INSERT INTO Settings (B12_норм, B9_норм, Гемоглобин_норм) VALUES ('{b12}','{b9}','{hgb}')";
                SQLiteCommand Command1 = new SQLiteCommand(commandText1, Connect);
                Connect.Open();
                Command1.ExecuteNonQuery();
            }

        }


        public (string[], string[], string[]) checkSettings()
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
            {
                string commandText = $"SELECT * FROM Settings WHERE ID = 1";
                using (SQLiteDataAdapter Adapter = new SQLiteDataAdapter(commandText, Connect))
                {
                    DataSet ds = new DataSet();
                    Adapter.Fill(ds);
                    if (ds.Tables[0].Rows.Count>0)
                    {
                        string[] B12 = ds.Tables[0].Rows[0].ItemArray[1].ToString().Split(',');
                        string[] B9 = ds.Tables[0].Rows[0].ItemArray[2].ToString().Split(',');
                        string[] HGB = ds.Tables[0].Rows[0].ItemArray[3].ToString().Split(',');
                        return (B12, B9, HGB);
                    }
                    else
                    {
                        string[] B12 = { "", "" };
                        string[] B9 = { "", "" };
                        string[] HGB = { "", "" };
                        return (B12, B9, HGB);
                    }
                    



                }
            }
        }
        public void updateSettings(string B12Min, string B12Max, string B9Min, string B9Max, string HGBMin, string HGBMax)
        {
            using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
            {
                string b12 = $"{B12Min},{B12Max}";
                string b9 = $"{B9Min},{B9Max}";
                string hgb = $"{HGBMin},{HGBMax}";
                string commandText1 = $"UPDATE Settings SET B12_норм = '{b12}', B9_норм = '{b9}',Гемоглобин_норм = '{hgb}' WHERE ID = 1";
                SQLiteCommand Command1 = new SQLiteCommand(commandText1, Connect);
                Connect.Open();
                Command1.ExecuteNonQuery();
            }
        }
        /////////////////////////

    }
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string OmsPolicyNumber { get; set; }

        public Patient(string firstName, string lastName, string patronymic, string dateOfBirth, string phoneNumber, string omsPolicyNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            OmsPolicyNumber = omsPolicyNumber;
        }
    }

    public class LabAnalyzes
    {
        public string id { get; set; }
        public string B12 {  get; set; }
        public string B9 { get; set; }
        
        public string Hgb { get; set; }

        public LabAnalyzes(string id, string b12, string b9,  string hgb)
        {
            this.id = id;
            B12 = b12;
            B9 = b9;
            Hgb = hgb;
        }
    }

    public class InstAnalyzes
    {
        public string id { get; set; }
        public string Ktg {  get; set; }


        public InstAnalyzes(string id, string ktg)
        {
            this.id = id;
            Ktg = ktg;
        }

    }
}
