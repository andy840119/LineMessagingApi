using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Line.Messaging
{
    public enum Gravity
    {
        [EnumMember(Value = "top")]
        Top,

        [EnumMember(Value = "bottom")]
        Bottom,

        [EnumMember(Value = "center")]
        Center
    }
}
