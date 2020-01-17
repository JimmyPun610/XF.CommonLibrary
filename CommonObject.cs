using System;
using Xamarin.Essentials;

namespace XF.CommonLibrary
{
    public class CommonObject
    {
        public class NetworkConnection
        {
            /// <summary>
            /// Fired when connectivity changed
            /// </summary>
            public event Action<ConnectivityChangedEventArgs> ConnectivityChanged;
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
            public NetworkConnection()
            {
                Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
            }

            private void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
            {
                ConnectivityChanged?.Invoke(e);
            }
        }
    }
}
