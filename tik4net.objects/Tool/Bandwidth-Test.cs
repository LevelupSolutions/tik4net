using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tik4net.Objects.Tool
{
    /// <summary>
    /// Ping uses Internet Control Message Protocol (ICMP) Echo messages to determine if a remote host is active or inactive and to determine the round-trip delay when communicating with it. Ping tool sends ICMP (type 8) message to the host and waits for the ICMP echo-reply (type 0). The interval between these events is called round trip. If the response (that is called pong) has not come until the end of the interval, we assume it has timed out. The second significant parameter reported is ttl (Time to Live). Is is decremented at each machine in which the packet is processed. The packet will reach its destination only when the ttl is greater than the number of routers between the source and the destination.
    /// Author: seho85
    /// </summary>
    [TikEntity("/tool/bandwidth-test", IsReadOnly = true, IncludeProplist = false)]
    public class BandwidthTest
    {

        /// <summary>
        /// Sequence number
        /// </summary>
        [TikProperty("status", IsReadOnly = true)]
        public string status { get; private set; }

        /// <summary>
        /// Pinged host.
        /// </summary>
        [TikProperty("duration", IsReadOnly = true)]
        public string Duration { get; private set; }

        /// <summary>
        /// Time to live parameter adjustment
        /// </summary>
        [TikProperty("tx-current", IsReadOnly = true)]
        public long CurrentTransmit { get; private set; }

        /// <summary>
        /// Time to live parameter adjustment
        /// </summary>
        [TikProperty("tx-10-second-average", IsReadOnly = true)]
        public long TenSecAvgTransmit { get; private set; }

        /// <summary>
        /// Time to live parameter adjustment
        /// </summary>
        [TikProperty("tx-total-average", IsReadOnly = true)]
        public long TotalAverageTransmit { get; private set; }

        /// <summary>
        /// Time to live parameter adjustment
        /// </summary>
        [TikProperty("rx-current", IsReadOnly = true)]
        public long CurrentReceive { get; private set; }

        /// <summary>
        /// Time to live parameter adjustment
        /// </summary>
        [TikProperty("rx-10-second-average", IsReadOnly = true)]
        public long TenSecAvgReceive { get; private set; }

        /// <summary>
        /// Time to live parameter adjustment
        /// </summary>
        [TikProperty("rx-total-average", IsReadOnly = true)]
        public long TotalAverageReceive { get; private set; }

        /// <summary>
        /// Time to live parameter adjustment
        /// </summary>
        [TikProperty("lost-packets", IsReadOnly = true)]
        public long LostPackets { get; private set; }

        /// <summary>
        /// Time to live parameter adjustment
        /// </summary>
        [TikProperty("random-data", IsReadOnly = true)]
        public string RandomData { get; private set; }

        /// <summary>
        /// Time to live parameter adjustment
        /// </summary>
        [TikProperty("direction", IsReadOnly = true)]
        public string Direction { get; private set; }

        /// <summary>
        /// Time to live parameter adjustment
        /// </summary>
        [TikProperty("tx-size", IsReadOnly = true)]
        public long TXSize { get; private set; }

        /// <summary>
        /// Time to live parameter adjustment
        /// </summary>
        [TikProperty("rx-size", IsReadOnly = true)]
        public string RXSize { get; private set; }

        /// <summary>
        /// Time to live parameter adjustment
        /// </summary>
        [TikProperty(".section", IsReadOnly = true)]
        public long Section { get; private set; }
    }
}
