﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PoGoMITM.Base.Models
{
    public interface IRequestParser
    {
        Task ParseRequest(RequestContext requestContext);
        object SignatureDecryptor { get; set; }
    }
}