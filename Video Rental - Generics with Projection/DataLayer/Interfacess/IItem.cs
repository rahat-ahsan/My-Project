﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfacess
{
    public interface IItem
    {
         Guid Id { get; set; }
         string Name { get; set; }
    }
}
