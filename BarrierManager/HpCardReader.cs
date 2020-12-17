using System;
using System.Linq;
using System.Threading.Tasks;

namespace DoITRight
{
    internal class HpCardReader 
    {
        public HpCardReader()
        {
        }

        public async ValueTask<string> GetSSNFromCard()
        {
            Random rnd = new Random();
            await Task.Delay(5000);
            return string.Join("", Enumerable.Range(0, 9).Select(x=> rnd.Next(0, 10).ToString()));
        }
    }
}