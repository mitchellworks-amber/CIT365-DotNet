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
        veneer
    }

    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }
        public string Material { get; set; }
    }
}
