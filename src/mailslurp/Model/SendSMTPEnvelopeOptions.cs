/* 
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://www.mailslurp.com/docs/) - [Examples](https://github.com/mailslurp/examples) repository
 *
 * The version of the OpenAPI document: 6.5.2
 * Contact: contact@mailslurp.dev
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
    /// Options for the email envelope
    /// </summary>
    [DataContract]
    public partial class SendSMTPEnvelopeOptions :  IEquatable<SendSMTPEnvelopeOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendSMTPEnvelopeOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendSMTPEnvelopeOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendSMTPEnvelopeOptions" /> class.
        /// </summary>
        /// <param name="rcptTo">rcptTo (required).</param>
        /// <param name="mailFrom">mailFrom (required).</param>
        /// <param name="data">data (required).</param>
        public SendSMTPEnvelopeOptions(List<string> rcptTo = default(List<string>), string mailFrom = default(string), string data = default(string))
        {
            // to ensure "rcptTo" is required (not null)
            this.RcptTo = rcptTo ?? throw new ArgumentNullException("rcptTo is a required property for SendSMTPEnvelopeOptions and cannot be null");
            // to ensure "mailFrom" is required (not null)
            this.MailFrom = mailFrom ?? throw new ArgumentNullException("mailFrom is a required property for SendSMTPEnvelopeOptions and cannot be null");
            // to ensure "data" is required (not null)
            this.Data = data ?? throw new ArgumentNullException("data is a required property for SendSMTPEnvelopeOptions and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets RcptTo
        /// </summary>
        [DataMember(Name="rcptTo", EmitDefaultValue=false)]
        public List<string> RcptTo { get; set; }

        /// <summary>
        /// Gets or Sets MailFrom
        /// </summary>
        [DataMember(Name="mailFrom", EmitDefaultValue=false)]
        public string MailFrom { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendSMTPEnvelopeOptions {\n");
            sb.Append("  RcptTo: ").Append(RcptTo).Append("\n");
            sb.Append("  MailFrom: ").Append(MailFrom).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as SendSMTPEnvelopeOptions);
        }

        /// <summary>
        /// Returns true if SendSMTPEnvelopeOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of SendSMTPEnvelopeOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendSMTPEnvelopeOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RcptTo == input.RcptTo ||
                    this.RcptTo != null &&
                    input.RcptTo != null &&
                    this.RcptTo.SequenceEqual(input.RcptTo)
                ) && 
                (
                    this.MailFrom == input.MailFrom ||
                    (this.MailFrom != null &&
                    this.MailFrom.Equals(input.MailFrom))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.RcptTo != null)
                    hashCode = hashCode * 59 + this.RcptTo.GetHashCode();
                if (this.MailFrom != null)
                    hashCode = hashCode * 59 + this.MailFrom.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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