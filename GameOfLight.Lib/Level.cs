using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;

namespace GameOfLight.Lib
{
    [Serializable]
    public class Level:Base
    {

        private Guid levelId;
        public Guid LevelId
        {
            get { return levelId; }
            set { levelId = value; }
        }

        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Level()
        {
        }

        public Level(int _number, string _name)
        {
            LevelId = Guid.NewGuid();
            Number = _number;
            Name = _name;
        }

        public override string ToString()
        {
            return this.Name;
        }


        public void SaveToDB()
        {
            SqlCommand sqlcmd = new SqlCommand();
            if (!this.DBContains())
            {
                sqlcmd.Connection = new System.Data.SqlClient.SqlConnection(ConnectionString);
                sqlcmd.CommandText = "insert into Levels (Name,Number,LevelId) values (@name,@number,@levelId)";
                sqlcmd.Parameters.AddWithValue("@levelId", this.LevelId);
                sqlcmd.Parameters.AddWithValue("@name", this.Name);
                sqlcmd.Parameters.AddWithValue("@number", this.Number);
                sqlcmd.Connection.Open();
                sqlcmd.ExecuteNonQuery();
                sqlcmd.Connection.Close();
            }
            else { this.UpdateDB(); }
        }


        public static IEnumerable<Level> LoadAllFromDB()
        {
            SqlCommand sqlcmd = new SqlCommand();
            SqlDataReader sqldr;
            List<Level> level_lst = new List<Level>();
            sqlcmd.Connection = new System.Data.SqlClient.SqlConnection(ConnectionString);
            sqlcmd.Connection.Open();
            sqlcmd.CommandText = "select * from Levels";
            sqldr = sqlcmd.ExecuteReader();
            if (sqldr.HasRows)
            {
                while (sqldr.Read())
                {
                    Level a = new Level();
                    a.LevelId = (Guid)sqldr[0];
                    a.Name = (string)sqldr[1];
                    a.Number = (int)sqldr[2];
                    
                    level_lst.Add(a);
                }
            }
            sqlcmd.Connection.Close();
            return level_lst;
        }
        public void DeleteFromDB()
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = new System.Data.SqlClient.SqlConnection(ConnectionString);
            sqlcmd.CommandText = "delete from Levels where LevelId='" + this.LevelId + "'";
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Connection.Close();
        }
        public void UpdateDB()
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = new System.Data.SqlClient.SqlConnection(ConnectionString);
            sqlcmd.CommandText = "Update Levels set Name='@name',Number='@number',where LevelId='" + this.LevelId + "'";
            sqlcmd.Parameters.AddWithValue("@levelId", this.LevelId);
            sqlcmd.Parameters.AddWithValue("@name", this.Name);
            sqlcmd.Parameters.AddWithValue("@number", this.Number);
            sqlcmd.Connection.Open();
            sqlcmd.ExecuteNonQuery();
            sqlcmd.Connection.Close();
        }
        public bool DBContains()
        {
            SqlCommand sqlcmd = new SqlCommand();
            SqlDataReader sqldr;
            bool contains = false;
            sqlcmd.Connection = new System.Data.SqlClient.SqlConnection(ConnectionString);
            sqlcmd.CommandText = "select * from Levels where LevelId='" + this.LevelId + "'";
            sqlcmd.Connection.Open();
            sqldr = sqlcmd.ExecuteReader();
            if (sqldr.HasRows)
            {
                contains = true;
            }
            sqlcmd.Connection.Close();
            return contains;
        }
        public static Level FindLevelInDB(Guid id)
        {
            SqlCommand sqlcmd = new SqlCommand();
            SqlDataReader sqldr;
            sqlcmd.Connection = new System.Data.SqlClient.SqlConnection(ConnectionString);
            sqlcmd.Connection.Open();
            sqlcmd.CommandText = "select * from Levels where ID='" + id.ToString() + "'";
            sqldr = sqlcmd.ExecuteReader();
            Level level = null;
            if (sqldr.HasRows)
            {
                sqldr.Read();
                level = new Level();
                level.LevelId = (Guid)sqldr[0]; 
                level.Name = (string)sqldr[1];
                level.Number = (int)sqldr[2];
            }
            sqlcmd.Connection.Close();
            return level;
        }
        public static Level FindLevelInDB(String Name)
        {
            SqlCommand sqlcmd = new SqlCommand();
            SqlDataReader sqldr;
            sqlcmd.Connection = new System.Data.SqlClient.SqlConnection(ConnectionString);
            sqlcmd.Connection.Open();
            sqlcmd.CommandText = "select * from Levels where Name=@name";
            sqlcmd.Parameters.AddWithValue("@name", Name);
            sqldr = sqlcmd.ExecuteReader();
            Level level = null;
            if (sqldr.HasRows)
            {
                sqldr.Read();
                level = new Level();
                level.LevelId = (Guid)sqldr[0];
                level.Name = (string)sqldr[1];
                level.Number = (int)sqldr[2];
            }
            sqlcmd.Connection.Close();
            return level;
        }
        


    }
}
