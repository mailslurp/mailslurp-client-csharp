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
    /// NEW_SMS webhook payload. Sent to your webhook url endpoint via HTTP POST when an sms is received by the phone number that your webhook is attached to. Use the SMS ID to fetch the full SMS details.
    /// </summary>
    [DataContract(Name = "WebhookNewSmsPayload")]
    public partial class WebhookNewSmsPayload : IEquatable<WebhookNewSmsPayload>, IValidatableObject
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
            EMAILOPENED = 5,

            /// <summary>
            /// Enum EMAILREAD for value: EMAIL_READ
            /// </summary>
            [EnumMember(Value = "EMAIL_READ")]
            EMAILREAD = 6,

            /// <summary>
            /// Enum DELIVERYSTATUS for value: DELIVERY_STATUS
            /// </summary>
            [EnumMember(Value = "DELIVERY_STATUS")]
            DELIVERYSTATUS = 7,

            /// <summary>
            /// Enum BOUNCE for value: BOUNCE
            /// </summary>
            [EnumMember(Value = "BOUNCE")]
            BOUNCE = 8,

            /// <summary>
            /// Enum BOUNCERECIPIENT for value: BOUNCE_RECIPIENT
            /// </summary>
            [EnumMember(Value = "BOUNCE_RECIPIENT")]
            BOUNCERECIPIENT = 9,

            /// <summary>
            /// Enum NEWSMS for value: NEW_SMS
            /// </summary>
            [EnumMember(Value = "NEW_SMS")]
            NEWSMS = 10

        }


        /// <summary>
        /// Name of the event type webhook is being triggered for.
        /// </summary>
        /// <value>Name of the event type webhook is being triggered for.</value>
        [DataMember(Name = "eventName", IsRequired = true, EmitDefaultValue = true)]
        public EventNameEnum EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookNewSmsPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookNewSmsPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookNewSmsPayload" /> class.
        /// </summary>
        /// <param name="messageId">Idempotent message ID. Store this ID locally or in a database to prevent message duplication. (required).</param>
        /// <param name="webhookId">ID of webhook entity being triggered (required).</param>
        /// <param name="eventName">Name of the event type webhook is being triggered for. (required).</param>
        /// <param name="webhookName">Name of the webhook being triggered.</param>
        /// <param name="smsId">ID of SMS message (required).</param>
        /// <param name="userId">User ID of event (required).</param>
        /// <param name="phoneNumber">ID of phone number receiving SMS (required).</param>
        /// <param name="toNumber">Recipient phone number (required).</param>
        /// <param name="fromNumber">Sender phone number (required).</param>
        /// <param name="body">SMS message body (required).</param>
        /// <param name="read">SMS has been read (required).</param>
        public WebhookNewSmsPayload(string messageId = default(string), Guid webhookId = default(Guid), EventNameEnum eventName = default(EventNameEnum), string webhookName = default(string), Guid smsId = default(Guid), Guid userId = default(Guid), Guid phoneNumber = default(Guid), string toNumber = default(string), string fromNumber = default(string), string body = default(string), bool read = default(bool))
        {
            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new ArgumentNullException("messageId is a required property for WebhookNewSmsPayload and cannot be null");
            }
            this.MessageId = messageId;
            this.WebhookId = webhookId;
            this.EventName = eventName;
            this.SmsId = smsId;
            this.UserId = userId;
            this.PhoneNumber = phoneNumber;
            // to ensure "toNumber" is required (not null)
            if (toNumber == null)
            {
                throw new ArgumentNullException("toNumber is a required property for WebhookNewSmsPayload and cannot be null");
            }
            this.ToNumber = toNumber;
            // to ensure "fromNumber" is required (not null)
            if (fromNumber == null)
            {
                throw new ArgumentNullException("fromNumber is a required property for WebhookNewSmsPayload and cannot be null");
            }
            this.FromNumber = fromNumber;
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new ArgumentNullException("body is a required property for WebhookNewSmsPayload and cannot be null");
            }
            this.Body = body;
            this.Read = read;
            this.WebhookName = webhookName;
        }

        /// <summary>
        /// Idempotent message ID. Store this ID locally or in a database to prevent message duplication.
        /// </summary>
        /// <value>Idempotent message ID. Store this ID locally or in a database to prevent message duplication.</value>
        [DataMember(Name = "messageId", IsRequired = true, EmitDefaultValue = true)]
        public string MessageId { get; set; }

        /// <summary>
        /// ID of webhook entity being triggered
        /// </summary>
        /// <value>ID of webhook entity being triggered</value>
        [DataMember(Name = "webhookId", IsRequired = true, EmitDefaultValue = true)]
        public Guid WebhookId { get; set; }

        /// <summary>
        /// Name of the webhook being triggered
        /// </summary>
        /// <value>Name of the webhook being triggered</value>
        [DataMember(Name = "webhookName", EmitDefaultValue = true)]
        public string WebhookName { get; set; }

        /// <summary>
        /// ID of SMS message
        /// </summary>
        /// <value>ID of SMS message</value>
        [DataMember(Name = "smsId", IsRequired = true, EmitDefaultValue = true)]
        public Guid SmsId { get; set; }

        /// <summary>
        /// User ID of event
        /// </summary>
        /// <value>User ID of event</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// ID of phone number receiving SMS
        /// </summary>
        /// <value>ID of phone number receiving SMS</value>
        [DataMember(Name = "phoneNumber", IsRequired = true, EmitDefaultValue = true)]
        public Guid PhoneNumber { get; set; }

        /// <summary>
        /// Recipient phone number
        /// </summary>
        /// <value>Recipient phone number</value>
        [DataMember(Name = "toNumber", IsRequired = true, EmitDefaultValue = true)]
        public string ToNumber { get; set; }

        /// <summary>
        /// Sender phone number
        /// </summary>
        /// <value>Sender phone number</value>
        [DataMember(Name = "fromNumber", IsRequired = true, EmitDefaultValue = true)]
        public string FromNumber { get; set; }

        /// <summary>
        /// SMS message body
        /// </summary>
        /// <value>SMS message body</value>
        [DataMember(Name = "body", IsRequired = true, EmitDefaultValue = true)]
        public string Body { get; set; }

        /// <summary>
        /// SMS has been read
        /// </summary>
        /// <value>SMS has been read</value>
        [DataMember(Name = "read", IsRequired = true, EmitDefaultValue = true)]
        public bool Read { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookNewSmsPayload {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  WebhookName: ").Append(WebhookName).Append("\n");
            sb.Append("  SmsId: ").Append(SmsId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  ToNumber: ").Append(ToNumber).Append("\n");
            sb.Append("  FromNumber: ").Append(FromNumber).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
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
            return this.Equals(input as WebhookNewSmsPayload);
        }

        /// <summary>
        /// Returns true if WebhookNewSmsPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookNewSmsPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookNewSmsPayload input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.WebhookId == input.WebhookId ||
                    (this.WebhookId != null &&
                    this.WebhookId.Equals(input.WebhookId))
                ) && 
                (
                    this.EventName == input.EventName ||
                    this.EventName.Equals(input.EventName)
                ) && 
                (
                    this.WebhookName == input.WebhookName ||
                    (this.WebhookName != null &&
                    this.WebhookName.Equals(input.WebhookName))
                ) && 
                (
                    this.SmsId == input.SmsId ||
                    (this.SmsId != null &&
                    this.SmsId.Equals(input.SmsId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.ToNumber == input.ToNumber ||
                    (this.ToNumber != null &&
                    this.ToNumber.Equals(input.ToNumber))
                ) && 
                (
                    this.FromNumber == input.FromNumber ||
                    (this.FromNumber != null &&
                    this.FromNumber.Equals(input.FromNumber))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Read == input.Read ||
                    this.Read.Equals(input.Read)
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
                if (this.MessageId != null)
                {
                    hashCode = (hashCode * 59) + this.MessageId.GetHashCode();
                }
                if (this.WebhookId != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EventName.GetHashCode();
                if (this.WebhookName != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookName.GetHashCode();
                }
                if (this.SmsId != null)
                {
                    hashCode = (hashCode * 59) + this.SmsId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                if (this.ToNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ToNumber.GetHashCode();
                }
                if (this.FromNumber != null)
                {
                    hashCode = (hashCode * 59) + this.FromNumber.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Read.GetHashCode();
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
