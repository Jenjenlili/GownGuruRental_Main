using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GownGuru_MainSystem
{
    public static class SessionManager
    {
        private static Dictionary<string, object> sessionData = new Dictionary<string, object>();

        public static void Set(string key, object value)
        {
            if (sessionData.ContainsKey(key))
            {
                sessionData[key] = value;
            }
            else
            {
                sessionData.Add(key, value);
            }
        }

        public static object Get(string key)
        {
            return sessionData.ContainsKey(key) ? sessionData[key] : null;
        }
    }
}
