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
    /// Tracking pixel
    /// </summary>
    [DataContract(Name = "TrackingPixelDto")]
    public partial class TrackingPixelDto : IEquatable<TrackingPixelDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingPixelDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrackingPixelDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackingPixelDto" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="seen">seen (required).</param>
        /// <param name="recipient">recipient.</param>
        /// <param name="html">html (required).</param>
        /// <param name="url">url (required).</param>
        /// <param name="inboxId">inboxId.</param>
        /// <param name="sentEmailId">sentEmailId.</param>
        /// <param name="seenAt">seenAt.</param>
        /// <param name="createdAt">createdAt (required).</param>
        public TrackingPixelDto(Guid id = default(Guid), bool seen = default(bool), string recipient = default(string), string html = default(string), string url = default(string), Guid? inboxId = default(Guid?), Guid? sentEmailId = default(Guid?), DateTime? seenAt = default(DateTime?), DateTime createdAt = default(DateTime))
        {
            this.Id = id;
            this.Seen = seen;
            // to ensure "html" is required (not null)
            if (html == null)
            {
                throw new ArgumentNullException("html is a required property for TrackingPixelDto and cannot be null");
            }
            this.Html = html;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for TrackingPixelDto and cannot be null");
            }
            this.Url = url;
            this.CreatedAt = createdAt;
            this.Recipient = recipient;
            this.InboxId = inboxId;
            this.SentEmailId = sentEmailId;
            this.SeenAt = seenAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Seen
        /// </summary>
        [DataMember(Name = "seen", IsRequired = true, EmitDefaultValue = true)]
        public bool Seen { get; set; }

        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        [DataMember(Name = "recipient", EmitDefaultValue = true)]
        public string Recipient { get; set; }

        /// <summary>
        /// Gets or Sets Html
        /// </summary>
        [DataMember(Name = "html", IsRequired = true, EmitDefaultValue = true)]
        public string Html { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets InboxId
        /// </summary>
        [DataMember(Name = "inboxId", EmitDefaultValue = true)]
        public Guid? InboxId { get; set; }

        /// <summary>
        /// Gets or Sets SentEmailId
        /// </summary>
        [DataMember(Name = "sentEmailId", EmitDefaultValue = true)]
        public Guid? SentEmailId { get; set; }

        /// <summary>
        /// Gets or Sets SeenAt
        /// </summary>
        [DataMember(Name = "seenAt", EmitDefaultValue = true)]
        public DateTime? SeenAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackingPixelDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Seen: ").Append(Seen).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  SentEmailId: ").Append(SentEmailId).Append("\n");
            sb.Append("  SeenAt: ").Append(SeenAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as TrackingPixelDto);
        }

        /// <summary>
        /// Returns true if TrackingPixelDto instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackingPixelDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingPixelDto input)
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
                    this.Seen == input.Seen ||
                    this.Seen.Equals(input.Seen)
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.Html == input.Html ||
                    (this.Html != null &&
                    this.Html.Equals(input.Html))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
                ) && 
                (
                    this.SentEmailId == input.SentEmailId ||
                    (this.SentEmailId != null &&
                    this.SentEmailId.Equals(input.SentEmailId))
                ) && 
                (
                    this.SeenAt == input.SeenAt ||
                    (this.SeenAt != null &&
                    this.SeenAt.Equals(input.SeenAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                hashCode = (hashCode * 59) + this.Seen.GetHashCode();
                if (this.Recipient != null)
                {
                    hashCode = (hashCode * 59) + this.Recipient.GetHashCode();
                }
                if (this.Html != null)
                {
                    hashCode = (hashCode * 59) + this.Html.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.InboxId != null)
                {
                    hashCode = (hashCode * 59) + this.InboxId.GetHashCode();
                }
                if (this.SentEmailId != null)
                {
                    hashCode = (hashCode * 59) + this.SentEmailId.GetHashCode();
                }
                if (this.SeenAt != null)
                {
                    hashCode = (hashCode * 59) + this.SeenAt.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
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
