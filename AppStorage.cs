using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace XF.CommonLibrary
{
    /// <summary>
    /// Make use of Xamarin Essential "Preferences", easily get / set the value with the key
    /// Support data type
    /// string, bool, DateTime, int, float, long, double
    /// </summary>
    public class AppStorage
    {
        public static T GetValue<T>(string key)
        {
            if (typeof(T) == typeof(string))
                return (T)(object)Preferences.Get(key, string.Empty);
            else if (typeof(T) == typeof(bool))
                return (T)(object)Preferences.Get(key, default(bool));
            else if (typeof(T) == typeof(DateTime))
                return (T)(object)Preferences.Get(key, default(DateTime));
            else if (typeof(T) == typeof(int))
                return (T)(object)Preferences.Get(key, default(int));
            else if (typeof(T) == typeof(float))
                return (T)(object)Preferences.Get(key, default(float));
            else if (typeof(T) == typeof(long))
                return (T)(object)Preferences.Get(key, default(long));
            else if (typeof(T) == typeof(double))
                return (T)(object)Preferences.Get(key, default(double));
            else return default(T);
        }
        public static void SetValue<T>(string key, T value)
        {
            if (typeof(T) == typeof(string))
                Preferences.Set(key, Convert.ToString(value));
            else if (typeof(T) == typeof(bool))
                Preferences.Set(key, Convert.ToBoolean(value));
            else if (typeof(T) == typeof(DateTime))
                Preferences.Set(key, Convert.ToDateTime(value));
            else if (typeof(T) == typeof(int))
                Preferences.Set(key, Convert.ToInt32(value));
            else if (typeof(T) == typeof(float))
                Preferences.Set(key, Convert.ToSingle(value));
            else if (typeof(T) == typeof(long))
                Preferences.Set(key, Convert.ToInt64(value));
            else if (typeof(T) == typeof(double))
                Preferences.Set(key, Convert.ToDouble(value));
        }
    }
}
