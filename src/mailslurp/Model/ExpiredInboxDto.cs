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
    /// Expired inbox
    /// </summary>
    [DataContract]
    public partial class ExpiredInboxDto :  IEquatable<ExpiredInboxDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiredInboxDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExpiredInboxDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiredInboxDto" /> class.
        /// </summary>
        /// <param name="emailAddress">emailAddress (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="inboxId">inboxId (required).</param>
        public ExpiredInboxDto(string emailAddress = default(string), Guid id = default(Guid), Guid inboxId = default(Guid))
        {
            // to ensure "emailAddress" is required (not null)
            this.EmailAddress = emailAddress ?? throw new ArgumentNullException("emailAddress is a required property for ExpiredInboxDto and cannot be null");
            this.Id = id;
            this.InboxId = inboxId;
        }
        
        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets InboxId
        /// </summary>
        [DataMember(Name="inboxId", EmitDefaultValue=false)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpiredInboxDto {\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
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
            return this.Equals(input as ExpiredInboxDto);
        }

        /// <summary>
        /// Returns true if ExpiredInboxDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpiredInboxDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpiredInboxDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
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
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InboxId != null)
                    hashCode = hashCode * 59 + this.InboxId.GetHashCode();
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