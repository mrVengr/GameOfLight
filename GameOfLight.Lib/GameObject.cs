using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLight.Lib
{
    class GameObject
    {
        private Guid objectId;
        public Guid ObjectId
        {
            get { return objectId; }
            set { objectId = value; }
        }
        private int pointX;
        public int PointX
        {
            get { return pointX; }
            set { pointX = value; }
        }
        private int pointY;
        public int PointY
        {
            get { return pointY; }
            set { pointY = value; }
        }
        private bool isAvailable;
        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }
        public GameObject()
        {
        }
        public GameObject(bool Availability)
        {
            ObjectId = Guid.NewGuid();
            IsAvailable = Availability;
        }
    }
}
