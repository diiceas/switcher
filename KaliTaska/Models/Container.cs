﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KaliTaska.Models {
    public class Container {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<KTask> Tasks { get; set; }
    }
}