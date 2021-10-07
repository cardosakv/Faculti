using System.Linq;
using System.Net.NetworkInformation;

namespace Faculti.Helpers
{
    /// <summary>
    ///     Helper class relating about internet connectivity.
    /// </summary>
    internal class Internet
    {
        /// <summary>
        ///     Checks if an active internet connection is present.
        /// </summary>
        public static bool IsAvailableNetworkActive()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
                return (from face in interfaces
                        where face.OperationalStatus == OperationalStatus.Up
                        where (face.NetworkInterfaceType != NetworkInterfaceType.Tunnel) && (face.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                        select face.GetIPv4Statistics()).Any(statistics => (statistics.BytesReceived > 0) && (statistics.BytesSent > 0));
            }

            return false;
        }
    }
}