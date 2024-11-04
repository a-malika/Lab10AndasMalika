using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade(new AudioSystem(), new VideoProjector(), new LightingSystem());
            homeTheaterFacade.Start();
            homeTheaterFacade.Stop();
        }
    }
}
