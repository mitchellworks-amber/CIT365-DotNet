using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        // vars
        #region Object member variables
        private string CustomerName;
        private DateTime QuoteDate;
        private Desk TheDesk = new Desk();
        private int RushDays;
        private int QuoteAmount;
        #endregion

        #region Local variables
        private int SurfaceArea = 0;
        #endregion

        private const int PRICE_BASE = 200;
        private const int SIZE_MAX = 1000;
        private const int PRICE_PER_DRAWER = 50;
        // ....


        // constructor
        public DeskQuote(int width, int depth, int drawers, string material, int rushDays)
        {
            TheDesk.Width = width;
            TheDesk.Depth = depth;
            TheDesk.Drawers = drawers;
            TheDesk.Material = material;

            SurfaceArea = TheDesk.Width * TheDesk.Depth;
        }

        public int CalulateQuote()
        {
            return PRICE_BASE + DrawerCost() + AddOns();
        }

        private int DrawerCost()
        {
            return TheDesk.Drawers * PRICE_PER_DRAWER;
        }

        private int AddOns()
        {
            // surface area cost, rush order cost
            return SurfaceArea;
        }


        // other methods... needs WORK
        /*
        static int GatherInput()
        {
            int theNumber = 0;
            string theString = "";
            int rushDays = 0;

            //get numerical inputs
            do
            {
                try
                {
                    theNumber = int.Parse(theString);

                    if (theNumber < min || theNumber > max)
                        throw new Exception(eMsg);
                }
                catch (Exception eDeskW)
                {
                    //Console.Write(eDeskW.Message);
                }
            }
            while (theNumber < min || theNumber > max);

            //return theNumber;

            // gather rush input
            do
            {
                Console.WriteLine("\nDo you need your ordere rushed? Please enter a deadline of 3, 5, or 7 days. \nOtherwise please hit ENTER for the standard 14 days.");
                string rushString = Console.ReadLine();
                try
                {
                    if (rushString == "")
                    {
                        rushString = "14";
                    }
                    rushDays = int.Parse(rushString);
                    if (rushDays != 3 && rushDays != 5 && rushDays != 7 && rushDays != 14)
                        throw new Exception("Please enter either 3, 5, or 7, or hit ENTER\n");
                }
                catch (Exception eRush)
                {
                    Console.WriteLine(eRush.Message);
                }
            }
            while (rushDays != 3 && rushDays != 5 && rushDays != 7 && rushDays != 14);

            return rushDays;

        }

        static int CalcPrice(int width, int depth, int drawers, string material, int rushDays,)
        {
            int surfacePrice;
            int drawerPrice;
            int materialPrice;
            int rushPrice = 0;
            int basePrice = 200;

            // see if there is an oversize charge
            surfacePrice = ((width * depth) - 1000);
            if (surfacePrice < 0)
                surfacePrice = 0;

            double deskSize = (width * depth);

            // set drawerPrice
            drawerPrice = (drawers * 50);

            // set materialPrice
            switch (material)
            {
                case "oak":
                    materialPrice = 200;
                    break;
                case "laminate":
                    materialPrice = 100;
                    break;
                case "pine":
                    materialPrice = 50;
                    break;
                case "rosewood":
                    materialPrice = 300;
                    break;
                default:
                    materialPrice = 125;
                    break;
            }

            // set rushPrice
            switch (rushDays)
            {
                case 3:
                    if (deskSize < 1000)
                        rushPrice = 60;
                    else if (deskSize > 1000 && deskSize < 2000)
                        rushPrice = 70;
                    else if (deskSize >= 2000)
                        rushPrice = 80;
                    break;
                case 5:
                    if (deskSize < 1000)
                        rushPrice = 40;
                    else if (deskSize > 1000 && deskSize < 2000)
                        rushPrice = 50;
                    else if (deskSize >= 2000)
                        rushPrice = 60;
                    break;
                case 7:
                    if (deskSize < 1000)
                        rushPrice = 30;
                    else if (deskSize > 1000 && deskSize < 2000)
                        rushPrice = 35;
                    else if (deskSize >= 2000)
                        rushPrice = 40;
                    break;
                default:
                    rushPrice = 0;
                    break;

            }

            // now we can calculate totalPrice
            int totalPrice = (basePrice + surfacePrice + drawerPrice + materialPrice + rushPrice);

            return totalPrice;

        }
        static void DisplaySingleQuote()
        {
            // send this good stuff to the view
        }
        static void WriteQuote(int width, int length, int surfacePrice, int drawers, int drawerPrice, string material, int materialPrice, int rushDays, int rushPrice, int totalPrice)
        {
            StreamWriter writer;
            writer = new StreamWriter(@"C:\Users\mitchellworks\Documents\am_workspace\BYUI\net-stuff\NET-stuff\Mega Escritorio\MegaE-OrderFile.txt");

            writer.WriteLine("{");
            writer.WriteLine("\t\"order\":");
            writer.WriteLine("\t{");
            writer.WriteLine("\t\t\"width\":\"" + width + " in\"");
            writer.WriteLine("\t\t\"length\":\"" + length + " in\"");
            writer.WriteLine("\t\t\"extraSurfacePrice\":\"$" + surfacePrice + "\"\n");

            writer.WriteLine("\t\t\"numberOfDrawers\":\"" + drawers + "\"");
            writer.WriteLine("\t\t\"drawerPrice\":\"$" + drawerPrice + "\"\n");

            writer.WriteLine("\t\t\"material\":\"" + material + "\"");
            writer.WriteLine("\t\t\"materialPrice\":\"$" + materialPrice + "\"\n");

            writer.WriteLine("\t\t\"rushDeadline\":" + rushDays + "days\"");
            writer.WriteLine("\t\t\"rushPrice\":\"$" + rushPrice + "\"\n");

            writer.WriteLine("\t\t\"totalPrice\":\"$" + totalPrice + "\"");
            writer.WriteLine("\t}");
            writer.WriteLine("}");
            writer.Close();
        }
*/
    }
}
