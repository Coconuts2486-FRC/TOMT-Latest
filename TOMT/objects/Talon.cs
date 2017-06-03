namespace TOMT.objects
{
    public class Talon
    {
        public int Channel { get; set; }

        public string Name { get; set; }

        public WPILib.Talon TalonObject { get; set; }

        public Talon()
        {
            
        }

        public void SetSpeed(double speed)
        {
            TalonObject.Set(speed);
        }

        public void Stop()
        {
            SetSpeed(0);
        }
    }
}
