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
    /// Options for the email envelope
    /// </summary>
    [DataContract(Name = "SendSMTPEnvelopeOptions")]
    public partial class SendSMTPEnvelopeOptions : IValidatableObject
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
        public SendSMTPEnvelopeOptions(List<string> rcptTo = default, string mailFrom = default, string data = default)
        {
            // to ensure "rcptTo" is required (not null)
            if (rcptTo == null)
            {
                throw new ArgumentNullException("rcptTo is a required property for SendSMTPEnvelopeOptions and cannot be null");
            }
            this.RcptTo = rcptTo;
            // to ensure "mailFrom" is required (not null)
            if (mailFrom == null)
            {
                throw new ArgumentNullException("mailFrom is a required property for SendSMTPEnvelopeOptions and cannot be null");
            }
            this.MailFrom = mailFrom;
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for SendSMTPEnvelopeOptions and cannot be null");
            }
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets RcptTo
        /// </summary>
        [DataMember(Name = "rcptTo", IsRequired = true, EmitDefaultValue = true)]
        public List<string> RcptTo { get; set; }

        /// <summary>
        /// Gets or Sets MailFrom
        /// </summary>
        [DataMember(Name = "mailFrom", IsRequired = true, EmitDefaultValue = true)]
        public string MailFrom { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
