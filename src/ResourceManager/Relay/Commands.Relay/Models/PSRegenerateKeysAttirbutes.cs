// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Commands.Relay.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Parameters supplied to the Regenerate Authorization Rule operation.
    /// </summary>
    public partial class PSRegenerateKeysAttirbutes
    {
        /// <summary>
        /// Initializes a new instance of the RegenerateKeysParameters class.
        /// </summary>
        public PSRegenerateKeysAttirbutes() { }

        /// <summary>
        /// Initializes a new instance of the RegenerateKeysParameters class.
        /// </summary>
        /// <param name="policyKey">Key that needs to be regenerated. Possible
        /// values include: 'PrimaryKey', 'SecondaryKey'</param>
        public PSRegenerateKeysAttirbutes(string policyKey = default(string))
        {
            PolicyKey = policyKey;
        }

        /// <summary>
        /// Gets or sets key that needs to be regenerated. Possible values
        /// include: 'PrimaryKey', 'SecondaryKey'
        /// </summary>
        [JsonProperty(PropertyName = "policyKey")]
        public string PolicyKey { get; set; }

    }
}

