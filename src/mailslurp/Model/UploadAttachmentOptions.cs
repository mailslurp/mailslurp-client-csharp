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
    /// Options for uploading files for attachments. When sending emails with the API that require attachments first upload each attachment. Then use the returned attachment ID in your &#x60;SendEmailOptions&#x60; when sending an email. This way you can use attachments multiple times once they have been uploaded.
    /// </summary>
    [DataContract(Name = "UploadAttachmentOptions")]
    public partial class UploadAttachmentOptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAttachmentOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UploadAttachmentOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadAttachmentOptions" /> class.
        /// </summary>
        /// <param name="contentId">Optional contentId for file..</param>
        /// <param name="contentType">Optional contentType for file. For instance &#x60;application/pdf&#x60;.</param>
        /// <param name="filename">Optional filename to save upload with. Will be the name that is shown in email clients.</param>
        /// <param name="base64Contents">Base64 encoded string of file contents. Typically this means reading the bytes or string content of a file and then converting that to a base64 encoded string. For examples of how to do this see https://www.mailslurp.com/guides/base64-file-uploads/ (required).</param>
        public UploadAttachmentOptions(string contentId = default, string contentType = default, string filename = default, string base64Contents = default)
        {
            // to ensure "base64Contents" is required (not null)
            if (base64Contents == null)
            {
                throw new ArgumentNullException("base64Contents is a required property for UploadAttachmentOptions and cannot be null");
            }
            this.Base64Contents = base64Contents;
            this.ContentId = contentId;
            this.ContentType = contentType;
            this.Filename = filename;
        }

        /// <summary>
        /// Optional contentId for file.
        /// </summary>
        /// <value>Optional contentId for file.</value>
        [DataMember(Name = "contentId", EmitDefaultValue = true)]
        public string ContentId { get; set; }

        /// <summary>
        /// Optional contentType for file. For instance &#x60;application/pdf&#x60;
        /// </summary>
        /// <value>Optional contentType for file. For instance &#x60;application/pdf&#x60;</value>
        [DataMember(Name = "contentType", EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Optional filename to save upload with. Will be the name that is shown in email clients
        /// </summary>
        /// <value>Optional filename to save upload with. Will be the name that is shown in email clients</value>
        [DataMember(Name = "filename", EmitDefaultValue = true)]
        public string Filename { get; set; }

        /// <summary>
        /// Base64 encoded string of file contents. Typically this means reading the bytes or string content of a file and then converting that to a base64 encoded string. For examples of how to do this see https://www.mailslurp.com/guides/base64-file-uploads/
        /// </summary>
        /// <value>Base64 encoded string of file contents. Typically this means reading the bytes or string content of a file and then converting that to a base64 encoded string. For examples of how to do this see https://www.mailslurp.com/guides/base64-file-uploads/</value>
        [DataMember(Name = "base64Contents", IsRequired = true, EmitDefaultValue = true)]
        public string Base64Contents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UploadAttachmentOptions {\n");
            sb.Append("  ContentId: ").Append(ContentId).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  Base64Contents: ").Append(Base64Contents).Append("\n");
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
