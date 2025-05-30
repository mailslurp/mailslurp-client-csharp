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
    /// Missed email
    /// </summary>
    [DataContract(Name = "MissedEmailDto")]
    public partial class MissedEmailDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissedEmailDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MissedEmailDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MissedEmailDto" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="userId">userId.</param>
        /// <param name="subject">subject.</param>
        /// <param name="bodyExcerpt">bodyExcerpt.</param>
        /// <param name="attachmentCount">attachmentCount (required).</param>
        /// <param name="from">from.</param>
        /// <param name="rawUrl">rawUrl.</param>
        /// <param name="rawKey">rawKey.</param>
        /// <param name="rawBucket">rawBucket.</param>
        /// <param name="canRestore">canRestore.</param>
        /// <param name="to">to (required).</param>
        /// <param name="cc">cc (required).</param>
        /// <param name="bcc">bcc (required).</param>
        /// <param name="inboxIds">inboxIds (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        public MissedEmailDto(Guid id = default, Guid? userId = default, string subject = default, string bodyExcerpt = default, int attachmentCount = default, string from = default, string rawUrl = default, string rawKey = default, string rawBucket = default, bool? canRestore = default, List<string> to = default, List<string> cc = default, List<string> bcc = default, List<Guid> inboxIds = default, DateTime createdAt = default, DateTime updatedAt = default)
        {
            this.Id = id;
            this.AttachmentCount = attachmentCount;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for MissedEmailDto and cannot be null");
            }
            this.To = to;
            // to ensure "cc" is required (not null)
            if (cc == null)
            {
                throw new ArgumentNullException("cc is a required property for MissedEmailDto and cannot be null");
            }
            this.Cc = cc;
            // to ensure "bcc" is required (not null)
            if (bcc == null)
            {
                throw new ArgumentNullException("bcc is a required property for MissedEmailDto and cannot be null");
            }
            this.Bcc = bcc;
            // to ensure "inboxIds" is required (not null)
            if (inboxIds == null)
            {
                throw new ArgumentNullException("inboxIds is a required property for MissedEmailDto and cannot be null");
            }
            this.InboxIds = inboxIds;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.UserId = userId;
            this.Subject = subject;
            this.BodyExcerpt = bodyExcerpt;
            this.From = from;
            this.RawUrl = rawUrl;
            this.RawKey = rawKey;
            this.RawBucket = rawBucket;
            this.CanRestore = canRestore;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets BodyExcerpt
        /// </summary>
        [DataMember(Name = "bodyExcerpt", EmitDefaultValue = true)]
        public string BodyExcerpt { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentCount
        /// </summary>
        [DataMember(Name = "attachmentCount", IsRequired = true, EmitDefaultValue = true)]
        public int AttachmentCount { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "from", EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets RawUrl
        /// </summary>
        [DataMember(Name = "rawUrl", EmitDefaultValue = true)]
        public string RawUrl { get; set; }

        /// <summary>
        /// Gets or Sets RawKey
        /// </summary>
        [DataMember(Name = "rawKey", EmitDefaultValue = true)]
        public string RawKey { get; set; }

        /// <summary>
        /// Gets or Sets RawBucket
        /// </summary>
        [DataMember(Name = "rawBucket", EmitDefaultValue = true)]
        public string RawBucket { get; set; }

        /// <summary>
        /// Gets or Sets CanRestore
        /// </summary>
        [DataMember(Name = "canRestore", EmitDefaultValue = true)]
        public bool? CanRestore { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public List<string> To { get; set; }

        /// <summary>
        /// Gets or Sets Cc
        /// </summary>
        [DataMember(Name = "cc", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Cc { get; set; }

        /// <summary>
        /// Gets or Sets Bcc
        /// </summary>
        [DataMember(Name = "bcc", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Bcc { get; set; }

        /// <summary>
        /// Gets or Sets InboxIds
        /// </summary>
        [DataMember(Name = "inboxIds", IsRequired = true, EmitDefaultValue = true)]
        public List<Guid> InboxIds { get; set; }

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
            sb.Append("class MissedEmailDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  BodyExcerpt: ").Append(BodyExcerpt).Append("\n");
            sb.Append("  AttachmentCount: ").Append(AttachmentCount).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  RawUrl: ").Append(RawUrl).Append("\n");
            sb.Append("  RawKey: ").Append(RawKey).Append("\n");
            sb.Append("  RawBucket: ").Append(RawBucket).Append("\n");
            sb.Append("  CanRestore: ").Append(CanRestore).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  InboxIds: ").Append(InboxIds).Append("\n");
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
