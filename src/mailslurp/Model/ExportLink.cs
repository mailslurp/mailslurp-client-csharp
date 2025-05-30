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
    /// Export download link
    /// </summary>
    [DataContract(Name = "ExportLink")]
    public partial class ExportLink : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExportLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportLink" /> class.
        /// </summary>
        /// <param name="downloadLink">downloadLink (required).</param>
        public ExportLink(string downloadLink = default)
        {
            // to ensure "downloadLink" is required (not null)
            if (downloadLink == null)
            {
                throw new ArgumentNullException("downloadLink is a required property for ExportLink and cannot be null");
            }
            this.DownloadLink = downloadLink;
        }

        /// <summary>
        /// Gets or Sets DownloadLink
        /// </summary>
        [DataMember(Name = "downloadLink", IsRequired = true, EmitDefaultValue = true)]
        public string DownloadLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExportLink {\n");
            sb.Append("  DownloadLink: ").Append(DownloadLink).Append("\n");
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
