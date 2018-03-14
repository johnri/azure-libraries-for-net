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
    using System.Linq;

    /// <summary>
    /// The deployment export result.
    /// </summary>
    public partial class DeploymentExportResultInner
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentExportResultInner
        /// class.
        /// </summary>
        public DeploymentExportResultInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentExportResultInner
        /// class.
        /// </summary>
        /// <param name="template">The template content.</param>
        public DeploymentExportResultInner(object template = default(object))
        {
            Template = template;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the template content.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public object Template { get; set; }

    }
}
