using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Line.Messaging
{
    public enum ComponentSize
    {
        [EnumMember(Value = "xxs")]
        Xxs,

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

        [EnumMember(Value = "3xl")]
        _3xl,

        [EnumMember(Value = "4xl")]
        _4xl,

        [EnumMember(Value = "5xl")]
        _5xl,

        [EnumMember(Value = "full")]
        Full
    }
}