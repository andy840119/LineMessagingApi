using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Line.Messaging
{
    public enum Align
    {
        [EnumMember(Value = "start")]
        Start,

        [EnumMember(Value = "end")]
        End,

        [EnumMember(Value = "center")]
        Center
    }
}
