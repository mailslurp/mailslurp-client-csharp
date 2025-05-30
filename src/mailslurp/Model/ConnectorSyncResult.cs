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
    /// ConnectorSyncResult
    /// </summary>
    [DataContract(Name = "ConnectorSyncResult")]
    public partial class ConnectorSyncResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorSyncResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectorSyncResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorSyncResult" /> class.
        /// </summary>
        /// <param name="emailSyncCount">emailSyncCount (required).</param>
        /// <param name="logs">logs.</param>
        /// <param name="emailIds">emailIds.</param>
        public ConnectorSyncResult(int emailSyncCount = default, List<string> logs = default, List<Guid> emailIds = default)
        {
            this.EmailSyncCount = emailSyncCount;
            this.Logs = logs;
            this.EmailIds = emailIds;
        }

        /// <summary>
        /// Gets or Sets EmailSyncCount
        /// </summary>
        [DataMember(Name = "emailSyncCount", IsRequired = true, EmitDefaultValue = true)]
        public int EmailSyncCount { get; set; }

        /// <summary>
        /// Gets or Sets Logs
        /// </summary>
        [DataMember(Name = "logs", EmitDefaultValue = false)]
        public List<string> Logs { get; set; }

        /// <summary>
        /// Gets or Sets EmailIds
        /// </summary>
        [DataMember(Name = "emailIds", EmitDefaultValue = false)]
        public List<Guid> EmailIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectorSyncResult {\n");
            sb.Append("  EmailSyncCount: ").Append(EmailSyncCount).Append("\n");
            sb.Append("  Logs: ").Append(Logs).Append("\n");
            sb.Append("  EmailIds: ").Append(EmailIds).Append("\n");
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
