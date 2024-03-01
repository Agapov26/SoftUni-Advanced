﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Seat : ICar 
    {
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; private set; }
        public string Color { get; private set; }

        public string Start()
        {
            return "Start";
        }
        public string Stop()
        {
            return "Stop";
        }

        public override string ToString()
        {
            return $"{Model} {Color}";
        }
    }
}
