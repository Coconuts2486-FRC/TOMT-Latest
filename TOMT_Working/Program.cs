//DO NOT MODIFY THIS CLASS
//This class automatically calls your robot class. Please place all user
//code in the TOMT_Working.cs class. Any changes made in here most likely
//will cause the program to not run.

using System.Reflection;
using WPILib;

namespace TOMT_Working
{
    public class Program
    {
        static void Main()
        {
            RobotBase.Main(null, typeof(TOMT_Working));
        }
    }
}
