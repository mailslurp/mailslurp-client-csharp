/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails and SMS from dynamically allocated email addresses and phone numbers. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://docs.mailslurp.com/) - [Examples](https://github.com/mailslurp/examples) repository
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
    /// PlusAddressDto
    /// </summary>
    [DataContract(Name = "PlusAddressDto")]
    public partial class PlusAddressDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlusAddressDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlusAddressDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlusAddressDto" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="plusAddress">plusAddress (required).</param>
        /// <param name="fullAddress">fullAddress (required).</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="inboxId">inboxId (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        public PlusAddressDto(Guid id = default, string plusAddress = default, string fullAddress = default, Guid userId = default, Guid inboxId = default, DateTime createdAt = default, DateTime updatedAt = default)
        {
            this.Id = id;
            // to ensure "plusAddress" is required (not null)
            if (plusAddress == null)
            {
                throw new ArgumentNullException("plusAddress is a required property for PlusAddressDto and cannot be null");
            }
            this.PlusAddress = plusAddress;
            // to ensure "fullAddress" is required (not null)
            if (fullAddress == null)
            {
                throw new ArgumentNullException("fullAddress is a required property for PlusAddressDto and cannot be null");
            }
            this.FullAddress = fullAddress;
            this.UserId = userId;
            this.InboxId = inboxId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets PlusAddress
        /// </summary>
        [DataMember(Name = "plusAddress", IsRequired = true, EmitDefaultValue = true)]
        public string PlusAddress { get; set; }

        /// <summary>
        /// Gets or Sets FullAddress
        /// </summary>
        [DataMember(Name = "fullAddress", IsRequired = true, EmitDefaultValue = true)]
        public string FullAddress { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or Sets InboxId
        /// </summary>
        [DataMember(Name = "inboxId", IsRequired = true, EmitDefaultValue = true)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlusAddressDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PlusAddress: ").Append(PlusAddress).Append("\n");
            sb.Append("  FullAddress: ").Append(FullAddress).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
