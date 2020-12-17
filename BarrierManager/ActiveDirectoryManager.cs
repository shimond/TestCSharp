using System;
using System.Threading.Tasks;

namespace DoITRight
{
    internal class ActiveDirectoryManager 
    {
        private string adServerIp;

        public ActiveDirectoryManager(string adServerIp)
        {
            this.adServerIp = adServerIp;
        }

        internal async Task<bool> IsValid(string tz)
        {
            await Task.Delay(1000);
            return new Random().Next(0, 90000) % 2 == 0;
        }
    }
}