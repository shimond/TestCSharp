using System;
using System.Threading.Tasks;

namespace DoITRight
{
    public class BarrierWorkflowManager
    {
        private readonly HpCardReader _hpCardManager;
        private readonly H1GateManager _h1GateManager;
        private readonly ActiveDirectoryManager _adUserManager;

        public async Task StartFlow()
        {
            while (true)
            {
                var tz = await _hpCardManager.GetSSNFromCard();
                if (await _adUserManager.IsValid(tz))
                {
                    await _h1GateManager.OpenGateForOnePerson();
                }
                else
                {
                    Console.WriteLine("Tz not valid");
                }
            }
        }

        public BarrierWorkflowManager(string gateIP, string adServerIp)
        {
            _hpCardManager = new HpCardReader();
            _h1GateManager = new H1GateManager(gateIP);
            _adUserManager = new ActiveDirectoryManager(adServerIp);
        }
    }
}
