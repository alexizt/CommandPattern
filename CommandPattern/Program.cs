using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var lamp = new Lamp();
            var remote = new RemoteControl(lamp);
            
            Console.WriteLine(lamp.Description());
            remote.ClickOn();
            Console.WriteLine(lamp.Description());
            remote.ClickOff();
            Console.WriteLine(lamp.Description());
            Console.WriteLine("Press anykey to exit...");
            Console.ReadKey(true);
        }
    }
}
