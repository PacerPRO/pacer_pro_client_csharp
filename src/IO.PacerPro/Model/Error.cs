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
    /// Error
    /// </summary>
    [DataContract]
    [ImplementPropertyChanged]
    public partial class Error :  IEquatable<Error>, IValidatableObject
    {
        /// <summary>
        /// the type of error
        /// </summary>
        /// <value>the type of error</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Error for "error"
            /// </summary>
            [EnumMember(Value = "error")]
            Error,
            
            /// <summary>
            /// Enum Alert for "alert"
            /// </summary>
            [EnumMember(Value = "alert")]
            Alert,
            
            /// <summary>
            /// Enum Notice for "notice"
            /// </summary>
            [EnumMember(Value = "notice")]
            Notice,
            
            /// <summary>
            /// Enum Warning for "warning"
            /// </summary>
            [EnumMember(Value = "warning")]
            Warning
        }

        /// <summary>
        /// the type of error
        /// </summary>
        /// <value>the type of error</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="_Error">An error message.</param>
        /// <param name="Message">An error message (alias for &#x60;error&#x60;).</param>
        /// <param name="Status">HTTP status code.</param>
        /// <param name="Type">the type of error.</param>
        public Error(string _Error = null, string Message = null, int? Status = null, TypeEnum? Type = null)
        {
            this._Error = _Error;
            this.Message = Message;
            this.Status = Status;
            this.Type = Type;
        }
        
        /// <summary>
        /// An error message
        /// </summary>
        /// <value>An error message</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string _Error { get; set; }
        /// <summary>
        /// An error message (alias for &#x60;error&#x60;)
        /// </summary>
        /// <value>An error message (alias for &#x60;error&#x60;)</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// HTTP status code
        /// </summary>
        /// <value>HTTP status code</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  _Error: ").Append(_Error).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as Error);
        }

        /// <summary>
        /// Returns true if Error instances are equal
        /// </summary>
        /// <param name="other">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Error == other._Error ||
                    this._Error != null &&
                    this._Error.Equals(other._Error)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this._Error != null)
                    hash = hash * 59 + this._Error.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
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
