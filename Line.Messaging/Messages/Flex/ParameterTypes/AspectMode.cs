using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Line.Messaging
{
    public enum AspectMode
    {
        [EnumMember(Value = "cover")]
        Cover,

        [EnumMember(Value = "fit")]
        Fit,
    }
}
