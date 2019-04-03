﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Reflection;

namespace Line.Messaging.Extensions
{
    internal static class EnumExtension
    {
        public static string ToEnumString<T>(this T type)
        {
            /*
            var enumType = typeof(T);
            var name = Enum.GetName(enumType, type);
            var enumMemberAttribute =
                ((EnumMemberAttribute[])enumType.GetField(name).GetCustomAttributes(typeof(EnumMemberAttribute), true))
                .Single();
            return enumMemberAttribute.Value;
            */

            return type.ToString();
        }

        public static T ToEnum<T>(this string str) where T : struct
        {
            /*
            var enumType = typeof(T);
            foreach (var name in Enum.GetNames(enumType))
            {
                var enumMemberAttribute =
                    ((EnumMemberAttribute[])enumType.GetField(name)
                        .GetCustomAttributes(typeof(EnumMemberAttribute), true)).Single();
                if (enumMemberAttribute.Value == str) return (T)Enum.Parse(enumType, name);
            }
            */

            if (Enum.TryParse(str, out T result))
                return result;

            //throw exception or whatever handling you want or
            return default(T);
        }
    }
}