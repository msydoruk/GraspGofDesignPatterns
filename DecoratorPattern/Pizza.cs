﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Pizza : IPizza
    {
        public string GetIngredients()
        {
            return string.Empty;
        }
    }
}
