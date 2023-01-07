using System;
using static System.Console;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using navigation.BL;
using navigation.UI;

namespace navigation.DL
{
    class navigation_DL
    {
       public static void AddShip(List<Angle> addPosition)
        {
            string shipNo;
            string latDegree;
            int latMint;
            char latDirection;
            string loDegree;
            int loMint;
            char loDirection;

            Write("Enter Ship Number ----- > ");
            shipNo = ReadLine();
            WriteLine("Latitude : ");
            Write("Enter ship Latitude's Degree----->");
            latDegree = ReadLine();
            Write("Enter ship LAtitude'Mints------>");
            latMint = int.Parse(ReadLine());
            Write("Enter ship Latitude'Direction ------>");
            latDirection = char.Parse(ReadLine());

            WriteLine("Longitude : ");
            Write("Enter ship Longitude's Degree----->");
            loDegree = ReadLine();
            Write("Enter ship Longitude'Mints------>");
            loMint = int.Parse(ReadLine());
            Write("Enter ship Longitude'Direction ------>");
            loDirection = char.Parse(ReadLine());

            ship addShip = new ship(shipNo, latDegree, latMint, latDirection, loDegree, loMint, loDirection, addPosition);
        }

        public static void storeDataIntoFile(List<Angle>addPosition ,string path)
        {
            StreamWriter file = new StreamWriter(path);
            if(File.Exists(path))
            {
                for(int i=0; i<addPosition.Count; i++)
                {
                    file.WriteLine(addPosition[i].getshipNo() + "," + addPosition[i].getlatDegree() + "," + addPosition[i].getlatMint() + "," + addPosition[i].getlatDirection() + "," + addPosition[i].getloDegree() + "," + addPosition[i].getlatMint() + "," + addPosition[i].getlatDirection());
                }
            }
        }

       public static void ShipSerialNumbers(List<Angle> addPosition)
        {
            Angle L = new Angle();
            Write("Enter Latitude-----> ");
            string latDegree = ReadLine();
            int latMint = int.Parse(ReadLine());
            char latDirection = char.Parse(ReadLine());

            Write("Enter Longnitude-----> ");
            string loDegree = ReadLine();
            int loMint = int.Parse(ReadLine());
            char loDirection = char.Parse(ReadLine());

            int indx = checkIndexForSerial(latDegree, latMint, latDirection, loDegree, loMint, loDirection, addPosition);
            navigation_UI.displaySerial(addPosition, indx);
        }

       public static void ChangePosition(List<Angle> addPosition)
        {
            Angle L = new Angle();
            ship M = new ship();
            Write("Enter Serial Number------->");
            string serial = ReadLine();
            int idx = checkIndex(serial, addPosition);
            addPosition.RemoveAt(idx);

            addPosition.Insert(idx, navigation_UI.Input());
            M.showList(addPosition);
        }

        public static int checkIndexForSerial(string lDe, int lM, char lD, string loDe, int loM, char loD, List<Angle> addPosition)
        {
            for (int i = 0; i < addPosition.Count; i++)
            {
                if (lDe == addPosition[i].getlatDegree() && lM == addPosition[i].getlatMint() && lD == addPosition[i].getlatDirection() && loDe == addPosition[i].getloDegree() && loM == addPosition[i].getloMint() && loD == addPosition[i].getloDirection())
                {
                    return i;
                }
            }
            return 0;
        }

        public static bool checkIsPresent(string p1, List<Angle> addPosition)
        {
            for (int i = 0; i < addPosition.Count; i++)
            {
                if (p1 == addPosition[i].getshipNo())
                {
                    return true;
                }
            }
            return false;
        }

        public static int checkIndex(string p1, List<Angle> addPosition)
        {
            for (int i = 0; i < addPosition.Count; i++)
            {
                if (p1 == addPosition[i].getshipNo())
                {
                    return i;
                }
            }
            return 0;
        }

      
    }
}
