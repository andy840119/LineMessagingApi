using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Line.Messaging
{
    public enum ButtonStyle
    {
        [EnumMember(Value = "link")]
        Link,

        [EnumMember(Value = "primary")]
        Primary,

        [EnumMember(Value = "secondary")]
        Secondary,
    }
}
