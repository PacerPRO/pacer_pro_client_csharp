/* 
 * PacerPro
 *
 * PacerPro API documentation.
 *
 * OpenAPI spec version: 0.2.1
 * Contact: ken@pacerpro.com
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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PropertyChanged;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IO.PacerPro.Model
{
    /// <summary>
    /// An object that represents a matter, i.e., a case in federal court, joined with client matter identification.
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class Matter :  IEquatable<Matter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Matter" /> class.
        /// </summary>
        /// <param name="Id">Database identifier of the object..</param>
        /// <param name="CaseId">Database identifier of the Case object..</param>
        /// <param name="ClientMatterNumber">Client/matter billing code..</param>
        /// <param name="Judge">Initials of the presiding judge..</param>
        /// <param name="CaseNumber">Canonical case number..</param>
        /// <param name="CaseTitle">Canonical case title..</param>
        /// <param name="NatureOfSuit">Judicial Conference designation of the case..</param>
        /// <param name="DocketEntries">The count of docket entries in the case..</param>
        /// <param name="ActivityAt">The time of last activity in the case. .</param>
        public Matter(string Id = null, string CaseId = null, string ClientMatterNumber = null, string Judge = null, string CaseNumber = null, string CaseTitle = null, string NatureOfSuit = null, int? DocketEntries = null, DateTime? ActivityAt = null)
        {
            this.Id = Id;
            this.CaseId = CaseId;
            this.ClientMatterNumber = ClientMatterNumber;
            this.Judge = Judge;
            this.CaseNumber = CaseNumber;
            this.CaseTitle = CaseTitle;
            this.NatureOfSuit = NatureOfSuit;
            this.DocketEntries = DocketEntries;
            this.ActivityAt = ActivityAt;
        }
        
        /// <summary>
        /// Database identifier of the object.
        /// </summary>
        /// <value>Database identifier of the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Database identifier of the Case object.
        /// </summary>
        /// <value>Database identifier of the Case object.</value>
        [DataMember(Name="caseId", EmitDefaultValue=false)]
        public string CaseId { get; set; }
        /// <summary>
        /// Client/matter billing code.
        /// </summary>
        /// <value>Client/matter billing code.</value>
        [DataMember(Name="clientMatterNumber", EmitDefaultValue=false)]
        public string ClientMatterNumber { get; set; }
        /// <summary>
        /// Initials of the presiding judge.
        /// </summary>
        /// <value>Initials of the presiding judge.</value>
        [DataMember(Name="judge", EmitDefaultValue=false)]
        public string Judge { get; set; }
        /// <summary>
        /// Canonical case number.
        /// </summary>
        /// <value>Canonical case number.</value>
        [DataMember(Name="caseNumber", EmitDefaultValue=false)]
        public string CaseNumber { get; set; }
        /// <summary>
        /// Canonical case title.
        /// </summary>
        /// <value>Canonical case title.</value>
        [DataMember(Name="caseTitle", EmitDefaultValue=false)]
        public string CaseTitle { get; set; }
        /// <summary>
        /// Judicial Conference designation of the case.
        /// </summary>
        /// <value>Judicial Conference designation of the case.</value>
        [DataMember(Name="natureOfSuit", EmitDefaultValue=false)]
        public string NatureOfSuit { get; set; }
        /// <summary>
        /// The count of docket entries in the case.
        /// </summary>
        /// <value>The count of docket entries in the case.</value>
        [DataMember(Name="docketEntries", EmitDefaultValue=false)]
        public int? DocketEntries { get; set; }
        /// <summary>
        /// The time of last activity in the case. 
        /// </summary>
        /// <value>The time of last activity in the case. </value>
        [DataMember(Name="activityAt", EmitDefaultValue=false)]
        public DateTime? ActivityAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Matter {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CaseId: ").Append(CaseId).Append("\n");
            sb.Append("  ClientMatterNumber: ").Append(ClientMatterNumber).Append("\n");
            sb.Append("  Judge: ").Append(Judge).Append("\n");
            sb.Append("  CaseNumber: ").Append(CaseNumber).Append("\n");
            sb.Append("  CaseTitle: ").Append(CaseTitle).Append("\n");
            sb.Append("  NatureOfSuit: ").Append(NatureOfSuit).Append("\n");
            sb.Append("  DocketEntries: ").Append(DocketEntries).Append("\n");
            sb.Append("  ActivityAt: ").Append(ActivityAt).Append("\n");
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
            return this.Equals(obj as Matter);
        }

        /// <summary>
        /// Returns true if Matter instances are equal
        /// </summary>
        /// <param name="other">Instance of Matter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Matter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.CaseId == other.CaseId ||
                    this.CaseId != null &&
                    this.CaseId.Equals(other.CaseId)
                ) && 
                (
                    this.ClientMatterNumber == other.ClientMatterNumber ||
                    this.ClientMatterNumber != null &&
                    this.ClientMatterNumber.Equals(other.ClientMatterNumber)
                ) && 
                (
                    this.Judge == other.Judge ||
                    this.Judge != null &&
                    this.Judge.Equals(other.Judge)
                ) && 
                (
                    this.CaseNumber == other.CaseNumber ||
                    this.CaseNumber != null &&
                    this.CaseNumber.Equals(other.CaseNumber)
                ) && 
                (
                    this.CaseTitle == other.CaseTitle ||
                    this.CaseTitle != null &&
                    this.CaseTitle.Equals(other.CaseTitle)
                ) && 
                (
                    this.NatureOfSuit == other.NatureOfSuit ||
                    this.NatureOfSuit != null &&
                    this.NatureOfSuit.Equals(other.NatureOfSuit)
                ) && 
                (
                    this.DocketEntries == other.DocketEntries ||
                    this.DocketEntries != null &&
                    this.DocketEntries.Equals(other.DocketEntries)
                ) && 
                (
                    this.ActivityAt == other.ActivityAt ||
                    this.ActivityAt != null &&
                    this.ActivityAt.Equals(other.ActivityAt)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.CaseId != null)
                    hash = hash * 59 + this.CaseId.GetHashCode();
                if (this.ClientMatterNumber != null)
                    hash = hash * 59 + this.ClientMatterNumber.GetHashCode();
                if (this.Judge != null)
                    hash = hash * 59 + this.Judge.GetHashCode();
                if (this.CaseNumber != null)
                    hash = hash * 59 + this.CaseNumber.GetHashCode();
                if (this.CaseTitle != null)
                    hash = hash * 59 + this.CaseTitle.GetHashCode();
                if (this.NatureOfSuit != null)
                    hash = hash * 59 + this.NatureOfSuit.GetHashCode();
                if (this.DocketEntries != null)
                    hash = hash * 59 + this.DocketEntries.GetHashCode();
                if (this.ActivityAt != null)
                    hash = hash * 59 + this.ActivityAt.GetHashCode();
                return hash;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            // NOTE: property changed is handled via "code weaving" using Fody.
            // Properties with setters are modified at compile time to notify of changes.
            var propertyChanged = PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
