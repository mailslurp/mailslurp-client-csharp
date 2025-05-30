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
    /// EmailScreenshotResult
    /// </summary>
    [DataContract(Name = "EmailScreenshotResult")]
    public partial class EmailScreenshotResult : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailScreenshotResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailScreenshotResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailScreenshotResult" /> class.
        /// </summary>
        /// <param name="base64EncodedImage">base64EncodedImage (required).</param>
        public EmailScreenshotResult(string base64EncodedImage = default)
        {
            // to ensure "base64EncodedImage" is required (not null)
            if (base64EncodedImage == null)
            {
                throw new ArgumentNullException("base64EncodedImage is a required property for EmailScreenshotResult and cannot be null");
            }
            this.Base64EncodedImage = base64EncodedImage;
        }

        /// <summary>
        /// Gets or Sets Base64EncodedImage
        /// </summary>
        [DataMember(Name = "base64EncodedImage", IsRequired = true, EmitDefaultValue = true)]
        public string Base64EncodedImage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailScreenshotResult {\n");
            sb.Append("  Base64EncodedImage: ").Append(Base64EncodedImage).Append("\n");
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
