// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines contents of a web application firewall global configuration.
    /// </summary>
    public partial class PolicySettings
    {
        /// <summary>
        /// Initializes a new instance of the PolicySettings class.
        /// </summary>
        public PolicySettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicySettings class.
        /// </summary>
        /// <param name="enabledState">Describes if the policy is in enabled
        /// state or disabled state. Possible values include: 'Disabled',
        /// 'Enabled'</param>
        /// <param name="mode">Describes if it is in detection mode or
        /// prevention mode at policy level. Possible values include:
        /// 'Prevention', 'Detection'</param>
        public PolicySettings(WebApplicationFirewallEnabledState enabledState = default(WebApplicationFirewallEnabledState), WebApplicationFirewallMode mode = default(WebApplicationFirewallMode))
        {
            EnabledState = enabledState;
            Mode = mode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes if the policy is in enabled state or
        /// disabled state. Possible values include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "enabledState")]
        public WebApplicationFirewallEnabledState EnabledState { get; set; }

        /// <summary>
        /// Gets or sets describes if it is in detection mode or prevention
        /// mode at policy level. Possible values include: 'Prevention',
        /// 'Detection'
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public WebApplicationFirewallMode Mode { get; set; }

    }
}