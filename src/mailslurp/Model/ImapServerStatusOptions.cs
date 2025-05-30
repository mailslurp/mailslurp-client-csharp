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
    /// ImapServerStatusOptions
    /// </summary>
    [DataContract(Name = "ImapServerStatusOptions")]
    public partial class ImapServerStatusOptions : IValidatableObject
    {
        /// <summary>
        /// Defines StatusItems
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusItemsEnum
        {
            /// <summary>
            /// Enum MESSAGES for value: MESSAGES
            /// </summary>
            [EnumMember(Value = "MESSAGES")]
            MESSAGES = 1,

            /// <summary>
            /// Enum RECENT for value: RECENT
            /// </summary>
            [EnumMember(Value = "RECENT")]
            RECENT = 2,

            /// <summary>
            /// Enum UIDNEXT for value: UIDNEXT
            /// </summary>
            [EnumMember(Value = "UIDNEXT")]
            UIDNEXT = 3,

            /// <summary>
            /// Enum UIDVALIDITY for value: UIDVALIDITY
            /// </summary>
            [EnumMember(Value = "UIDVALIDITY")]
            UIDVALIDITY = 4,

            /// <summary>
            /// Enum UNSEEN for value: UNSEEN
            /// </summary>
            [EnumMember(Value = "UNSEEN")]
            UNSEEN = 5,

            /// <summary>
            /// Enum APPENDLIMIT for value: APPENDLIMIT
            /// </summary>
            [EnumMember(Value = "APPENDLIMIT")]
            APPENDLIMIT = 6
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImapServerStatusOptions" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="statusItems">statusItems.</param>
        public ImapServerStatusOptions(string name = default, List<StatusItemsEnum> statusItems = default)
        {
            this.Name = name;
            this.StatusItems = statusItems;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets StatusItems
        /// </summary>
        [DataMember(Name = "statusItems", EmitDefaultValue = true)]
        public List<ImapServerStatusOptions.StatusItemsEnum> StatusItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImapServerStatusOptions {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StatusItems: ").Append(StatusItems).Append("\n");
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
