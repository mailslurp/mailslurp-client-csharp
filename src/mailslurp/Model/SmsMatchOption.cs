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
    /// Options for matching SMS messages in a phone number. Each match option object contains a &#x60;field&#x60;, &#x60;should&#x60; and &#x60;value&#x60; property. Together they form logical conditions such as &#x60;BODY&#x60; should &#x60;CONTAIN&#x60; value.
    /// </summary>
    [DataContract(Name = "SmsMatchOption")]
    public partial class SmsMatchOption : IEquatable<SmsMatchOption>, IValidatableObject
    {
        /// <summary>
        /// Fields of an SMS object that can be used to filter results
        /// </summary>
        /// <value>Fields of an SMS object that can be used to filter results</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldEnum
        {
            /// <summary>
            /// Enum BODY for value: BODY
            /// </summary>
            [EnumMember(Value = "BODY")]
            BODY = 1,

            /// <summary>
            /// Enum FROM for value: FROM
            /// </summary>
            [EnumMember(Value = "FROM")]
            FROM = 2

        }


        /// <summary>
        /// Fields of an SMS object that can be used to filter results
        /// </summary>
        /// <value>Fields of an SMS object that can be used to filter results</value>
        [DataMember(Name = "field", IsRequired = true, EmitDefaultValue = false)]
        public FieldEnum Field { get; set; }
        /// <summary>
        /// How the value of the email field specified should be compared to the value given in the match options.
        /// </summary>
        /// <value>How the value of the email field specified should be compared to the value given in the match options.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ShouldEnum
        {
            /// <summary>
            /// Enum CONTAIN for value: CONTAIN
            /// </summary>
            [EnumMember(Value = "CONTAIN")]
            CONTAIN = 1,

            /// <summary>
            /// Enum EQUAL for value: EQUAL
            /// </summary>
            [EnumMember(Value = "EQUAL")]
            EQUAL = 2

        }


        /// <summary>
        /// How the value of the email field specified should be compared to the value given in the match options.
        /// </summary>
        /// <value>How the value of the email field specified should be compared to the value given in the match options.</value>
        [DataMember(Name = "should", IsRequired = true, EmitDefaultValue = false)]
        public ShouldEnum Should { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsMatchOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmsMatchOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsMatchOption" /> class.
        /// </summary>
        /// <param name="field">Fields of an SMS object that can be used to filter results (required).</param>
        /// <param name="should">How the value of the email field specified should be compared to the value given in the match options. (required).</param>
        /// <param name="value">The value you wish to compare with the value of the field specified using the &#x60;should&#x60; value passed. For example &#x60;BODY&#x60; should &#x60;CONTAIN&#x60; a value passed. (required).</param>
        public SmsMatchOption(FieldEnum field = default(FieldEnum), ShouldEnum should = default(ShouldEnum), string value = default(string))
        {
            this.Field = field;
            this.Should = should;
            // to ensure "value" is required (not null)
            this.Value = value ?? throw new ArgumentNullException("value is a required property for SmsMatchOption and cannot be null");
        }

        /// <summary>
        /// The value you wish to compare with the value of the field specified using the &#x60;should&#x60; value passed. For example &#x60;BODY&#x60; should &#x60;CONTAIN&#x60; a value passed.
        /// </summary>
        /// <value>The value you wish to compare with the value of the field specified using the &#x60;should&#x60; value passed. For example &#x60;BODY&#x60; should &#x60;CONTAIN&#x60; a value passed.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsMatchOption {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Should: ").Append(Should).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmsMatchOption);
        }

        /// <summary>
        /// Returns true if SmsMatchOption instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsMatchOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsMatchOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Field == input.Field ||
                    this.Field.Equals(input.Field)
                ) && 
                (
                    this.Should == input.Should ||
                    this.Should.Equals(input.Should)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                hashCode = hashCode * 59 + this.Field.GetHashCode();
                hashCode = hashCode * 59 + this.Should.GetHashCode();
                if (this.Value != null)
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