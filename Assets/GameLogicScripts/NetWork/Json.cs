using System;
using System.Collections.Generic;
using SharpKit.JavaScript;

namespace Network
{
    [JsType(JsMode.Prototype, Export = false, Name = "JSON")]
    public class JSON
    {
        public static string stringify(object obj, JsFunc<object, object, object> replacer)
        {
            return (string)null;
        }

        public static string stringify(object obj, JsFunc<object, object, object> replacer, int space)
        {
            return (string)null;
        }

        public static string stringify(object obj, JsFunc<object, object, object> replacer, string space)
        {
            return (string)null;
        }

        public static string stringify(object obj)
        {
            return (string)null;
        }

        public static object parse(JsString json)
        {
            return (object)null;
        }

        public static T parse<T>(JsString json)
        {
            return default(T);
        }
    }
}
