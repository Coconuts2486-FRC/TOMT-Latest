using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOMT
{
    public class ClassAssembler
    {

        public static void Load()
        {
            //if(!File.Exists(Environment.GetEnvironmentVariable("HOME") + "/TOMT_Data.json"))
            {
                RobotMap.Left = new objects.DoubleTalon
                {
                    Channel1 = 0,
                    Channel2 = 2,
                    Name = "Left"
                };

                RobotMap.Left.TalonObject1 = new WPILib.Talon(RobotMap.Left.Channel1);
                RobotMap.Right.TalonObject2 = new WPILib.Talon(RobotMap.Left.Channel2);

                RobotMap.Right = new objects.DoubleTalon
                {
                    Channel1 = 4,
                    Channel2 = 5,
                    Name = "Right"
                };

                RobotMap.Right.TalonObject1 = new WPILib.Talon(RobotMap.Right.Channel1);
                RobotMap.Right.TalonObject2 = new WPILib.Talon(RobotMap.Right.Channel2);

                RobotMap.Arm = new objects.Talon
                {
                    Channel = 6,
                    Name = "Arm"
                };

                RobotMap.Arm.TalonObject = new WPILib.Talon(RobotMap.Arm.Channel);

                RobotMap.ArmRoller = new objects.DoubleTalon
                {
                    Channel1 = 1,
                    Channel2 = 3,
                    Name = "ArmRoller"
                };

                RobotMap.ArmRoller.TalonObject1 = new WPILib.Talon(RobotMap.ArmRoller.Channel1);
                RobotMap.ArmRoller.TalonObject2 = new WPILib.Talon(RobotMap.ArmRoller.Channel2);

                RobotMap.Shooter = new objects.Solenoid
                {
                    Channel = 0,
                    Name = "Shooter"
                };
                RobotMap.Stick = new objects.Joystick
                {
                    Channel = 1,
                    Name = "Stick"
                };
                RobotMap.FireBall = new objects.Command
                {
                    ButtonID = 1,
                    Name = "Fire Ball",
                    OutputValue = -0.5
                };
                RobotMap.IntakeBall = new objects.Command
                {
                    ButtonID = 10,
                    Name = "Intake Ball",
                    OutputValue = -0.5
                };
                RobotMap.FireBallSlow = new objects.Command
                {
                    ButtonID = 11,
                    Name = "Fire Ball Slow",
                    OutputValue = 0.4
                };
                RobotMap.FireBallMedium = new objects.Command
                {
                    ButtonID = 12,
                    Name = "Fire Ball Medium",
                    OutputValue = 0.6
                };
                RobotMap.FireBallFast = new objects.Command
                {
                    ButtonID = 9,
                    Name = "Fire Ball Fast",
                    OutputValue = 1.00
                };
                RobotMap.LowerArm = new objects.Command
                {
                    ButtonID = 7,
                    Name = "Lower Arm",
                    OutputValue = -0.5
                };
                RobotMap.RaiseArm = new objects.Command
                {
                    ButtonID = 8,
                    Name = "Raise Arm",
                    OutputValue = 0.5
                };
                //Serialize(new RobotMap());
                //}
                //else
                //{
                //Deserialize();
                //}
            }
            //public static void Serialize(RobotMap map)
            //{
            //    //File.WriteAllText("home/lvuser/TOMT_Data.json", JsonConvert.SerializeObject(map));
            //}

            //public static void Deserialize()
            //{
            //    //RobotMap = JsonConvert.DeserializeObject<RobotMap>(File.ReadAllText("home/lvuser/TOMT_Data.json"));
            //}
        }
    }
}
