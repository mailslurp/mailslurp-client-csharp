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
    /// Sent email details
    /// </summary>
    [DataContract(Name = "SentEmailDto")]
    public partial class SentEmailDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SentEmailDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SentEmailDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SentEmailDto" /> class.
        /// </summary>
        /// <param name="id">ID of sent email (required).</param>
        /// <param name="userId">User ID (required).</param>
        /// <param name="inboxId">Inbox ID email was sent from (required).</param>
        /// <param name="domainId">Domain ID.</param>
        /// <param name="to">Recipients email was sent to.</param>
        /// <param name="from">Sent from address.</param>
        /// <param name="sender">sender.</param>
        /// <param name="recipients">recipients.</param>
        /// <param name="replyTo">replyTo.</param>
        /// <param name="cc">cc.</param>
        /// <param name="bcc">bcc.</param>
        /// <param name="attachments">Array of IDs of attachments that were sent with this email.</param>
        /// <param name="subject">subject.</param>
        /// <param name="bodyMD5Hash">MD5 Hash.</param>
        /// <param name="body">Sent email body.</param>
        /// <param name="toContacts">toContacts.</param>
        /// <param name="toGroup">toGroup.</param>
        /// <param name="charset">charset.</param>
        /// <param name="isHTML">isHTML.</param>
        /// <param name="sentAt">sentAt (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="pixelIds">pixelIds.</param>
        /// <param name="messageId">RFC 5322 Message-ID header value without angle brackets..</param>
        /// <param name="messageIds">messageIds.</param>
        /// <param name="virtualSend">virtualSend.</param>
        /// <param name="templateId">templateId.</param>
        /// <param name="templateVariables">templateVariables.</param>
        /// <param name="headers">headers.</param>
        /// <param name="threadId">MailSlurp thread ID for email chain that enables lookup for In-Reply-To and References fields..</param>
        /// <param name="bodyExcerpt">An excerpt of the body of the email message for quick preview. Takes HTML content part if exists falls back to TEXT content part if not.</param>
        /// <param name="textExcerpt">An excerpt of the body of the email message for quick preview. Takes TEXT content part if exists.</param>
        /// <param name="inReplyTo">Parsed value of In-Reply-To header. A Message-ID in a thread..</param>
        /// <param name="favourite">Is email favourited.</param>
        /// <param name="sizeBytes">Size of raw email message in bytes.</param>
        /// <param name="html">html.</param>
        public SentEmailDto(Guid id = default, Guid userId = default, Guid inboxId = default, Guid? domainId = default, List<string> to = default, string from = default, Sender sender = default, EmailRecipients recipients = default, string replyTo = default, List<string> cc = default, List<string> bcc = default, List<string> attachments = default, string subject = default, string bodyMD5Hash = default, string body = default, List<Guid?> toContacts = default, Guid? toGroup = default, string charset = default, bool? isHTML = default, DateTime sentAt = default, DateTime createdAt = default, List<Guid?> pixelIds = default, string messageId = default, List<string> messageIds = default, bool? virtualSend = default, Guid? templateId = default, Dictionary<string, Object> templateVariables = default, Dictionary<string, string> headers = default, Guid? threadId = default, string bodyExcerpt = default, string textExcerpt = default, string inReplyTo = default, bool? favourite = default, long? sizeBytes = default, bool html = default)
        {
            this.Id = id;
            this.UserId = userId;
            this.InboxId = inboxId;
            this.SentAt = sentAt;
            this.CreatedAt = createdAt;
            this.DomainId = domainId;
            this.To = to;
            this.From = from;
            this.Sender = sender;
            this.Recipients = recipients;
            this.ReplyTo = replyTo;
            this.Cc = cc;
            this.Bcc = bcc;
            this.Attachments = attachments;
            this.Subject = subject;
            this.BodyMD5Hash = bodyMD5Hash;
            this.Body = body;
            this.ToContacts = toContacts;
            this.ToGroup = toGroup;
            this.Charset = charset;
            this.IsHTML = isHTML;
            this.PixelIds = pixelIds;
            this.MessageId = messageId;
            this.MessageIds = messageIds;
            this.VirtualSend = virtualSend;
            this.TemplateId = templateId;
            this.TemplateVariables = templateVariables;
            this.Headers = headers;
            this.ThreadId = threadId;
            this.BodyExcerpt = bodyExcerpt;
            this.TextExcerpt = textExcerpt;
            this.InReplyTo = inReplyTo;
            this.Favourite = favourite;
            this.SizeBytes = sizeBytes;
            this.Html = html;
        }

        /// <summary>
        /// ID of sent email
        /// </summary>
        /// <value>ID of sent email</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        /// <value>User ID</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Inbox ID email was sent from
        /// </summary>
        /// <value>Inbox ID email was sent from</value>
        [DataMember(Name = "inboxId", IsRequired = true, EmitDefaultValue = true)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Domain ID
        /// </summary>
        /// <value>Domain ID</value>
        [DataMember(Name = "domainId", EmitDefaultValue = true)]
        public Guid? DomainId { get; set; }

        /// <summary>
        /// Recipients email was sent to
        /// </summary>
        /// <value>Recipients email was sent to</value>
        [DataMember(Name = "to", EmitDefaultValue = true)]
        public List<string> To { get; set; }

        /// <summary>
        /// Sent from address
        /// </summary>
        /// <value>Sent from address</value>
        [DataMember(Name = "from", EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name = "sender", EmitDefaultValue = true)]
        public Sender Sender { get; set; }

        /// <summary>
        /// Gets or Sets Recipients
        /// </summary>
        [DataMember(Name = "recipients", EmitDefaultValue = true)]
        public EmailRecipients Recipients { get; set; }

        /// <summary>
        /// Gets or Sets ReplyTo
        /// </summary>
        [DataMember(Name = "replyTo", EmitDefaultValue = true)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Gets or Sets Cc
        /// </summary>
        [DataMember(Name = "cc", EmitDefaultValue = true)]
        public List<string> Cc { get; set; }

        /// <summary>
        /// Gets or Sets Bcc
        /// </summary>
        [DataMember(Name = "bcc", EmitDefaultValue = true)]
        public List<string> Bcc { get; set; }

        /// <summary>
        /// Array of IDs of attachments that were sent with this email
        /// </summary>
        /// <value>Array of IDs of attachments that were sent with this email</value>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// MD5 Hash
        /// </summary>
        /// <value>MD5 Hash</value>
        [DataMember(Name = "bodyMD5Hash", EmitDefaultValue = true)]
        public string BodyMD5Hash { get; set; }

        /// <summary>
        /// Sent email body
        /// </summary>
        /// <value>Sent email body</value>
        [DataMember(Name = "body", EmitDefaultValue = true)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets ToContacts
        /// </summary>
        [DataMember(Name = "toContacts", EmitDefaultValue = true)]
        public List<Guid?> ToContacts { get; set; }

        /// <summary>
        /// Gets or Sets ToGroup
        /// </summary>
        [DataMember(Name = "toGroup", EmitDefaultValue = true)]
        public Guid? ToGroup { get; set; }

        /// <summary>
        /// Gets or Sets Charset
        /// </summary>
        [DataMember(Name = "charset", EmitDefaultValue = true)]
        public string Charset { get; set; }

        /// <summary>
        /// Gets or Sets IsHTML
        /// </summary>
        [DataMember(Name = "isHTML", EmitDefaultValue = true)]
        public bool? IsHTML { get; set; }

        /// <summary>
        /// Gets or Sets SentAt
        /// </summary>
        [DataMember(Name = "sentAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime SentAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets PixelIds
        /// </summary>
        [DataMember(Name = "pixelIds", EmitDefaultValue = true)]
        public List<Guid?> PixelIds { get; set; }

        /// <summary>
        /// RFC 5322 Message-ID header value without angle brackets.
        /// </summary>
        /// <value>RFC 5322 Message-ID header value without angle brackets.</value>
        [DataMember(Name = "messageId", EmitDefaultValue = true)]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or Sets MessageIds
        /// </summary>
        [DataMember(Name = "messageIds", EmitDefaultValue = true)]
        public List<string> MessageIds { get; set; }

        /// <summary>
        /// Gets or Sets VirtualSend
        /// </summary>
        [DataMember(Name = "virtualSend", EmitDefaultValue = true)]
        public bool? VirtualSend { get; set; }

        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name = "templateId", EmitDefaultValue = true)]
        public Guid? TemplateId { get; set; }

        /// <summary>
        /// Gets or Sets TemplateVariables
        /// </summary>
        [DataMember(Name = "templateVariables", EmitDefaultValue = true)]
        public Dictionary<string, Object> TemplateVariables { get; set; }

        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name = "headers", EmitDefaultValue = true)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// MailSlurp thread ID for email chain that enables lookup for In-Reply-To and References fields.
        /// </summary>
        /// <value>MailSlurp thread ID for email chain that enables lookup for In-Reply-To and References fields.</value>
        [DataMember(Name = "threadId", EmitDefaultValue = true)]
        public Guid? ThreadId { get; set; }

        /// <summary>
        /// An excerpt of the body of the email message for quick preview. Takes HTML content part if exists falls back to TEXT content part if not
        /// </summary>
        /// <value>An excerpt of the body of the email message for quick preview. Takes HTML content part if exists falls back to TEXT content part if not</value>
        [DataMember(Name = "bodyExcerpt", EmitDefaultValue = true)]
        public string BodyExcerpt { get; set; }

        /// <summary>
        /// An excerpt of the body of the email message for quick preview. Takes TEXT content part if exists
        /// </summary>
        /// <value>An excerpt of the body of the email message for quick preview. Takes TEXT content part if exists</value>
        [DataMember(Name = "textExcerpt", EmitDefaultValue = true)]
        public string TextExcerpt { get; set; }

        /// <summary>
        /// Parsed value of In-Reply-To header. A Message-ID in a thread.
        /// </summary>
        /// <value>Parsed value of In-Reply-To header. A Message-ID in a thread.</value>
        [DataMember(Name = "inReplyTo", EmitDefaultValue = true)]
        public string InReplyTo { get; set; }

        /// <summary>
        /// Is email favourited
        /// </summary>
        /// <value>Is email favourited</value>
        [DataMember(Name = "favourite", EmitDefaultValue = true)]
        public bool? Favourite { get; set; }

        /// <summary>
        /// Size of raw email message in bytes
        /// </summary>
        /// <value>Size of raw email message in bytes</value>
        [DataMember(Name = "sizeBytes", EmitDefaultValue = true)]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Gets or Sets Html
        /// </summary>
        [DataMember(Name = "html", EmitDefaultValue = true)]
        public bool Html { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SentEmailDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  DomainId: ").Append(DomainId).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  BodyMD5Hash: ").Append(BodyMD5Hash).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  ToContacts: ").Append(ToContacts).Append("\n");
            sb.Append("  ToGroup: ").Append(ToGroup).Append("\n");
            sb.Append("  Charset: ").Append(Charset).Append("\n");
            sb.Append("  IsHTML: ").Append(IsHTML).Append("\n");
            sb.Append("  SentAt: ").Append(SentAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  PixelIds: ").Append(PixelIds).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  MessageIds: ").Append(MessageIds).Append("\n");
            sb.Append("  VirtualSend: ").Append(VirtualSend).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  TemplateVariables: ").Append(TemplateVariables).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  BodyExcerpt: ").Append(BodyExcerpt).Append("\n");
            sb.Append("  TextExcerpt: ").Append(TextExcerpt).Append("\n");
            sb.Append("  InReplyTo: ").Append(InReplyTo).Append("\n");
            sb.Append("  Favourite: ").Append(Favourite).Append("\n");
            sb.Append("  SizeBytes: ").Append(SizeBytes).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
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
