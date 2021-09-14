using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity.HataYonetimi.TryCatch
{
    public class OzelHataSinifi:Exception
    {
        public OzelHataSinifi()
        {
            Console.WriteLine("Hata sınıfı oluştu");
        }
    }
}
