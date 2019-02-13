using System;
using Xamarin.Essentials;

namespace XF.CommonLibrary
{
    public class CommonObject
    {
        public class NetworkConnection
        {
            public bool IsConnected
            {
                get { return Connectivity.NetworkAccess == NetworkAccess.Internet; }
            }
            public bool IsWifiAccess
            {
                get
                {
                    foreach (var connectionProfile in Connectivity.ConnectionProfiles)
                    {
                        if (connectionProfile == ConnectionProfile.WiFi)
                            return true;
                    }
                    return false;
                }
            }
        }
    }
}
