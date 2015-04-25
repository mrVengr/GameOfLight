using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLight.Lib
{
    [Serializable]
    public class Base
    {
        public static String ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='D:\Projects\GameOfLight\GameOfLight.Lib\GameDB.mdf';Integrated Security=True";
         public Base()
         { }
    }
}
