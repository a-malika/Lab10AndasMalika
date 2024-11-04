using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory10
{
    public class HomeTheaterFacade
    {
        private AudioSystem _audioSystem;
        private VideoProjector _videoProjector;
        private LightingSystem _lightingSystem;
        public HomeTheaterFacade(AudioSystem audioSystem, VideoProjector videoProjector, LightingSystem lightingSystem)
        {
            _audioSystem = audioSystem;
            _videoProjector = videoProjector;
            _lightingSystem = lightingSystem;
        }
        public void Start()
        {
            _lightingSystem.LightOn();
            _videoProjector.VideoOn();
            _audioSystem.SoundOn();
            _audioSystem.RaiseSound();
            Console.WriteLine("Home Theater is started.\n");
        }
        public void Stop()
        {
            _audioSystem.LowerSound();
            _audioSystem.SoundOff();
            _videoProjector.VideoOff();
            _lightingSystem.LightOff();
            Console.WriteLine("Home Theater is stopped.\n");
        }
    }
}
