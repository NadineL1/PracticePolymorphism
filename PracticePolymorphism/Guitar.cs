using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePolymorphism
{
    internal class Guitar : Instrument
    {
        public Guitar()
        { 
            
        }
        public override void Play()
        {
            Console.WriteLine("Strum strum on the guitar");
        }
    }

}
