﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using Newtonsoft.Json.Linq;

namespace DotVue
{
    /// <summary>
    /// Define C# class field as an Vue props - do not update this value in server-side
    /// </summary>
    [AttributeUsage(AttributeTargets.Field)]
    public class PropAttribute : Attribute
    {
    }
}
