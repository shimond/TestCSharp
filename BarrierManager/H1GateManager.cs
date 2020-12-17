using System;
using System.Threading.Tasks;

namespace DoITRight
{
    internal class H1GateManager 
    {
        private string gateIP;

        public H1GateManager(string gateIP)
        {
            this.gateIP = gateIP;
        }

        internal async Task OpenGateForOnePerson()
        {
            Console.WriteLine("Opening gate..");
            await Task.Delay(2000);
            Console.WriteLine("Closing gate..");
        }
    }
}