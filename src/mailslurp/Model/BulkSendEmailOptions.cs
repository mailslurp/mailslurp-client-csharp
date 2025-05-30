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
    /// Options for bulk sending an email from multiple addresses. See regular &#x60;sendEmail&#x60; methods for more information.
    /// </summary>
    [DataContract(Name = "BulkSendEmailOptions")]
    public partial class BulkSendEmailOptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSendEmailOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkSendEmailOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSendEmailOptions" /> class.
        /// </summary>
        /// <param name="inboxIds">Inboxes to send the email from (required).</param>
        /// <param name="sendEmailOptions">sendEmailOptions (required).</param>
        public BulkSendEmailOptions(List<Guid> inboxIds = default, SendEmailOptions sendEmailOptions = default)
        {
            // to ensure "inboxIds" is required (not null)
            if (inboxIds == null)
            {
                throw new ArgumentNullException("inboxIds is a required property for BulkSendEmailOptions and cannot be null");
            }
            this.InboxIds = inboxIds;
            // to ensure "sendEmailOptions" is required (not null)
            if (sendEmailOptions == null)
            {
                throw new ArgumentNullException("sendEmailOptions is a required property for BulkSendEmailOptions and cannot be null");
            }
            this.SendEmailOptions = sendEmailOptions;
        }

        /// <summary>
        /// Inboxes to send the email from
        /// </summary>
        /// <value>Inboxes to send the email from</value>
        [DataMember(Name = "inboxIds", IsRequired = true, EmitDefaultValue = true)]
        public List<Guid> InboxIds { get; set; }

        /// <summary>
        /// Gets or Sets SendEmailOptions
        /// </summary>
        [DataMember(Name = "sendEmailOptions", IsRequired = true, EmitDefaultValue = true)]
        public SendEmailOptions SendEmailOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BulkSendEmailOptions {\n");
            sb.Append("  InboxIds: ").Append(InboxIds).Append("\n");
            sb.Append("  SendEmailOptions: ").Append(SendEmailOptions).Append("\n");
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
