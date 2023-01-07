using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using navigation.BL;
using navigation.DL;
using navigation.UI;

namespace navigation
{
    class Program
    {
        // °    >Degree Sign

        static void Main(string[] args)
        {
            List<Angle> addPosition = new List<Angle>();
            string path = "E:\\C# Projects\\VIVA\\NAVIGATION\\navigation\\points.txt";
            int opt;
            do
            {
                header();
                opt = menu();
                remove();
                if (opt == 1) { header();   navigation_DL.AddShip(addPosition);           remove(); }
                if (opt == 2) { header();   navigation_UI.ViewShipPosition(addPosition);  remove(); }
                if (opt == 3) { header();   navigation_DL.ShipSerialNumbers(addPosition); remove(); }
                if (opt == 4) { header();   navigation_DL.ChangePosition(addPosition);    remove(); }
                ReadKey();
            }
            while (opt != 5);
        }

        static void header()
        {
            WriteLine("===============> SHIP NAVIGATION <=================");
            WriteLine();
        }

        static void remove()
        {
            Write("Press any key To Continue......");
            ReadKey();
            Clear();
        }

        static int menu()
        {
            WriteLine("1.Add Ships");
            WriteLine("2.View Ship Position");
            WriteLine("3.View Ship Serial NUmber");
            WriteLine("4.Change Ship Position");
            WriteLine("5.Exist");
            int opt = int.Parse(ReadLine());
            return opt;
        }

       
       

       

       
        
    }
}
