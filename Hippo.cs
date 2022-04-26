﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Hippo : Animal, ISwimmer
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Grunt");
        }

        public void Swim()
        {
            Console.WriteLine("Splash! I'm going for a swim!");
        }

    }
}
