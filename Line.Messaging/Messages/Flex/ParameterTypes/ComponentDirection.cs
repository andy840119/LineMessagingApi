using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Line.Messaging
{
    public enum ComponentDirection
    {
        [EnumMember(Value = "ltr")]
        Ltr,

        [EnumMember(Value = "rtl")]
        Rtl,
    }
}
