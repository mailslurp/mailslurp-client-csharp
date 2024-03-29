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
    /// Optional filter for matching emails based on fields. For instance filter results to only include emails whose &#x60;SUBJECT&#x60; value does &#x60;CONTAIN&#x60; given match value. An example payload would be &#x60;{ matches: [{ field: &#39;SUBJECT&#39;, should: &#39;CONTAIN&#39;, value: &#39;Welcome&#39; }] }&#x60;. You can also pass conditions such as &#x60;HAS_ATTACHMENT&#x60;. If you wish to extract regex matches inside the email content see the &#x60;getEmailContentMatch&#x60; method in the EmailController.
    /// </summary>
    [DataContract(Name = "MatchOptions")]
    public partial class MatchOptions : IEquatable<MatchOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MatchOptions" /> class.
        /// </summary>
        /// <param name="matches">Zero or more match options such as &#x60;{ field: &#39;SUBJECT&#39;, should: &#39;CONTAIN&#39;, value: &#39;Welcome&#39; }&#x60;. Options are additive so if one does not match the email is excluded from results.</param>
        /// <param name="conditions">Zero or more conditions such as &#x60;{ condition: &#39;HAS_ATTACHMENTS&#39;, value: &#39;TRUE&#39; }&#x60;. Note the values are the strings &#x60;TRUE|FALSE&#x60; not booleans..</param>
        public MatchOptions(List<MatchOption> matches = default(List<MatchOption>), List<ConditionOption> conditions = default(List<ConditionOption>))
        {
            this.Matches = matches;
            this.Conditions = conditions;
        }

        /// <summary>
        /// Zero or more match options such as &#x60;{ field: &#39;SUBJECT&#39;, should: &#39;CONTAIN&#39;, value: &#39;Welcome&#39; }&#x60;. Options are additive so if one does not match the email is excluded from results
        /// </summary>
        /// <value>Zero or more match options such as &#x60;{ field: &#39;SUBJECT&#39;, should: &#39;CONTAIN&#39;, value: &#39;Welcome&#39; }&#x60;. Options are additive so if one does not match the email is excluded from results</value>
        [DataMember(Name = "matches", EmitDefaultValue = true)]
        public List<MatchOption> Matches { get; set; }

        /// <summary>
        /// Zero or more conditions such as &#x60;{ condition: &#39;HAS_ATTACHMENTS&#39;, value: &#39;TRUE&#39; }&#x60;. Note the values are the strings &#x60;TRUE|FALSE&#x60; not booleans.
        /// </summary>
        /// <value>Zero or more conditions such as &#x60;{ condition: &#39;HAS_ATTACHMENTS&#39;, value: &#39;TRUE&#39; }&#x60;. Note the values are the strings &#x60;TRUE|FALSE&#x60; not booleans.</value>
        [DataMember(Name = "conditions", EmitDefaultValue = true)]
        public List<ConditionOption> Conditions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MatchOptions {\n");
            sb.Append("  Matches: ").Append(Matches).Append("\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
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
            return this.Equals(input as MatchOptions);
        }

        /// <summary>
        /// Returns true if MatchOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of MatchOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MatchOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Matches == input.Matches ||
                    this.Matches != null &&
                    input.Matches != null &&
                    this.Matches.SequenceEqual(input.Matches)
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    input.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
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
                if (this.Matches != null)
                {
                    hashCode = (hashCode * 59) + this.Matches.GetHashCode();
                }
                if (this.Conditions != null)
                {
                    hashCode = (hashCode * 59) + this.Conditions.GetHashCode();
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
