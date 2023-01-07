using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace navigation.BL
{
    class ship
    {

        private string shipNo;
        // ------> ship Latitude
        private string latDegree;
        private int latMint;
        private char latDirection;
        // ------> ship Lognitude
        private string loDegree;
        private int loMint;
        private char loDirection;


        public string getshipNo() { return shipNo; }
        public void setshipNo(string shipNo) { this.shipNo = shipNo; }

        public string getlatDegree() { return latDegree; }
        public void setlatDegree(string latDegree) { this.latDegree = latDegree; }

        public int getlatMint() { return latMint; }
        public void setlatMint(int latMint) { this.latMint = latMint; }

        public char getlatDirection() { return latDirection; }
        public void setlatDirection(char latDirection) { this.latDirection = latDirection; }

        public string getloDegree() { return loDegree; }
        public void setloDegree(string loDegree) { this.loDegree = loDegree; }

        public int getloMint() { return loMint; }
        public void setloMint(int loMint) { this.loMint = loMint; }

        public char getloDirection() { return loDirection; }
        public void setloDirection(char loDirection) { this.loDirection = loDirection; }


        Angle position = new Angle();
        public ship(string shipNo, string latDegree, int latMint, char latDirection, string loDegree, int loMint, char loDirection)
        {
            this.shipNo = shipNo;
            this.latDegree = latDegree;
            this.latMint = latMint;
            this.loDegree = loDegree;
            this.loMint = loMint;
            this.loDirection = loDirection;
        }
        public ship(string shipNo, string latDegree, int latMint, char latDirection, string loDegree, int loMint, char loDirection, List<Angle> addPosition)
        {
            position.addAgain(shipNo, latDegree, latMint, latDirection, loDegree, loMint, loDirection);
            addPosition.Add(position);
        }
        public ship()
        {

        }

       

        public void showList(List<Angle> addPosition)
        {
            foreach (Angle i in addPosition)
            {
                Write("Ship {0} is at :", i.getshipNo());
                WriteLine(i.getlatDegree() + "\u00b0" + i.getlatMint() + "'" + i.getlatDirection());
                WriteLine(i.getloDegree() + "\u00b0" + i.getloMint() + "'" + i.getloDirection());

            }
        }


    }

    class Angle
    {
        private string shipNo;
        // ------> ship Latitude
        private string latDegree;
        private int latMint;
        private char latDirection;
        // ------> ship Lognitude
        private string loDegree;
        private int loMint;
        private char loDirection;

        public Angle()
        {

        }
        
        public void addAgain(string shipNo, string latDegree, int latMint, char latDirection, string loDegree, int loMint, char loDirection)
        {
            this.shipNo = shipNo;
            this.latDegree = latDegree;
            this.latMint = latMint;
            this.loDegree = loDegree;
            this.loMint = loMint;
            this.loDirection = loDirection;
        }

        public Angle(Angle obj)
        {
            obj.shipNo = shipNo;
            obj.latDegree = latDegree;
            obj.latMint = latMint;
            obj.loDegree = loDegree;
            obj.loMint = loMint;
            obj.loDirection = loDirection;
        }


        public string getshipNo() { return shipNo; }
        public void setshipNo(string shipNo) { this.shipNo = shipNo; }

        public string getlatDegree() { return latDegree; }
        public void setlatDegree(string latDegree) { this.latDegree = latDegree; }

        public int getlatMint() { return latMint; }
        public void setlatMint(int latMint) { this.latMint = latMint; }

        public char getlatDirection() { return latDirection; }
        public void setlatDirection(char latDirection) { this.latDirection = latDirection; }

        public string getloDegree() { return loDegree; }
        public void setloDegree(string loDegree) { this.loDegree = loDegree; }

        public int getloMint() { return loMint; }
        public void setloMint(int loMint) { this.loMint = loMint; }

        public char getloDirection() { return loDirection; }
        public void setloDirection(char loDirection) { this.loDirection = loDirection; }


    }
}
