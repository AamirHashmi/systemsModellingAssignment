﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarParkSimulator
{
    class Barrier
    {
        private bool lifted = false;

        public void Lower()
        {
            lifted = false;
        }

        public void Raise()
        {
            lifted = true;
        }

        public bool IsLifted()
        {
            if(lifted)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}