/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://docs.mailslurp.com/) - [Examples](https://github.com/mailslurp/examples) repository
 *
 * The version of the OpenAPI document: 6.5.2
 * Contact: contact@mailslurp.dev
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = mailslurp.Client.OpenAPIDateConverter;

namespace mailslurp.Model
{
    /// <summary>
    /// Options for multiple DNS queries
    /// </summary>
    [DataContract(Name = "DNSLookupsOptions")]
    public partial class DNSLookupsOptions : IEquatable<DNSLookupsOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DNSLookupsOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DNSLookupsOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DNSLookupsOptions" /> class.
        /// </summary>
        /// <param name="lookups">lookups (required).</param>
        public DNSLookupsOptions(List<DNSLookupOptions> lookups = default(List<DNSLookupOptions>))
        {
            // to ensure "lookups" is required (not null)
            if (lookups == null)
            {
                throw new ArgumentNullException("lookups is a required property for DNSLookupsOptions and cannot be null");
            }
            this.Lookups = lookups;
        }

        /// <summary>
        /// Gets or Sets Lookups
        /// </summary>
        [DataMember(Name = "lookups", IsRequired = true, EmitDefaultValue = true)]
        public List<DNSLookupOptions> Lookups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DNSLookupsOptions {\n");
            sb.Append("  Lookups: ").Append(Lookups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DNSLookupsOptions);
        }

        /// <summary>
        /// Returns true if DNSLookupsOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of DNSLookupsOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DNSLookupsOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Lookups == input.Lookups ||
                    this.Lookups != null &&
                    input.Lookups != null &&
                    this.Lookups.SequenceEqual(input.Lookups)
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
                if (this.Lookups != null)
                {
                    hashCode = (hashCode * 59) + this.Lookups.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}