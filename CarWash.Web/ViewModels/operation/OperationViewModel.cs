﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.operation
{
    public class OperationViewModel
    {
        public string Code { get; set; }

        public List<KeyValuePair<string, string>> Messages { get; set; }

        public dynamic Data { get; set; }
    }
}
