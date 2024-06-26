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
    /// Missed email
    /// </summary>
    [DataContract(Name = "MissedEmailDto")]
    public partial class MissedEmailDto : IEquatable<MissedEmailDto>, IValidatableObject
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
        public MissedEmailDto(Guid id = default(Guid), Guid? userId = default(Guid?), string subject = default(string), string bodyExcerpt = default(string), int attachmentCount = default(int), string from = default(string), string rawUrl = default(string), string rawKey = default(string), string rawBucket = default(string), bool? canRestore = default(bool?), List<string> to = default(List<string>), List<string> cc = default(List<string>), List<string> bcc = default(List<string>), List<Guid> inboxIds = default(List<Guid>), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MissedEmailDto);
        }

        /// <summary>
        /// Returns true if MissedEmailDto instances are equal
        /// </summary>
        /// <param name="input">Instance of MissedEmailDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MissedEmailDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.BodyExcerpt == input.BodyExcerpt ||
                    (this.BodyExcerpt != null &&
                    this.BodyExcerpt.Equals(input.BodyExcerpt))
                ) && 
                (
                    this.AttachmentCount == input.AttachmentCount ||
                    this.AttachmentCount.Equals(input.AttachmentCount)
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.RawUrl == input.RawUrl ||
                    (this.RawUrl != null &&
                    this.RawUrl.Equals(input.RawUrl))
                ) && 
                (
                    this.RawKey == input.RawKey ||
                    (this.RawKey != null &&
                    this.RawKey.Equals(input.RawKey))
                ) && 
                (
                    this.RawBucket == input.RawBucket ||
                    (this.RawBucket != null &&
                    this.RawBucket.Equals(input.RawBucket))
                ) && 
                (
                    this.CanRestore == input.CanRestore ||
                    (this.CanRestore != null &&
                    this.CanRestore.Equals(input.CanRestore))
                ) && 
                (
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.Cc == input.Cc ||
                    this.Cc != null &&
                    input.Cc != null &&
                    this.Cc.SequenceEqual(input.Cc)
                ) && 
                (
                    this.Bcc == input.Bcc ||
                    this.Bcc != null &&
                    input.Bcc != null &&
                    this.Bcc.SequenceEqual(input.Bcc)
                ) && 
                (
                    this.InboxIds == input.InboxIds ||
                    this.InboxIds != null &&
                    input.InboxIds != null &&
                    this.InboxIds.SequenceEqual(input.InboxIds)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.BodyExcerpt != null)
                {
                    hashCode = (hashCode * 59) + this.BodyExcerpt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AttachmentCount.GetHashCode();
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.RawUrl != null)
                {
                    hashCode = (hashCode * 59) + this.RawUrl.GetHashCode();
                }
                if (this.RawKey != null)
                {
                    hashCode = (hashCode * 59) + this.RawKey.GetHashCode();
                }
                if (this.RawBucket != null)
                {
                    hashCode = (hashCode * 59) + this.RawBucket.GetHashCode();
                }
                if (this.CanRestore != null)
                {
                    hashCode = (hashCode * 59) + this.CanRestore.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.Cc != null)
                {
                    hashCode = (hashCode * 59) + this.Cc.GetHashCode();
                }
                if (this.Bcc != null)
                {
                    hashCode = (hashCode * 59) + this.Bcc.GetHashCode();
                }
                if (this.InboxIds != null)
                {
                    hashCode = (hashCode * 59) + this.InboxIds.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
