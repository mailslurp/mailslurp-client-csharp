/* 
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.   ## Resources - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://www.mailslurp.com/docs/) - [Examples](https://github.com/mailslurp/examples) repository 
 *
 * The version of the OpenAPI document: 6.5.2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = mailslurp.Client.OpenAPIDateConverter;

namespace mailslurp.Model
{
    /// <summary>
    /// IP Address look up result for a given domain / hostname
    /// </summary>
    [DataContract]
    public partial class IPAddressResult :  IEquatable<IPAddressResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IPAddressResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IPAddressResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IPAddressResult" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="hostname">hostname (required).</param>
        public IPAddressResult(string address = default(string), string hostname = default(string))
        {
            // to ensure "address" is required (not null)
            this.Address = address ?? throw new ArgumentNullException("address is a required property for IPAddressResult and cannot be null");
            // to ensure "hostname" is required (not null)
            this.Hostname = hostname ?? throw new ArgumentNullException("hostname is a required property for IPAddressResult and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Hostname
        /// </summary>
        [DataMember(Name="hostname", EmitDefaultValue=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IPAddressResult {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Hostname: ").Append(Hostname).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IPAddressResult);
        }

        /// <summary>
        /// Returns true if IPAddressResult instances are equal
        /// </summary>
        /// <param name="input">Instance of IPAddressResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IPAddressResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Hostname == input.Hostname ||
                    (this.Hostname != null &&
                    this.Hostname.Equals(input.Hostname))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Hostname != null)
                    hashCode = hashCode * 59 + this.Hostname.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}