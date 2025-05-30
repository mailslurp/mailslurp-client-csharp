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
    /// ImapEmailProjection
    /// </summary>
    [DataContract(Name = "ImapEmailProjection")]
    public partial class ImapEmailProjection : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImapEmailProjection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImapEmailProjection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImapEmailProjection" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="read">read.</param>
        /// <param name="uid">uid (required).</param>
        /// <param name="seqNum">seqNum (required).</param>
        /// <param name="id">id (required).</param>
        public ImapEmailProjection(DateTime createdAt = default, bool? read = default, long uid = default, long seqNum = default, Guid id = default)
        {
            this.CreatedAt = createdAt;
            this.Uid = uid;
            this.SeqNum = seqNum;
            this.Id = id;
            this.Read = read;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Read
        /// </summary>
        [DataMember(Name = "read", EmitDefaultValue = true)]
        public bool? Read { get; set; }

        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name = "uid", IsRequired = true, EmitDefaultValue = true)]
        public long Uid { get; set; }

        /// <summary>
        /// Gets or Sets SeqNum
        /// </summary>
        [DataMember(Name = "seqNum", IsRequired = true, EmitDefaultValue = true)]
        public long SeqNum { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImapEmailProjection {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  SeqNum: ").Append(SeqNum).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
