using System;
namespace DPM225428_TranThanhMyKim_Pattern10_Facade
{
    /// <summary>
    /// Facade Design Pattern
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            // Wait for user
            Console.ReadKey();
        }
    }
}