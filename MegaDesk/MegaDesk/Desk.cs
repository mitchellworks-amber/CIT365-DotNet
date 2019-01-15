using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    //set up the possible wood types
    enum WoodMaterial
    {
        oak,
        laminate,
        pine,
        rosewood,
        veneer,
    }

    public class Desk
    {
        int width;
        int depth;
        int drawers;
        string material;
        bool oversized = false;

        static bool ValidateInputs()
        {
            return true;
        }

    }
}
