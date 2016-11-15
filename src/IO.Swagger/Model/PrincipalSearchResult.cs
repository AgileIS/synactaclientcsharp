/* 
 * Synacta
 *
 * WebApi
 *
 * OpenAPI spec version: v1
 * Contact: bhofmann@agile-is.de
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace IO.Swagger.Model
{
    /// <summary>
    /// PrincipalSearchResult
    /// </summary>
    [DataContract]
    public partial class PrincipalSearchResult :  IEquatable<PrincipalSearchResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrincipalSearchResult" /> class.
        /// </summary>
        /// <param name="ResultType">ResultType.</param>
        /// <param name="CustomProperties">CustomProperties.</param>
        /// <param name="OdataContext">OdataContext.</param>
        /// <param name="OdataReadLink">OdataReadLink.</param>
        /// <param name="FullODataLinkodataNavigationLink">FullODataLinkodataNavigationLink.</param>
        /// <param name="StandardODataLinkodataNavigationLink">StandardODataLinkodataNavigationLink.</param>
        /// <param name="NoneODataLinkodataNavigationLink">NoneODataLinkodataNavigationLink.</param>
        public PrincipalSearchResult(string ResultType = null, Dictionary<string, Object> CustomProperties = null, string OdataContext = null, string OdataReadLink = null, string FullODataLinkodataNavigationLink = null, string StandardODataLinkodataNavigationLink = null, string NoneODataLinkodataNavigationLink = null)
        {
            this.ResultType = ResultType;
            this.CustomProperties = CustomProperties;
            this.OdataContext = OdataContext;
            this.OdataReadLink = OdataReadLink;
            this.FullODataLinkodataNavigationLink = FullODataLinkodataNavigationLink;
            this.StandardODataLinkodataNavigationLink = StandardODataLinkodataNavigationLink;
            this.NoneODataLinkodataNavigationLink = NoneODataLinkodataNavigationLink;
        }
        
        /// <summary>
        /// Gets or Sets ResultType
        /// </summary>
        [DataMember(Name="resultType", EmitDefaultValue=false)]
        public string ResultType { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Gets or Sets CustomProperties
        /// </summary>
        [DataMember(Name="customProperties", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomProperties { get; set; }
        /// <summary>
        /// Gets or Sets OdataContext
        /// </summary>
        [DataMember(Name="@odata.context", EmitDefaultValue=false)]
        public string OdataContext { get; set; }
        /// <summary>
        /// Gets or Sets OdataReadLink
        /// </summary>
        [DataMember(Name="@odata.readLink", EmitDefaultValue=false)]
        public string OdataReadLink { get; set; }
        /// <summary>
        /// Gets or Sets FullODataLinkodataNavigationLink
        /// </summary>
        [DataMember(Name="FullODataLink@odata.navigationLink", EmitDefaultValue=false)]
        public string FullODataLinkodataNavigationLink { get; set; }
        /// <summary>
        /// Gets or Sets StandardODataLinkodataNavigationLink
        /// </summary>
        [DataMember(Name="StandardODataLink@odata.navigationLink", EmitDefaultValue=false)]
        public string StandardODataLinkodataNavigationLink { get; set; }
        /// <summary>
        /// Gets or Sets NoneODataLinkodataNavigationLink
        /// </summary>
        [DataMember(Name="NoneODataLink@odata.navigationLink", EmitDefaultValue=false)]
        public string NoneODataLinkodataNavigationLink { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrincipalSearchResult {\n");
            sb.Append("  ResultType: ").Append(ResultType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CustomProperties: ").Append(CustomProperties).Append("\n");
            sb.Append("  OdataContext: ").Append(OdataContext).Append("\n");
            sb.Append("  OdataReadLink: ").Append(OdataReadLink).Append("\n");
            sb.Append("  FullODataLinkodataNavigationLink: ").Append(FullODataLinkodataNavigationLink).Append("\n");
            sb.Append("  StandardODataLinkodataNavigationLink: ").Append(StandardODataLinkodataNavigationLink).Append("\n");
            sb.Append("  NoneODataLinkodataNavigationLink: ").Append(NoneODataLinkodataNavigationLink).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PrincipalSearchResult);
        }

        /// <summary>
        /// Returns true if PrincipalSearchResult instances are equal
        /// </summary>
        /// <param name="other">Instance of PrincipalSearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrincipalSearchResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ResultType == other.ResultType ||
                    this.ResultType != null &&
                    this.ResultType.Equals(other.ResultType)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.CustomProperties == other.CustomProperties ||
                    this.CustomProperties != null &&
                    this.CustomProperties.SequenceEqual(other.CustomProperties)
                ) && 
                (
                    this.OdataContext == other.OdataContext ||
                    this.OdataContext != null &&
                    this.OdataContext.Equals(other.OdataContext)
                ) && 
                (
                    this.OdataReadLink == other.OdataReadLink ||
                    this.OdataReadLink != null &&
                    this.OdataReadLink.Equals(other.OdataReadLink)
                ) && 
                (
                    this.FullODataLinkodataNavigationLink == other.FullODataLinkodataNavigationLink ||
                    this.FullODataLinkodataNavigationLink != null &&
                    this.FullODataLinkodataNavigationLink.Equals(other.FullODataLinkodataNavigationLink)
                ) && 
                (
                    this.StandardODataLinkodataNavigationLink == other.StandardODataLinkodataNavigationLink ||
                    this.StandardODataLinkodataNavigationLink != null &&
                    this.StandardODataLinkodataNavigationLink.Equals(other.StandardODataLinkodataNavigationLink)
                ) && 
                (
                    this.NoneODataLinkodataNavigationLink == other.NoneODataLinkodataNavigationLink ||
                    this.NoneODataLinkodataNavigationLink != null &&
                    this.NoneODataLinkodataNavigationLink.Equals(other.NoneODataLinkodataNavigationLink)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ResultType != null)
                    hash = hash * 59 + this.ResultType.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.CustomProperties != null)
                    hash = hash * 59 + this.CustomProperties.GetHashCode();
                if (this.OdataContext != null)
                    hash = hash * 59 + this.OdataContext.GetHashCode();
                if (this.OdataReadLink != null)
                    hash = hash * 59 + this.OdataReadLink.GetHashCode();
                if (this.FullODataLinkodataNavigationLink != null)
                    hash = hash * 59 + this.FullODataLinkodataNavigationLink.GetHashCode();
                if (this.StandardODataLinkodataNavigationLink != null)
                    hash = hash * 59 + this.StandardODataLinkodataNavigationLink.GetHashCode();
                if (this.NoneODataLinkodataNavigationLink != null)
                    hash = hash * 59 + this.NoneODataLinkodataNavigationLink.GetHashCode();
                return hash;
            }
        }
    }

}
