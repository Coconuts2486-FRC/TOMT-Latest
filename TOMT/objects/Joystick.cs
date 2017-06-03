using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOMT.objects
{
    public class Joystick
    {
        public int Channel { get; set; }
        public string Name { get; set; }
        public WPILib.Joystick JoystickObject { get; set; }

        public Joystick()
        {
            JoystickObject = new WPILib.Joystick(Channel);
        }
    }
}
