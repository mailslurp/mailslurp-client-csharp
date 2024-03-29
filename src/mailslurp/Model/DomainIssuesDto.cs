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
    /// DomainIssuesDto
    /// </summary>
    [DataContract(Name = "DomainIssuesDto")]
    public partial class DomainIssuesDto : IEquatable<DomainIssuesDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainIssuesDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DomainIssuesDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainIssuesDto" /> class.
        /// </summary>
        /// <param name="hasIssues">hasIssues (required).</param>
        public DomainIssuesDto(bool hasIssues = default(bool))
        {
            this.HasIssues = hasIssues;
        }

        /// <summary>
        /// Gets or Sets HasIssues
        /// </summary>
        [DataMember(Name = "hasIssues", IsRequired = true, EmitDefaultValue = true)]
        public bool HasIssues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DomainIssuesDto {\n");
            sb.Append("  HasIssues: ").Append(HasIssues).Append("\n");
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
            return this.Equals(input as DomainIssuesDto);
        }

        /// <summary>
        /// Returns true if DomainIssuesDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainIssuesDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainIssuesDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HasIssues == input.HasIssues ||
                    this.HasIssues.Equals(input.HasIssues)
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
                hashCode = (hashCode * 59) + this.HasIssues.GetHashCode();
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
