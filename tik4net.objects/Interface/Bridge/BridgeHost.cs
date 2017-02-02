using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tik4net.Objects.Interface.Bridge
{
    /// <summary>
    /// interface/bridge/port: Port submenu is used to enslave interfaces in a particular bridge interface.
    /// </summary>
    [TikEntity("interface/bridge/host")]
    public class BridgeHost
    {
        /// <summary>
        /// .id: primary key of row
        /// </summary>
        [TikProperty(".id", IsReadOnly = true, IsMandatory = true)]
        public string Id { get; private set; }

        /// <summary>
        /// mac-address: MACAddress Entry
        /// </summary>
        [TikProperty("mac-address")]
        public string/*name*/ MACAddress { get; set; }

        /// <summary>
        /// on-interface:  The interface this entry is seen on
        /// </summary>
        [TikProperty("on-interface")]
        public string/*name*/ OnInterface { get; set; }

        /// <summary>
        /// age: Age of the Entry
        /// </summary>
        [TikProperty("age")]
        public string Age { get; set; }

        /// <summary>
        /// bridge: Bridge this entry is seen on
        /// </summary>
        [TikProperty("bridge")]
        public string Bridge { get; set; }

    }
}
