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
    /// IMAP and SMTP server endpoints for MailSlurp
    /// </summary>
    [DataContract(Name = "ImapSmtpAccessServers")]
    public partial class ImapSmtpAccessServers : IEquatable<ImapSmtpAccessServers>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImapSmtpAccessServers" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImapSmtpAccessServers() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImapSmtpAccessServers" /> class.
        /// </summary>
        /// <param name="imapServer">imapServer (required).</param>
        /// <param name="secureImapServer">secureImapServer (required).</param>
        /// <param name="smtpServer">smtpServer (required).</param>
        /// <param name="secureSmtpServer">secureSmtpServer (required).</param>
        public ImapSmtpAccessServers(ServerEndpoints imapServer = default(ServerEndpoints), ServerEndpoints secureImapServer = default(ServerEndpoints), ServerEndpoints smtpServer = default(ServerEndpoints), ServerEndpoints secureSmtpServer = default(ServerEndpoints))
        {
            // to ensure "imapServer" is required (not null)
            if (imapServer == null)
            {
                throw new ArgumentNullException("imapServer is a required property for ImapSmtpAccessServers and cannot be null");
            }
            this.ImapServer = imapServer;
            // to ensure "secureImapServer" is required (not null)
            if (secureImapServer == null)
            {
                throw new ArgumentNullException("secureImapServer is a required property for ImapSmtpAccessServers and cannot be null");
            }
            this.SecureImapServer = secureImapServer;
            // to ensure "smtpServer" is required (not null)
            if (smtpServer == null)
            {
                throw new ArgumentNullException("smtpServer is a required property for ImapSmtpAccessServers and cannot be null");
            }
            this.SmtpServer = smtpServer;
            // to ensure "secureSmtpServer" is required (not null)
            if (secureSmtpServer == null)
            {
                throw new ArgumentNullException("secureSmtpServer is a required property for ImapSmtpAccessServers and cannot be null");
            }
            this.SecureSmtpServer = secureSmtpServer;
        }

        /// <summary>
        /// Gets or Sets ImapServer
        /// </summary>
        [DataMember(Name = "imapServer", IsRequired = true, EmitDefaultValue = true)]
        public ServerEndpoints ImapServer { get; set; }

        /// <summary>
        /// Gets or Sets SecureImapServer
        /// </summary>
        [DataMember(Name = "secureImapServer", IsRequired = true, EmitDefaultValue = true)]
        public ServerEndpoints SecureImapServer { get; set; }

        /// <summary>
        /// Gets or Sets SmtpServer
        /// </summary>
        [DataMember(Name = "smtpServer", IsRequired = true, EmitDefaultValue = true)]
        public ServerEndpoints SmtpServer { get; set; }

        /// <summary>
        /// Gets or Sets SecureSmtpServer
        /// </summary>
        [DataMember(Name = "secureSmtpServer", IsRequired = true, EmitDefaultValue = true)]
        public ServerEndpoints SecureSmtpServer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImapSmtpAccessServers {\n");
            sb.Append("  ImapServer: ").Append(ImapServer).Append("\n");
            sb.Append("  SecureImapServer: ").Append(SecureImapServer).Append("\n");
            sb.Append("  SmtpServer: ").Append(SmtpServer).Append("\n");
            sb.Append("  SecureSmtpServer: ").Append(SecureSmtpServer).Append("\n");
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
            return this.Equals(input as ImapSmtpAccessServers);
        }

        /// <summary>
        /// Returns true if ImapSmtpAccessServers instances are equal
        /// </summary>
        /// <param name="input">Instance of ImapSmtpAccessServers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImapSmtpAccessServers input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ImapServer == input.ImapServer ||
                    (this.ImapServer != null &&
                    this.ImapServer.Equals(input.ImapServer))
                ) && 
                (
                    this.SecureImapServer == input.SecureImapServer ||
                    (this.SecureImapServer != null &&
                    this.SecureImapServer.Equals(input.SecureImapServer))
                ) && 
                (
                    this.SmtpServer == input.SmtpServer ||
                    (this.SmtpServer != null &&
                    this.SmtpServer.Equals(input.SmtpServer))
                ) && 
                (
                    this.SecureSmtpServer == input.SecureSmtpServer ||
                    (this.SecureSmtpServer != null &&
                    this.SecureSmtpServer.Equals(input.SecureSmtpServer))
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
                if (this.ImapServer != null)
                {
                    hashCode = (hashCode * 59) + this.ImapServer.GetHashCode();
                }
                if (this.SecureImapServer != null)
                {
                    hashCode = (hashCode * 59) + this.SecureImapServer.GetHashCode();
                }
                if (this.SmtpServer != null)
                {
                    hashCode = (hashCode * 59) + this.SmtpServer.GetHashCode();
                }
                if (this.SecureSmtpServer != null)
                {
                    hashCode = (hashCode * 59) + this.SecureSmtpServer.GetHashCode();
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