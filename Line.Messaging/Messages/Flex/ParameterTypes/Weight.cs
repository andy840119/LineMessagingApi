using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Line.Messaging
{
    public enum Weight
    {
        [EnumMember(Value = "regular")]
        Regular,

        [EnumMember(Value = "bold")]
        Bold
    }
}
