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
    /// Email body content parts for multipart mime message. Will override body.
    /// </summary>
    [DataContract(Name = "SendEmailBodyPart")]
    public partial class SendEmailBodyPart : IEquatable<SendEmailBodyPart>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmailBodyPart" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendEmailBodyPart() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmailBodyPart" /> class.
        /// </summary>
        /// <param name="contentType">contentType (required).</param>
        /// <param name="contentBody">contentBody (required).</param>
        public SendEmailBodyPart(string contentType = default(string), string contentBody = default(string))
        {
            // to ensure "contentType" is required (not null)
            if (contentType == null)
            {
                throw new ArgumentNullException("contentType is a required property for SendEmailBodyPart and cannot be null");
            }
            this.ContentType = contentType;
            // to ensure "contentBody" is required (not null)
            if (contentBody == null)
            {
                throw new ArgumentNullException("contentBody is a required property for SendEmailBodyPart and cannot be null");
            }
            this.ContentBody = contentBody;
        }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name = "contentType", IsRequired = true, EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or Sets ContentBody
        /// </summary>
        [DataMember(Name = "contentBody", IsRequired = true, EmitDefaultValue = true)]
        public string ContentBody { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SendEmailBodyPart {\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  ContentBody: ").Append(ContentBody).Append("\n");
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
            return this.Equals(input as SendEmailBodyPart);
        }

        /// <summary>
        /// Returns true if SendEmailBodyPart instances are equal
        /// </summary>
        /// <param name="input">Instance of SendEmailBodyPart to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendEmailBodyPart input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.ContentBody == input.ContentBody ||
                    (this.ContentBody != null &&
                    this.ContentBody.Equals(input.ContentBody))
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
                if (this.ContentType != null)
                {
                    hashCode = (hashCode * 59) + this.ContentType.GetHashCode();
                }
                if (this.ContentBody != null)
                {
                    hashCode = (hashCode * 59) + this.ContentBody.GetHashCode();
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