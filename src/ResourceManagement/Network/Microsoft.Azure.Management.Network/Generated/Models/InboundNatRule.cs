// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Inbound NAT rule of the loadbalancer
    /// </summary>
    public partial class InboundNatRule : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the InboundNatRule class.
        /// </summary>
        public InboundNatRule() { }

        /// <summary>
        /// Initializes a new instance of the InboundNatRule class.
        /// </summary>
        public InboundNatRule(string id = default(string), string name = default(string), string etag = default(string), SubResource frontendIPConfiguration = default(SubResource), NetworkInterfaceIPConfiguration backendIPConfiguration = default(NetworkInterfaceIPConfiguration), string protocol = default(string), int? frontendPort = default(int?), int? backendPort = default(int?), int? idleTimeoutInMinutes = default(int?), bool? enableFloatingIP = default(bool?), string provisioningState = default(string))
            : base(id)
        {
            Name = name;
            Etag = etag;
            FrontendIPConfiguration = frontendIPConfiguration;
            BackendIPConfiguration = backendIPConfiguration;
            Protocol = protocol;
            FrontendPort = frontendPort;
            BackendPort = backendPort;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
            EnableFloatingIP = enableFloatingIP;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets name of the resource that is unique within a resource group.
        /// This name can be used to access the resource
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// A unique read-only string that changes whenever the resource is
        /// updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets a reference to frontend IP Addresses
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendIPConfiguration")]
        public SubResource FrontendIPConfiguration { get; set; }

        /// <summary>
        /// Gets or sets a reference to a private ip address defined on a
        /// NetworkInterface of a VM. Traffic sent to frontendPort of each of
        /// the frontendIPConfigurations is forwarded to the backed IP
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendIPConfiguration")]
        public NetworkInterfaceIPConfiguration BackendIPConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the transport potocol for the external endpoint.
        /// Possible values are Udp or Tcp. Possible values for this property
        /// include: 'Udp', 'Tcp'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.protocol")]
        public string Protocol { get; set; }

        /// <summary>
        /// Gets or sets the port for the external endpoint. You can spcify
        /// any port number you choose, but the port numbers specified for
        /// each role in the service must be unique. Possible values range
        /// between 1 and 65535, inclusive
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendPort")]
        public int? FrontendPort { get; set; }

        /// <summary>
        /// Gets or sets a port used for internal connections on the endpoint.
        /// The localPort attribute maps the eternal port of the endpoint to
        /// an internal port on a role. This is useful in scenarios where a
        /// role must communicate to an internal compotnent on a port that is
        /// different from the one that is exposed externally. If not
        /// specified, the value of localPort is the same as the port
        /// attribute. Set the value of localPort to '*' to automatically
        /// assign an unallocated port that is discoverable using the runtime
        /// API
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendPort")]
        public int? BackendPort { get; set; }

        /// <summary>
        /// Gets or sets the timeout for the Tcp idle connection. The value
        /// can be set between 4 and 30 minutes. The default value is 4
        /// minutes. This emlement is only used when the protocol is set to
        /// Tcp
        /// </summary>
        [JsonProperty(PropertyName = "properties.idleTimeoutInMinutes")]
        public int? IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Configures a virtual machine's endpoint for the floating IP
        /// capability required to configure a SQL AlwaysOn availability
        /// Group. This setting is required when using the SQL Always ON
        /// availability Groups in SQL server. This setting can't be changed
        /// after you create the endpoint
        /// </summary>
        [JsonProperty(PropertyName = "properties.enableFloatingIP")]
        public bool? EnableFloatingIP { get; set; }

        /// <summary>
        /// Gets or sets Provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
