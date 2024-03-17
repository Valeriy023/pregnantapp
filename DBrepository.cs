using System;
using System.Data.SQLite;

public class Repository
{
	public Repository()
	{

	}

	private void createDB()
	{
        using (SQLiteConnection Connect = new SQLiteConnection("Data Source=TestDB.db"))
        {
            string commandText = "CREATE TABLE IF NOT EXISTS Main ( ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, Имя TEXT NOT NULL, Фамилия TEXT NOT NULL, Отчество TEXT NOT NULL)";
            SQLiteCommand Command = new SQLiteCommand(commandText, Connect);
            Connect.Open();
            Command.ExecuteNonQuery();
        }
    }
}
