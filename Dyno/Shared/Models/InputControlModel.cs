﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyno.Shared.Models
{
    public class InputControlModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public object Value { get; set; }
    }
}
