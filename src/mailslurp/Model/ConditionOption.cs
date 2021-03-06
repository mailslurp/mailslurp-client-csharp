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
    /// Options for matching emails in an inbox based on a condition such as &#x60;HAS_ATTACHMENTS&#x3D;TRUE&#x60;
    /// </summary>
    [DataContract]
    public partial class ConditionOption :  IEquatable<ConditionOption>, IValidatableObject
    {
        /// <summary>
        /// The condition to evaluate against the email
        /// </summary>
        /// <value>The condition to evaluate against the email</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConditionEnum
        {
            /// <summary>
            /// Enum HASATTACHMENTS for value: HAS_ATTACHMENTS
            /// </summary>
            [EnumMember(Value = "HAS_ATTACHMENTS")]
            HASATTACHMENTS = 1

        }

        /// <summary>
        /// The condition to evaluate against the email
        /// </summary>
        /// <value>The condition to evaluate against the email</value>
        [DataMember(Name="condition", EmitDefaultValue=false)]
        public ConditionEnum? Condition { get; set; }
        /// <summary>
        /// What the condition should evaluate to. A string &#39;TRUE|FALSE&#39; not a boolean.
        /// </summary>
        /// <value>What the condition should evaluate to. A string &#39;TRUE|FALSE&#39; not a boolean.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ValueEnum
        {
            /// <summary>
            /// Enum TRUE for value: TRUE
            /// </summary>
            [EnumMember(Value = "TRUE")]
            TRUE = 1,

            /// <summary>
            /// Enum FALSE for value: FALSE
            /// </summary>
            [EnumMember(Value = "FALSE")]
            FALSE = 2

        }

        /// <summary>
        /// What the condition should evaluate to. A string &#39;TRUE|FALSE&#39; not a boolean.
        /// </summary>
        /// <value>What the condition should evaluate to. A string &#39;TRUE|FALSE&#39; not a boolean.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public ValueEnum? Value { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionOption" /> class.
        /// </summary>
        /// <param name="condition">The condition to evaluate against the email.</param>
        /// <param name="value">What the condition should evaluate to. A string &#39;TRUE|FALSE&#39; not a boolean..</param>
        public ConditionOption(ConditionEnum? condition = default(ConditionEnum?), ValueEnum? value = default(ValueEnum?))
        {
            this.Condition = condition;
            this.Value = value;
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConditionOption {\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as ConditionOption);
        }

        /// <summary>
        /// Returns true if ConditionOption instances are equal
        /// </summary>
        /// <param name="input">Instance of ConditionOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConditionOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Condition == input.Condition ||
                    this.Condition.Equals(input.Condition)
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
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
                hashCode = hashCode * 59 + this.Condition.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
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
