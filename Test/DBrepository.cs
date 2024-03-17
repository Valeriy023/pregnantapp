using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Test;
using System.Runtime.Remoting.Contexts;
using System.Data;

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
                string commandText2 = "CREATE TABLE LabAnalysis (ID_пациента INTEGER NOT NULL, ID_обследования INTEGER NOT NULL, PRO_в_моче REAL NOT NULL, KET_в_моче REAL NOT NULL, GLU_в_крови REAL NOT NULL, HGB_в_крови REAL NOT NULL, FOREIGN KEY(ID_пациента) REFERENCES Patients(ID), PRIMARY KEY(ID_обследования AUTOINCREMENT))";
                string commandText3 = "CREATE TABLE InstAnalysis (ID_пациента INTEGER NOT NULL, ID_обследования INTEGER NOT NULL, ЧСС_плода TEXT, Активность_матки TEXT, Температура INTEGER, АД INTEGER, FOREIGN KEY(ID_пациента) REFERENCES Patients(ID), PRIMARY KEY(ID_обследования AUTOINCREMENT))";
                SQLiteCommand Command1 = new SQLiteCommand(commandText1, Connect);
                SQLiteCommand Command2 = new SQLiteCommand(commandText2, Connect);
                SQLiteCommand Command3 = new SQLiteCommand(commandText3, Connect);
                Connect.Open();
                Command1.ExecuteNonQuery();
                Command2.ExecuteNonQuery();
                Command3.ExecuteNonQuery();
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
}
