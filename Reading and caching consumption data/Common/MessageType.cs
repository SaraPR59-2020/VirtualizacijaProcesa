﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public enum MessageType
    {
        [EnumMember]
        Info,
        [EnumMember]
        Warning,
        [EnumMember]
        Error
    }
}
