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
    /// Options for exporting user data
    /// </summary>
    [DataContract(Name = "ExportOptions")]
    public partial class ExportOptions : IValidatableObject
    {
        /// <summary>
        /// Defines OutputFormat
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OutputFormatEnum
        {
            /// <summary>
            /// Enum CSVDEFAULT for value: CSV_DEFAULT
            /// </summary>
            [EnumMember(Value = "CSV_DEFAULT")]
            CSVDEFAULT = 1,

            /// <summary>
            /// Enum CSVEXCEL for value: CSV_EXCEL
            /// </summary>
            [EnumMember(Value = "CSV_EXCEL")]
            CSVEXCEL = 2
        }


        /// <summary>
        /// Gets or Sets OutputFormat
        /// </summary>
        [DataMember(Name = "outputFormat", IsRequired = true, EmitDefaultValue = true)]
        public OutputFormatEnum OutputFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExportOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportOptions" /> class.
        /// </summary>
        /// <param name="outputFormat">outputFormat (required).</param>
        /// <param name="excludePreviouslyExported">excludePreviouslyExported.</param>
        /// <param name="createdEarliestTime">createdEarliestTime.</param>
        /// <param name="createdOldestTime">createdOldestTime.</param>
        /// <param name="filter">filter.</param>
        /// <param name="listSeparatorToken">listSeparatorToken.</param>
        public ExportOptions(OutputFormatEnum outputFormat = default, bool? excludePreviouslyExported = default, DateTime? createdEarliestTime = default, DateTime? createdOldestTime = default, string filter = default, string listSeparatorToken = default)
        {
            this.OutputFormat = outputFormat;
            this.ExcludePreviouslyExported = excludePreviouslyExported;
            this.CreatedEarliestTime = createdEarliestTime;
            this.CreatedOldestTime = createdOldestTime;
            this.Filter = filter;
            this.ListSeparatorToken = listSeparatorToken;
        }

        /// <summary>
        /// Gets or Sets ExcludePreviouslyExported
        /// </summary>
        [DataMember(Name = "excludePreviouslyExported", EmitDefaultValue = true)]
        public bool? ExcludePreviouslyExported { get; set; }

        /// <summary>
        /// Gets or Sets CreatedEarliestTime
        /// </summary>
        [DataMember(Name = "createdEarliestTime", EmitDefaultValue = true)]
        public DateTime? CreatedEarliestTime { get; set; }

        /// <summary>
        /// Gets or Sets CreatedOldestTime
        /// </summary>
        [DataMember(Name = "createdOldestTime", EmitDefaultValue = true)]
        public DateTime? CreatedOldestTime { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = true)]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or Sets ListSeparatorToken
        /// </summary>
        [DataMember(Name = "listSeparatorToken", EmitDefaultValue = true)]
        public string ListSeparatorToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExportOptions {\n");
            sb.Append("  OutputFormat: ").Append(OutputFormat).Append("\n");
            sb.Append("  ExcludePreviouslyExported: ").Append(ExcludePreviouslyExported).Append("\n");
            sb.Append("  CreatedEarliestTime: ").Append(CreatedEarliestTime).Append("\n");
            sb.Append("  CreatedOldestTime: ").Append(CreatedOldestTime).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  ListSeparatorToken: ").Append(ListSeparatorToken).Append("\n");
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
