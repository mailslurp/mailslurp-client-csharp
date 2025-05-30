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
    /// ConnectorImapConnectionDto
    /// </summary>
    [DataContract(Name = "ConnectorImapConnectionDto")]
    public partial class ConnectorImapConnectionDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorImapConnectionDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectorImapConnectionDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorImapConnectionDto" /> class.
        /// </summary>
        /// <param name="connectorId">connectorId (required).</param>
        /// <param name="imapHost">imapHost (required).</param>
        /// <param name="imapPort">imapPort.</param>
        /// <param name="imapUsername">imapUsername.</param>
        /// <param name="imapPassword">imapPassword.</param>
        /// <param name="imapSsl">imapSsl.</param>
        /// <param name="selectFolder">selectFolder.</param>
        /// <param name="searchTerms">searchTerms.</param>
        /// <param name="startTls">startTls.</param>
        /// <param name="proxyHost">proxyHost.</param>
        /// <param name="proxyPort">proxyPort.</param>
        /// <param name="proxyEnabled">proxyEnabled.</param>
        /// <param name="localHostName">localHostName.</param>
        /// <param name="mechanisms">mechanisms.</param>
        /// <param name="sslProtocols">sslProtocols.</param>
        /// <param name="sslTrust">sslTrust.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="id">id (required).</param>
        public ConnectorImapConnectionDto(Guid connectorId = default, string imapHost = default, int imapPort = default, string imapUsername = default, string imapPassword = default, bool imapSsl = default, string selectFolder = default, string searchTerms = default, bool startTls = default, string proxyHost = default, int proxyPort = default, bool proxyEnabled = default, string localHostName = default, List<string> mechanisms = default, List<string> sslProtocols = default, string sslTrust = default, bool enabled = default, DateTime createdAt = default, Guid id = default)
        {
            this.ConnectorId = connectorId;
            // to ensure "imapHost" is required (not null)
            if (imapHost == null)
            {
                throw new ArgumentNullException("imapHost is a required property for ConnectorImapConnectionDto and cannot be null");
            }
            this.ImapHost = imapHost;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.ImapPort = imapPort;
            this.ImapUsername = imapUsername;
            this.ImapPassword = imapPassword;
            this.ImapSsl = imapSsl;
            this.SelectFolder = selectFolder;
            this.SearchTerms = searchTerms;
            this.StartTls = startTls;
            this.ProxyHost = proxyHost;
            this.ProxyPort = proxyPort;
            this.ProxyEnabled = proxyEnabled;
            this.LocalHostName = localHostName;
            this.Mechanisms = mechanisms;
            this.SslProtocols = sslProtocols;
            this.SslTrust = sslTrust;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Gets or Sets ConnectorId
        /// </summary>
        [DataMember(Name = "connectorId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ConnectorId { get; set; }

        /// <summary>
        /// Gets or Sets ImapHost
        /// </summary>
        [DataMember(Name = "imapHost", IsRequired = true, EmitDefaultValue = true)]
        public string ImapHost { get; set; }

        /// <summary>
        /// Gets or Sets ImapPort
        /// </summary>
        [DataMember(Name = "imapPort", EmitDefaultValue = false)]
        public int ImapPort { get; set; }

        /// <summary>
        /// Gets or Sets ImapUsername
        /// </summary>
        [DataMember(Name = "imapUsername", EmitDefaultValue = false)]
        public string ImapUsername { get; set; }

        /// <summary>
        /// Gets or Sets ImapPassword
        /// </summary>
        [DataMember(Name = "imapPassword", EmitDefaultValue = false)]
        public string ImapPassword { get; set; }

        /// <summary>
        /// Gets or Sets ImapSsl
        /// </summary>
        [DataMember(Name = "imapSsl", EmitDefaultValue = true)]
        public bool ImapSsl { get; set; }

        /// <summary>
        /// Gets or Sets SelectFolder
        /// </summary>
        [DataMember(Name = "selectFolder", EmitDefaultValue = false)]
        public string SelectFolder { get; set; }

        /// <summary>
        /// Gets or Sets SearchTerms
        /// </summary>
        [DataMember(Name = "searchTerms", EmitDefaultValue = false)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// Gets or Sets StartTls
        /// </summary>
        [DataMember(Name = "startTls", EmitDefaultValue = true)]
        public bool StartTls { get; set; }

        /// <summary>
        /// Gets or Sets ProxyHost
        /// </summary>
        [DataMember(Name = "proxyHost", EmitDefaultValue = false)]
        public string ProxyHost { get; set; }

        /// <summary>
        /// Gets or Sets ProxyPort
        /// </summary>
        [DataMember(Name = "proxyPort", EmitDefaultValue = false)]
        public int ProxyPort { get; set; }

        /// <summary>
        /// Gets or Sets ProxyEnabled
        /// </summary>
        [DataMember(Name = "proxyEnabled", EmitDefaultValue = true)]
        public bool ProxyEnabled { get; set; }

        /// <summary>
        /// Gets or Sets LocalHostName
        /// </summary>
        [DataMember(Name = "localHostName", EmitDefaultValue = false)]
        public string LocalHostName { get; set; }

        /// <summary>
        /// Gets or Sets Mechanisms
        /// </summary>
        [DataMember(Name = "mechanisms", EmitDefaultValue = false)]
        public List<string> Mechanisms { get; set; }

        /// <summary>
        /// Gets or Sets SslProtocols
        /// </summary>
        [DataMember(Name = "sslProtocols", EmitDefaultValue = false)]
        public List<string> SslProtocols { get; set; }

        /// <summary>
        /// Gets or Sets SslTrust
        /// </summary>
        [DataMember(Name = "sslTrust", EmitDefaultValue = false)]
        public string SslTrust { get; set; }

        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

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
            sb.Append("class ConnectorImapConnectionDto {\n");
            sb.Append("  ConnectorId: ").Append(ConnectorId).Append("\n");
            sb.Append("  ImapHost: ").Append(ImapHost).Append("\n");
            sb.Append("  ImapPort: ").Append(ImapPort).Append("\n");
            sb.Append("  ImapUsername: ").Append(ImapUsername).Append("\n");
            sb.Append("  ImapPassword: ").Append(ImapPassword).Append("\n");
            sb.Append("  ImapSsl: ").Append(ImapSsl).Append("\n");
            sb.Append("  SelectFolder: ").Append(SelectFolder).Append("\n");
            sb.Append("  SearchTerms: ").Append(SearchTerms).Append("\n");
            sb.Append("  StartTls: ").Append(StartTls).Append("\n");
            sb.Append("  ProxyHost: ").Append(ProxyHost).Append("\n");
            sb.Append("  ProxyPort: ").Append(ProxyPort).Append("\n");
            sb.Append("  ProxyEnabled: ").Append(ProxyEnabled).Append("\n");
            sb.Append("  LocalHostName: ").Append(LocalHostName).Append("\n");
            sb.Append("  Mechanisms: ").Append(Mechanisms).Append("\n");
            sb.Append("  SslProtocols: ").Append(SslProtocols).Append("\n");
            sb.Append("  SslTrust: ").Append(SslTrust).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
