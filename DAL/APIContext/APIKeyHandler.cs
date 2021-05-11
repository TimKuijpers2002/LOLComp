using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.APIContext
{
    public class APIKeyHandler
    {
        private static string riotKey = "";

        public static void SetAPIKey(string _riotKey)
        {
            riotKey = _riotKey;
        }

        public string UseRiotKey()
        {
            return riotKey;
        }
    }
}
