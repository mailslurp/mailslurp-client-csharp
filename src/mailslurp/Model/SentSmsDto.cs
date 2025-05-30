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
    /// SentSmsDto
    /// </summary>
    [DataContract(Name = "SentSmsDto")]
    public partial class SentSmsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SentSmsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SentSmsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SentSmsDto" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="phoneNumber">phoneNumber (required).</param>
        /// <param name="fromNumber">fromNumber (required).</param>
        /// <param name="toNumber">toNumber (required).</param>
        /// <param name="body">body (required).</param>
        /// <param name="sid">sid (required).</param>
        /// <param name="replyToSid">replyToSid.</param>
        /// <param name="replyToId">replyToId.</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        public SentSmsDto(Guid id = default, Guid userId = default, Guid phoneNumber = default, string fromNumber = default, string toNumber = default, string body = default, string sid = default, string replyToSid = default, Guid replyToId = default, DateTime createdAt = default, DateTime updatedAt = default)
        {
            this.Id = id;
            this.UserId = userId;
            this.PhoneNumber = phoneNumber;
            // to ensure "fromNumber" is required (not null)
            if (fromNumber == null)
            {
                throw new ArgumentNullException("fromNumber is a required property for SentSmsDto and cannot be null");
            }
            this.FromNumber = fromNumber;
            // to ensure "toNumber" is required (not null)
            if (toNumber == null)
            {
                throw new ArgumentNullException("toNumber is a required property for SentSmsDto and cannot be null");
            }
            this.ToNumber = toNumber;
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new ArgumentNullException("body is a required property for SentSmsDto and cannot be null");
            }
            this.Body = body;
            // to ensure "sid" is required (not null)
            if (sid == null)
            {
                throw new ArgumentNullException("sid is a required property for SentSmsDto and cannot be null");
            }
            this.Sid = sid;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ReplyToSid = replyToSid;
            this.ReplyToId = replyToId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name = "phoneNumber", IsRequired = true, EmitDefaultValue = true)]
        public Guid PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets FromNumber
        /// </summary>
        [DataMember(Name = "fromNumber", IsRequired = true, EmitDefaultValue = true)]
        public string FromNumber { get; set; }

        /// <summary>
        /// Gets or Sets ToNumber
        /// </summary>
        [DataMember(Name = "toNumber", IsRequired = true, EmitDefaultValue = true)]
        public string ToNumber { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", IsRequired = true, EmitDefaultValue = true)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets Sid
        /// </summary>
        [DataMember(Name = "sid", IsRequired = true, EmitDefaultValue = true)]
        public string Sid { get; set; }

        /// <summary>
        /// Gets or Sets ReplyToSid
        /// </summary>
        [DataMember(Name = "replyToSid", EmitDefaultValue = false)]
        public string ReplyToSid { get; set; }

        /// <summary>
        /// Gets or Sets ReplyToId
        /// </summary>
        [DataMember(Name = "replyToId", EmitDefaultValue = false)]
        public Guid ReplyToId { get; set; }

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
            sb.Append("class SentSmsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  FromNumber: ").Append(FromNumber).Append("\n");
            sb.Append("  ToNumber: ").Append(ToNumber).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Sid: ").Append(Sid).Append("\n");
            sb.Append("  ReplyToSid: ").Append(ReplyToSid).Append("\n");
            sb.Append("  ReplyToId: ").Append(ReplyToId).Append("\n");
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
