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
    /// Test options for inbox ruleset receiving test
    /// </summary>
    [DataContract(Name = "TestInboxRulesetReceivingOptions")]
    public partial class TestInboxRulesetReceivingOptions : IEquatable<TestInboxRulesetReceivingOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestInboxRulesetReceivingOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TestInboxRulesetReceivingOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TestInboxRulesetReceivingOptions" /> class.
        /// </summary>
        /// <param name="inboxId">inboxId (required).</param>
        /// <param name="fromSender">fromSender (required).</param>
        public TestInboxRulesetReceivingOptions(Guid inboxId = default(Guid), string fromSender = default(string))
        {
            this.InboxId = inboxId;
            // to ensure "fromSender" is required (not null)
            if (fromSender == null)
            {
                throw new ArgumentNullException("fromSender is a required property for TestInboxRulesetReceivingOptions and cannot be null");
            }
            this.FromSender = fromSender;
        }

        /// <summary>
        /// Gets or Sets InboxId
        /// </summary>
        [DataMember(Name = "inboxId", IsRequired = true, EmitDefaultValue = true)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Gets or Sets FromSender
        /// </summary>
        [DataMember(Name = "fromSender", IsRequired = true, EmitDefaultValue = true)]
        public string FromSender { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TestInboxRulesetReceivingOptions {\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  FromSender: ").Append(FromSender).Append("\n");
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
            return this.Equals(input as TestInboxRulesetReceivingOptions);
        }

        /// <summary>
        /// Returns true if TestInboxRulesetReceivingOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of TestInboxRulesetReceivingOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TestInboxRulesetReceivingOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
                ) && 
                (
                    this.FromSender == input.FromSender ||
                    (this.FromSender != null &&
                    this.FromSender.Equals(input.FromSender))
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
                if (this.InboxId != null)
                {
                    hashCode = (hashCode * 59) + this.InboxId.GetHashCode();
                }
                if (this.FromSender != null)
                {
                    hashCode = (hashCode * 59) + this.FromSender.GetHashCode();
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