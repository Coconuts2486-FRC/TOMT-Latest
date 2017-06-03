using System;
using System.Collections.Generic;
using System.Linq;
using TOMT.objects;
using WPILib;
using WPILib.SmartDashboard;

namespace TOMT
{
    public class TOMT : SampleRobot
    {

        protected override void RobotInit()
        {
            ClassAssembler.Load();
        }

        public override void Autonomous()
        {

        }

        public override void OperatorControl()
        {
            while(IsOperatorControl && IsEnabled)
            {
                // Intake
                if (RobotMap.Stick.JoystickObject.GetRawButton(RobotMap.IntakeBall.ButtonID))
                {
                    RobotMap.ArmRoller.SetSpeed(-RobotMap.IntakeBall.OutputValue, RobotMap.IntakeBall.OutputValue);
                }
                // Fire Slow
                else if (RobotMap.Stick.JoystickObject.GetRawButton(RobotMap.FireBallSlow.ButtonID))
                {
                    RobotMap.ArmRoller.SetSpeed(RobotMap.FireBallSlow.OutputValue, -RobotMap.FireBallSlow.OutputValue);
                }
                //Fire Medium
                else if (RobotMap.Stick.JoystickObject.GetRawButton(RobotMap.FireBallMedium.ButtonID))
                {
                    RobotMap.ArmRoller.SetSpeed(RobotMap.FireBallMedium.OutputValue, -RobotMap.FireBallMedium.OutputValue);
                }
                //Fire Fast
                else if (RobotMap.Stick.JoystickObject.GetRawButton(RobotMap.FireBallFast.ButtonID))
                {
                    RobotMap.ArmRoller.SetSpeed(RobotMap.FireBallFast.OutputValue, -RobotMap.FireBallFast.OutputValue);
                }
                else
                {
                    RobotMap.ArmRoller.Stop();
                }

                // Fire For Realsies{
                if (RobotMap.Stick.JoystickObject.GetRawButton(RobotMap.FireBall.ButtonID))
                {
                    RobotMap.Shooter.SolenoidObject.Set(true);
                }
                else
                {
                    RobotMap.Shooter.SolenoidObject.Set(false);
                }
            }
        }

        public override void Test()
        {

        }
    }
}
