// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Resource provider information.
    /// </summary>
    public partial class ProviderInner
    {
        /// <summary>
        /// Initializes a new instance of the ProviderInner class.
        /// </summary>
        public ProviderInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProviderInner class.
        /// </summary>
        /// <param name="id">The provider ID.</param>
        /// <param name="namespaceProperty">The namespace of the resource
        /// provider.</param>
        /// <param name="registrationState">The registration state of the
        /// provider.</param>
        /// <param name="resourceTypes">The collection of provider resource
        /// types.</param>
        public ProviderInner(string id = default(string), string namespaceProperty = default(string), string registrationState = default(string), IList<ProviderResourceType> resourceTypes = default(IList<ProviderResourceType>))
        {
            Id = id;
            NamespaceProperty = namespaceProperty;
            RegistrationState = registrationState;
            ResourceTypes = resourceTypes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provider ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the namespace of the resource provider.
        /// </summary>
        [JsonProperty(PropertyName = "namespace")]
        public string NamespaceProperty { get; set; }

        /// <summary>
        /// Gets the registration state of the provider.
        /// </summary>
        [JsonProperty(PropertyName = "registrationState")]
        public string RegistrationState { get; private set; }

        /// <summary>
        /// Gets the collection of provider resource types.
        /// </summary>
        [JsonProperty(PropertyName = "resourceTypes")]
        public IList<ProviderResourceType> ResourceTypes { get; private set; }

    }
}
