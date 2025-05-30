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
    /// TestInboxRulesetSendingResult
    /// </summary>
    [DataContract(Name = "TestInboxRulesetSendingResult")]
    public partial class TestInboxRulesetSendingResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestInboxRulesetSendingResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestInboxRulesetSendingResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestInboxRulesetSendingResult" /> class.
        /// </summary>
        /// <param name="canSend">canSend (required).</param>
        public TestInboxRulesetSendingResult(bool canSend = default)
        {
            this.CanSend = canSend;
        }

        /// <summary>
        /// Gets or Sets CanSend
        /// </summary>
        [DataMember(Name = "canSend", IsRequired = true, EmitDefaultValue = true)]
        public bool CanSend { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestInboxRulesetSendingResult {\n");
            sb.Append("  CanSend: ").Append(CanSend).Append("\n");
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
