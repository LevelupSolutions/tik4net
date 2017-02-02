using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tik4net.Objects.Interface
{
    /// <summary>
    /// /interface
    /// </summary>
    [TikEntity("/interface/vlan", IncludeDetails = true)]
    public class Vlan
    {
        /// <summary>
        /// .id
        /// </summary>
        [TikProperty(".id", IsReadOnly = true, IsMandatory = true)]
        public string Id { get; private set; }

        /// <summary>
        /// name
        /// </summary>
        [TikProperty("name", IsMandatory = true)]
        public string Name { get; set; }

        /// <summary>
        /// mtu
        /// </summary>
        [TikProperty("mtu")]
        public string Mtu { get; set; }

        /// <summary>
        /// l2mtu
        /// </summary>
        [TikProperty("l2mtu")]
        public string Layer2MTU { get; set; }

        /// <summary>
        /// mac-address
        /// </summary>
        [TikProperty("mac-address")]
        public string MacAddress { get; set; }

        /// <summary>
        /// vlan-id
        /// </summary>
        [TikProperty("vlan-id", IsMandatory = true)]
        public int VLANID { get; set; }

        /// <summary>
        /// interface
        /// </summary>
        [TikProperty("interface", IsMandatory = true)]
        public string Interface { get; set; }

        /// <summary>
        /// comment
        /// </summary>
        [TikProperty("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Use Service Tag
        /// </summary>
        [TikProperty("use-service-tag")]
        public bool UseServiceTag { get; set; }
    }

}
