using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOMT.objects
{
    public class DoubleTalon
    {
        public int Channel1 { get; set; }
        public int Channel2 { get; set; }

        public string Name { get; set; }

        public WPILib.Talon TalonObject1 { get; set; }
        public WPILib.Talon TalonObject2 { get; set; }

        public DoubleTalon()
        {

        }

        public void SetSpeed(double speed)
        {
            TalonObject1.Set(speed);
            TalonObject2.Set(speed);
        }

        public void SetSpeed(double speed1, double speed2)
        {
            TalonObject1.Set(speed1);
            TalonObject2.Set(speed2);
        }

        public void Stop()
        {
            SetSpeed(0);
        }
    }
}
