using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOMT.objects
{
    public class Solenoid
    {
        public int Channel { get; set; }
        public string Name { get; set; }
        public WPILib.Solenoid SolenoidObject { get; set; }

        public Solenoid()
        {
            SolenoidObject = new WPILib.Solenoid(0, Channel);
        }
    }
}
