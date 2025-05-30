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
    /// ReputationItemProjection
    /// </summary>
    [DataContract(Name = "ReputationItemProjection")]
    public partial class ReputationItemProjection : IValidatableObject
    {
        /// <summary>
        /// Defines ReputationType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReputationTypeEnum
        {
            /// <summary>
            /// Enum COMPLAINT for value: COMPLAINT
            /// </summary>
            [EnumMember(Value = "COMPLAINT")]
            COMPLAINT = 1,

            /// <summary>
            /// Enum BOUNCE for value: BOUNCE
            /// </summary>
            [EnumMember(Value = "BOUNCE")]
            BOUNCE = 2
        }


        /// <summary>
        /// Gets or Sets ReputationType
        /// </summary>
        [DataMember(Name = "reputationType", IsRequired = true, EmitDefaultValue = true)]
        public ReputationTypeEnum ReputationType { get; set; }
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
            /// Enum WARNING for value: WARNING
            /// </summary>
            [EnumMember(Value = "WARNING")]
            WARNING = 2,

            /// <summary>
            /// Enum DANGER for value: DANGER
            /// </summary>
            [EnumMember(Value = "DANGER")]
            DANGER = 3
        }


        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name = "severity", IsRequired = true, EmitDefaultValue = true)]
        public SeverityEnum Severity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReputationItemProjection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReputationItemProjection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReputationItemProjection" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="recipient">recipient.</param>
        /// <param name="reputationType">reputationType (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="severity">severity (required).</param>
        /// <param name="source">source.</param>
        public ReputationItemProjection(DateTime createdAt = default, string recipient = default, ReputationTypeEnum reputationType = default, Guid id = default, SeverityEnum severity = default, string source = default)
        {
            this.CreatedAt = createdAt;
            this.ReputationType = reputationType;
            this.Id = id;
            this.Severity = severity;
            this.Recipient = recipient;
            this.Source = source;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        [DataMember(Name = "recipient", EmitDefaultValue = false)]
        public string Recipient { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReputationItemProjection {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  ReputationType: ").Append(ReputationType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
