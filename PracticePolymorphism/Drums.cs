using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePolymorphism
{
    internal class Drums : Instrument
    {
        public Drums()
        {
            
        }
        public override void Play()
        {
            Console.WriteLine("Bang bang on the drums");
        }
    }
}
