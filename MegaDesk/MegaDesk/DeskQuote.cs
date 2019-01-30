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


     
    }
}
