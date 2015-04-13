using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLight.Lib
{
    public class Level
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

    }
}
