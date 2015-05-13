using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameOfLight.Lib
{
    public class Record
    {


        private Guid recordId;
        public Guid RecordId
        {
            get { return recordId; }
            set { recordId = value; }
        }

        private DateTime gameTime;
        public DateTime GameTime
        {
            get { return gameTime; }
            set { gameTime = value; }
        }

        private Guid player;
        public Guid Player
        {
            get { return player; }
            set { player = value; }
        }

        private int score;
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public Record()
        {
        }

        public Record(DateTime _time, User _player, int _score)
    {
        RecordId = Guid.NewGuid();
        GameTime = _time;
        Player = _player.UserId;
        Score = _score;
    }
    }
}
