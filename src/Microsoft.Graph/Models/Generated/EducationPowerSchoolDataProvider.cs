// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type EducationPowerSchoolDataProvider.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class EducationPowerSchoolDataProvider : EducationSynchronizationDataProvider
    {
        public EducationPowerSchoolDataProvider()
        {
            this.ODataType = "microsoft.graph.educationPowerSchoolDataProvider";
        }
        /// <summary>
        /// Gets or sets connectionUrl.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectionUrl", Required = Newtonsoft.Json.Required.Default)]
        public string ConnectionUrl { get; set; }
    
        /// <summary>
        /// Gets or sets clientId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientId", Required = Newtonsoft.Json.Required.Default)]
        public string ClientId { get; set; }
    
        /// <summary>
        /// Gets or sets clientSecret.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "clientSecret", Required = Newtonsoft.Json.Required.Default)]
        public string ClientSecret { get; set; }
    
        /// <summary>
        /// Gets or sets schoolsIds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schoolsIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> SchoolsIds { get; set; }
    
        /// <summary>
        /// Gets or sets schoolYear.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "schoolYear", Required = Newtonsoft.Json.Required.Default)]
        public string SchoolYear { get; set; }
    
        /// <summary>
        /// Gets or sets allowTeachersInMultipleSchools.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowTeachersInMultipleSchools", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowTeachersInMultipleSchools { get; set; }
    
        /// <summary>
        /// Gets or sets customizations.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customizations", Required = Newtonsoft.Json.Required.Default)]
        public EducationSynchronizationCustomizations Customizations { get; set; }
    
    }
}