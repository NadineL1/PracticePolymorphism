using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePolymorphism
{
    internal class Instrument
    {

        public Instrument()
        {

        }
        public virtual void Play()
        {
            Console.WriteLine("The instrument is playing beautifully.");
        }
    }
}
