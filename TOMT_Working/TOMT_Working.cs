using System;
using System.Collections.Generic;
using System.Linq;
using WPILib;
using WPILib.SmartDashboard;

namespace TOMT_Working
{
    public class TOMT_Working : SampleRobot
    {
        public Talon Left1;
        public Talon Left2;
        public Talon Right1;
        public Talon Right2;
        public Talon Roller1;
        public Talon Roller2;
        public Talon Arm;
        public Solenoid Piston;

        public Joystick Joystick;

        public TOMT_Working()
        {

        }

        protected override void RobotInit()
        {
            Left1 = new Talon(0);
            Left2 = new Talon(2);
            Right1 = new Talon(4);
            Right2 = new Talon(5);

            Roller1 = new Talon(1);
            Roller2 = new Talon(6);
            Arm = new Talon(3);
            Piston = new Solenoid(1, 0);

            Joystick = new Joystick(0);
        }

        public override void Autonomous()
        {

        }

        public override void OperatorControl()
        {
            while(IsEnabled && IsOperatorControl)
            {
                Left1.Set(Joystick.GetAxis(Joystick.AxisType.X) + -Joystick.GetAxis(Joystick.AxisType.Y));
                Left2.Set(Joystick.GetAxis(Joystick.AxisType.X) + -Joystick.GetAxis(Joystick.AxisType.Y));

                Right1.Set(Joystick.GetAxis(Joystick.AxisType.X) - -Joystick.GetAxis(Joystick.AxisType.Y));
                Right2.Set(Joystick.GetAxis(Joystick.AxisType.X) - -Joystick.GetAxis(Joystick.AxisType.Y));

                // Intake
                if (Joystick.GetRawButton(10))
                {
                    SetRollers(-0.9);
                }
                // Fire Slow
                else if (Joystick.GetRawButton(11))
                {
                    SetRollers(0.4);
                }
                //Fire Medium
                else if (Joystick.GetRawButton(12))
                {
                    SetRollers(0.6);
                }
                //FIre Fast
                else if (Joystick.GetRawButton(9))
                {
                    SetRollers(1);
                }
                else
                {
                    SetRollers(0);
                }

                if (Joystick.GetRawButton(1))
                {
                    Piston.Set(true);
                }
                else
                {
                    Piston.Set(false);
                }

                if (Joystick.GetRawButton(7))
                {
                    Arm.Set(0.6);
                }
                else if (Joystick.GetRawButton(8))
                {
                    Arm.Set(-0.6);
                }
                else
                {
                    Arm.Set(0);
                }
            }
        }

        public override void Test()
        {

        }

        public void SetRollers(double speed)
        {
            Roller1.Set(-speed);
            Roller2.Set(-speed);
        }
    }
}
