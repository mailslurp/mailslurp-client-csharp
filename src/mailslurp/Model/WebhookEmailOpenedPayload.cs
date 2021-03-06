/* 
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://www.mailslurp.com/docs/) - [Examples](https://github.com/mailslurp/examples) repository 
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
    /// EMAIL_OPENED webhook payload. Sent to your webhook url endpoint via HTTP POST when an email containing a tracking pixel is opened and the pixel image is loaded by a reader.
    /// </summary>
    [DataContract]
    public partial class WebhookEmailOpenedPayload :  IEquatable<WebhookEmailOpenedPayload>, IValidatableObject
    {
        /// <summary>
        /// Name of the event type webhook is being triggered for.
        /// </summary>
        /// <value>Name of the event type webhook is being triggered for.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventNameEnum
        {
            /// <summary>
            /// Enum EMAILRECEIVED for value: EMAIL_RECEIVED
            /// </summary>
            [EnumMember(Value = "EMAIL_RECEIVED")]
            EMAILRECEIVED = 1,

            /// <summary>
            /// Enum NEWEMAIL for value: NEW_EMAIL
            /// </summary>
            [EnumMember(Value = "NEW_EMAIL")]
            NEWEMAIL = 2,

            /// <summary>
            /// Enum NEWCONTACT for value: NEW_CONTACT
            /// </summary>
            [EnumMember(Value = "NEW_CONTACT")]
            NEWCONTACT = 3,

            /// <summary>
            /// Enum NEWATTACHMENT for value: NEW_ATTACHMENT
            /// </summary>
            [EnumMember(Value = "NEW_ATTACHMENT")]
            NEWATTACHMENT = 4,

            /// <summary>
            /// Enum EMAILOPENED for value: EMAIL_OPENED
            /// </summary>
            [EnumMember(Value = "EMAIL_OPENED")]
            EMAILOPENED = 5

        }

        /// <summary>
        /// Name of the event type webhook is being triggered for.
        /// </summary>
        /// <value>Name of the event type webhook is being triggered for.</value>
        [DataMember(Name="eventName", EmitDefaultValue=false)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEmailOpenedPayload" /> class.
        /// </summary>
        /// <param name="createdAt">Date time of event creation.</param>
        /// <param name="eventName">Name of the event type webhook is being triggered for..</param>
        /// <param name="inboxId">Id of the inbox that received an email.</param>
        /// <param name="messageId">Idempotent message ID. Store this ID locally or in a database to prevent message duplication..</param>
        /// <param name="pixelId">ID of the tracking pixel.</param>
        /// <param name="recipient">Email address for the recipient of the tracking pixel.</param>
        /// <param name="sentEmailId">ID of sent email.</param>
        /// <param name="webhookId">ID of webhook entity being triggered.</param>
        /// <param name="webhookName">Name of the webhook being triggered.</param>
        public WebhookEmailOpenedPayload(DateTime createdAt = default(DateTime), EventNameEnum? eventName = default(EventNameEnum?), Guid inboxId = default(Guid), string messageId = default(string), Guid pixelId = default(Guid), string recipient = default(string), Guid sentEmailId = default(Guid), Guid webhookId = default(Guid), string webhookName = default(string))
        {
            this.CreatedAt = createdAt;
            this.EventName = eventName;
            this.InboxId = inboxId;
            this.MessageId = messageId;
            this.PixelId = pixelId;
            this.Recipient = recipient;
            this.SentEmailId = sentEmailId;
            this.WebhookId = webhookId;
            this.WebhookName = webhookName;
        }
        
        /// <summary>
        /// Date time of event creation
        /// </summary>
        /// <value>Date time of event creation</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Id of the inbox that received an email
        /// </summary>
        /// <value>Id of the inbox that received an email</value>
        [DataMember(Name="inboxId", EmitDefaultValue=false)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Idempotent message ID. Store this ID locally or in a database to prevent message duplication.
        /// </summary>
        /// <value>Idempotent message ID. Store this ID locally or in a database to prevent message duplication.</value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// ID of the tracking pixel
        /// </summary>
        /// <value>ID of the tracking pixel</value>
        [DataMember(Name="pixelId", EmitDefaultValue=false)]
        public Guid PixelId { get; set; }

        /// <summary>
        /// Email address for the recipient of the tracking pixel
        /// </summary>
        /// <value>Email address for the recipient of the tracking pixel</value>
        [DataMember(Name="recipient", EmitDefaultValue=false)]
        public string Recipient { get; set; }

        /// <summary>
        /// ID of sent email
        /// </summary>
        /// <value>ID of sent email</value>
        [DataMember(Name="sentEmailId", EmitDefaultValue=false)]
        public Guid SentEmailId { get; set; }

        /// <summary>
        /// ID of webhook entity being triggered
        /// </summary>
        /// <value>ID of webhook entity being triggered</value>
        [DataMember(Name="webhookId", EmitDefaultValue=false)]
        public Guid WebhookId { get; set; }

        /// <summary>
        /// Name of the webhook being triggered
        /// </summary>
        /// <value>Name of the webhook being triggered</value>
        [DataMember(Name="webhookName", EmitDefaultValue=false)]
        public string WebhookName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookEmailOpenedPayload {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  PixelId: ").Append(PixelId).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  SentEmailId: ").Append(SentEmailId).Append("\n");
            sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
            sb.Append("  WebhookName: ").Append(WebhookName).Append("\n");
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
            return this.Equals(input as WebhookEmailOpenedPayload);
        }

        /// <summary>
        /// Returns true if WebhookEmailOpenedPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookEmailOpenedPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookEmailOpenedPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.EventName == input.EventName ||
                    this.EventName.Equals(input.EventName)
                ) && 
                (
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.PixelId == input.PixelId ||
                    (this.PixelId != null &&
                    this.PixelId.Equals(input.PixelId))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.SentEmailId == input.SentEmailId ||
                    (this.SentEmailId != null &&
                    this.SentEmailId.Equals(input.SentEmailId))
                ) && 
                (
                    this.WebhookId == input.WebhookId ||
                    (this.WebhookId != null &&
                    this.WebhookId.Equals(input.WebhookId))
                ) && 
                (
                    this.WebhookName == input.WebhookName ||
                    (this.WebhookName != null &&
                    this.WebhookName.Equals(input.WebhookName))
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
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.InboxId != null)
                    hashCode = hashCode * 59 + this.InboxId.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.PixelId != null)
                    hashCode = hashCode * 59 + this.PixelId.GetHashCode();
                if (this.Recipient != null)
                    hashCode = hashCode * 59 + this.Recipient.GetHashCode();
                if (this.SentEmailId != null)
                    hashCode = hashCode * 59 + this.SentEmailId.GetHashCode();
                if (this.WebhookId != null)
                    hashCode = hashCode * 59 + this.WebhookId.GetHashCode();
                if (this.WebhookName != null)
                    hashCode = hashCode * 59 + this.WebhookName.GetHashCode();
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
