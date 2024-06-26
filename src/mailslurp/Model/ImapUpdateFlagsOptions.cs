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
    /// ImapUpdateFlagsOptions
    /// </summary>
    [DataContract(Name = "ImapUpdateFlagsOptions")]
    public partial class ImapUpdateFlagsOptions : IEquatable<ImapUpdateFlagsOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImapUpdateFlagsOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImapUpdateFlagsOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImapUpdateFlagsOptions" /> class.
        /// </summary>
        /// <param name="operation">operation (required).</param>
        /// <param name="flags">flags.</param>
        /// <param name="uidSet">uidSet.</param>
        /// <param name="seqSet">seqSet.</param>
        public ImapUpdateFlagsOptions(string operation = default(string), List<string> flags = default(List<string>), string uidSet = default(string), string seqSet = default(string))
        {
            // to ensure "operation" is required (not null)
            if (operation == null)
            {
                throw new ArgumentNullException("operation is a required property for ImapUpdateFlagsOptions and cannot be null");
            }
            this.Operation = operation;
            this.Flags = flags;
            this.UidSet = uidSet;
            this.SeqSet = seqSet;
        }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name = "operation", IsRequired = true, EmitDefaultValue = true)]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or Sets Flags
        /// </summary>
        [DataMember(Name = "flags", EmitDefaultValue = true)]
        public List<string> Flags { get; set; }

        /// <summary>
        /// Gets or Sets UidSet
        /// </summary>
        [DataMember(Name = "uidSet", EmitDefaultValue = true)]
        public string UidSet { get; set; }

        /// <summary>
        /// Gets or Sets SeqSet
        /// </summary>
        [DataMember(Name = "seqSet", EmitDefaultValue = true)]
        public string SeqSet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImapUpdateFlagsOptions {\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Flags: ").Append(Flags).Append("\n");
            sb.Append("  UidSet: ").Append(UidSet).Append("\n");
            sb.Append("  SeqSet: ").Append(SeqSet).Append("\n");
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
            return this.Equals(input as ImapUpdateFlagsOptions);
        }

        /// <summary>
        /// Returns true if ImapUpdateFlagsOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of ImapUpdateFlagsOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImapUpdateFlagsOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.Flags == input.Flags ||
                    this.Flags != null &&
                    input.Flags != null &&
                    this.Flags.SequenceEqual(input.Flags)
                ) && 
                (
                    this.UidSet == input.UidSet ||
                    (this.UidSet != null &&
                    this.UidSet.Equals(input.UidSet))
                ) && 
                (
                    this.SeqSet == input.SeqSet ||
                    (this.SeqSet != null &&
                    this.SeqSet.Equals(input.SeqSet))
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
                if (this.Operation != null)
                {
                    hashCode = (hashCode * 59) + this.Operation.GetHashCode();
                }
                if (this.Flags != null)
                {
                    hashCode = (hashCode * 59) + this.Flags.GetHashCode();
                }
                if (this.UidSet != null)
                {
                    hashCode = (hashCode * 59) + this.UidSet.GetHashCode();
                }
                if (this.SeqSet != null)
                {
                    hashCode = (hashCode * 59) + this.SeqSet.GetHashCode();
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
