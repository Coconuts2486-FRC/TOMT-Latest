using TOMT.objects;

namespace TOMT
{
    public static class RobotMap
    {
        public static DoubleTalon Left      { get; set; }
        public static DoubleTalon Right     { get; set; }
        public static DoubleTalon ArmRoller { get; set; }

        public static Talon Arm             { get; set; }

        public static Solenoid Shooter { get; set; }

        public static Joystick Stick { get; set; }

        public static Command RaiseArm       { get; set; }
        public static Command LowerArm       { get; set; }
        public static Command IntakeBall     { get; set; }
        public static Command FireBall       { get; set; }
        public static Command FireBallSlow   { get; set; }
        public static Command FireBallMedium { get; set; }
        public static Command FireBallFast   { get; set; }
    }
}
