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
    /// EntityEventItemProjection
    /// </summary>
    [DataContract(Name = "EntityEventItemProjection")]
    public partial class EntityEventItemProjection : IValidatableObject
    {
        /// <summary>
        /// Defines EventType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventTypeEnum
        {
            /// <summary>
            /// Enum WEBHOOKEVENT for value: WEBHOOK_EVENT
            /// </summary>
            [EnumMember(Value = "WEBHOOK_EVENT")]
            WEBHOOKEVENT = 1,

            /// <summary>
            /// Enum INBOXFORWARDEREVENT for value: INBOX_FORWARDER_EVENT
            /// </summary>
            [EnumMember(Value = "INBOX_FORWARDER_EVENT")]
            INBOXFORWARDEREVENT = 2,

            /// <summary>
            /// Enum INBOXREPLIEREVENT for value: INBOX_REPLIER_EVENT
            /// </summary>
            [EnumMember(Value = "INBOX_REPLIER_EVENT")]
            INBOXREPLIEREVENT = 3,

            /// <summary>
            /// Enum INBOXRULESETEVENT for value: INBOX_RULESET_EVENT
            /// </summary>
            [EnumMember(Value = "INBOX_RULESET_EVENT")]
            INBOXRULESETEVENT = 4,

            /// <summary>
            /// Enum ALIASEVENT for value: ALIAS_EVENT
            /// </summary>
            [EnumMember(Value = "ALIAS_EVENT")]
            ALIASEVENT = 5
        }


        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "eventType", IsRequired = true, EmitDefaultValue = true)]
        public EventTypeEnum EventType { get; set; }
        /// <summary>
        /// Defines Severity
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SeverityEnum
        {
            /// <summary>
            /// Enum INFO for value: INFO
            /// </summary>
            [EnumMember(Value = "INFO")]
            INFO = 1,

            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 2,

            /// <summary>
            /// Enum WARNING for value: WARNING
            /// </summary>
            [EnumMember(Value = "WARNING")]
            WARNING = 3,

            /// <summary>
            /// Enum DANGER for value: DANGER
            /// </summary>
            [EnumMember(Value = "DANGER")]
            DANGER = 4
        }


        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name = "severity", IsRequired = true, EmitDefaultValue = true)]
        public SeverityEnum Severity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityEventItemProjection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EntityEventItemProjection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityEventItemProjection" /> class.
        /// </summary>
        /// <param name="eventType">eventType (required).</param>
        /// <param name="inboxId">inboxId.</param>
        /// <param name="phoneId">phoneId.</param>
        /// <param name="id">id (required).</param>
        /// <param name="severity">severity (required).</param>
        public EntityEventItemProjection(EventTypeEnum eventType = default, Guid inboxId = default, Guid phoneId = default, Guid id = default, SeverityEnum severity = default)
        {
            this.EventType = eventType;
            this.Id = id;
            this.Severity = severity;
            this.InboxId = inboxId;
            this.PhoneId = phoneId;
        }

        /// <summary>
        /// Gets or Sets InboxId
        /// </summary>
        [DataMember(Name = "inboxId", EmitDefaultValue = false)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Gets or Sets PhoneId
        /// </summary>
        [DataMember(Name = "phoneId", EmitDefaultValue = false)]
        public Guid PhoneId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EntityEventItemProjection {\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  PhoneId: ").Append(PhoneId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
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
