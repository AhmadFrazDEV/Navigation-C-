using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using navigation.BL;
using navigation.DL;

namespace navigation.UI
{
    class navigation_UI
    {
       public static Angle Input()
        {
           
            WriteLine("Latitude : ");
            Write("Enter ship Latitude's Degree----->");
            string latDegree = ReadLine();
            Write("Enter ship LAtitude'Mints------>");
            int latMint = int.Parse(ReadLine());
            Write("Enter ship Latitude'Direction ------>");
             char latDirection = char.Parse(ReadLine());

            WriteLine("Longitude : ");
            Write("Enter ship Longitude's Degree----->");
            string loDegree = ReadLine();
            Write("Enter ship Longitude'Mints------>");
            int loMint = int.Parse(ReadLine());
            Write("Enter ship Longitude'Direction ------>");
            char loDirection = char.Parse(ReadLine());
            ship newobj = new ship(L);
            return L;

        }

        public static void ViewShipPosition(List<Angle> addPosition)
        {
            Angle L = new Angle();
            int idx = 0;

            Write("Enter the ship number to see its Position ----->");
            string position = ReadLine();
            idx = navigation_DL.checkIndex(position, addPosition);
            if (navigation_DL.checkIsPresent(position , addPosition))
            {
                idx = navigation_DL.checkIndex(position, addPosition);
                
                showPosition(addPosition, idx);
            }
            else
            {
                WriteLine(idx);
                WriteLine("Invalid Input :(");
            }
            
        }

        public static void showPosition(List<Angle> addPosition, int i)
        {

            WriteLine("Ship is at :");
            WriteLine("Latitude" + addPosition[i].latDegree + "\u00b0" + addPosition[i].latMint + "'" + addPosition[i].latDirection);
            WriteLine("Longitude" + addPosition[i].loDegree + "\u00b0" + addPosition[i].loMint + "'" + addPosition[i].loDirection);

        }

        public static void displaySerial(List<Angle> addPosition, int i)
        {
            Write("Ships Serial Number is -----> {o}", addPosition[i].shipNo);
        }
    }
}
