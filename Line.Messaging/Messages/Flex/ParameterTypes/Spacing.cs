using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Line.Messaging
{
    public enum Spacing
    {
        [EnumMember(Value = "none")]
        None,

        [EnumMember(Value = "xs")]
        Xs,

        [EnumMember(Value = "sm")]
        Sm,

        [EnumMember(Value = "md")]
        Md,

        [EnumMember(Value = "lg")]
        Lg,

        [EnumMember(Value = "xl")]
        Xl,

        [EnumMember(Value = "xxl")]
        Xxl,
    }
}
