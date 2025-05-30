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
    /// Email entity (also known as EmailDto). When an SMTP email message is received by MailSlurp it is parsed. The body and attachments are written to disk and the fields such as to, from, subject etc are stored in a database. The &#x60;body&#x60; contains the email content. If you want the original SMTP message see the &#x60;getRawEmail&#x60; endpoints. The attachments can be fetched using the AttachmentController
    /// </summary>
    [DataContract(Name = "Email")]
    public partial class Email : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Email() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        /// <param name="id">ID of the email entity (required).</param>
        /// <param name="userId">ID of user that email belongs to (required).</param>
        /// <param name="inboxId">ID of the inbox that received the email (required).</param>
        /// <param name="domainId">ID of the domain that received the email.</param>
        /// <param name="to">List of &#x60;To&#x60; recipient email addresses that the email was addressed to. See recipients object for names. (required).</param>
        /// <param name="from">Who the email was sent from. An email address - see fromName for the sender name..</param>
        /// <param name="sender">sender.</param>
        /// <param name="recipients">recipients.</param>
        /// <param name="replyTo">The &#x60;replyTo&#x60; field on the received email message.</param>
        /// <param name="cc">List of &#x60;CC&#x60; recipients email addresses that the email was addressed to. See recipients object for names..</param>
        /// <param name="bcc">List of &#x60;BCC&#x60; recipients email addresses that the email was addressed to. See recipients object for names..</param>
        /// <param name="headers">Collection of SMTP headers attached to email.</param>
        /// <param name="headersMap">Multi-value map of SMTP headers attached to email.</param>
        /// <param name="attachments">List of IDs of attachments found in the email. Use these IDs with the Inbox and Email Controllers to download attachments and attachment meta data such as filesize, name, extension..</param>
        /// <param name="subject">The subject line of the email message as specified by SMTP subject header.</param>
        /// <param name="body">The body of the email message as text parsed from the SMTP message body (does not include attachments). Fetch the raw content to access the SMTP message and use the attachments property to access attachments. The body is stored separately to the email entity so the body is not returned in paginated results only in full single email or wait requests..</param>
        /// <param name="bodyExcerpt">An excerpt of the body of the email message for quick preview. Takes HTML content part if exists falls back to TEXT content part if not.</param>
        /// <param name="textExcerpt">An excerpt of the body of the email message for quick preview. Takes TEXT content part if exists.</param>
        /// <param name="bodyMD5Hash">A hash signature of the email message using MD5. Useful for comparing emails without fetching full body..</param>
        /// <param name="isHTML">Is the email body content type HTML?.</param>
        /// <param name="charset">Detected character set of the email body such as UTF-8.</param>
        /// <param name="analysis">analysis.</param>
        /// <param name="createdAt">When was the email received by MailSlurp (required).</param>
        /// <param name="updatedAt">When was the email last updated (required).</param>
        /// <param name="read">Read flag. Has the email ever been viewed in the dashboard or fetched via the API with a hydrated body? If so the email is marked as read. Paginated results do not affect read status. Read status is different to email opened event as it depends on your own account accessing the email. Email opened is determined by tracking pixels sent to other uses if enable during sending. You can listened for both email read and email opened events using webhooks. (required).</param>
        /// <param name="teamAccess">Can the email be accessed by organization team members (required).</param>
        /// <param name="isXAmpHtml">Is the email body content type x-amp-html Amp4Email?.</param>
        /// <param name="bodyPartContentTypes">A list of detected multipart mime message body part content types such as text/plain and text/html. Can be used with email bodyPart endpoints to fetch individual body parts..</param>
        /// <param name="externalId">UID used by external IMAP server to identify email.</param>
        /// <param name="messageId">RFC 5322 Message-ID header value without angle brackets..</param>
        /// <param name="threadId">MailSlurp thread ID for email chain that enables lookup for In-Reply-To and References fields..</param>
        /// <param name="inReplyTo">Parsed value of In-Reply-To header. A Message-ID in a thread..</param>
        /// <param name="favourite">Is email favourited.</param>
        /// <param name="sizeBytes">Size of raw email message in bytes.</param>
        /// <param name="html">html.</param>
        /// <param name="xampHtml">xampHtml.</param>
        public Email(Guid id = default, Guid userId = default, Guid inboxId = default, Guid? domainId = default, List<string> to = default, string from = default, Sender sender = default, EmailRecipients recipients = default, string replyTo = default, List<string> cc = default, List<string> bcc = default, Dictionary<string, string> headers = default, Dictionary<string, List<string>> headersMap = default, List<string> attachments = default, string subject = default, string body = default, string bodyExcerpt = default, string textExcerpt = default, string bodyMD5Hash = default, bool? isHTML = default, string charset = default, EmailAnalysis analysis = default, DateTime createdAt = default, DateTime updatedAt = default, bool read = default, bool teamAccess = default, bool? isXAmpHtml = default, List<string> bodyPartContentTypes = default, string externalId = default, string messageId = default, Guid? threadId = default, string inReplyTo = default, bool? favourite = default, long? sizeBytes = default, bool html = default, bool xampHtml = default)
        {
            this.Id = id;
            this.UserId = userId;
            this.InboxId = inboxId;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for Email and cannot be null");
            }
            this.To = to;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Read = read;
            this.TeamAccess = teamAccess;
            this.DomainId = domainId;
            this.From = from;
            this.Sender = sender;
            this.Recipients = recipients;
            this.ReplyTo = replyTo;
            this.Cc = cc;
            this.Bcc = bcc;
            this.Headers = headers;
            this.HeadersMap = headersMap;
            this.Attachments = attachments;
            this.Subject = subject;
            this.Body = body;
            this.BodyExcerpt = bodyExcerpt;
            this.TextExcerpt = textExcerpt;
            this.BodyMD5Hash = bodyMD5Hash;
            this.IsHTML = isHTML;
            this.Charset = charset;
            this.Analysis = analysis;
            this.IsXAmpHtml = isXAmpHtml;
            this.BodyPartContentTypes = bodyPartContentTypes;
            this.ExternalId = externalId;
            this.MessageId = messageId;
            this.ThreadId = threadId;
            this.InReplyTo = inReplyTo;
            this.Favourite = favourite;
            this.SizeBytes = sizeBytes;
            this.Html = html;
            this.XampHtml = xampHtml;
        }

        /// <summary>
        /// ID of the email entity
        /// </summary>
        /// <value>ID of the email entity</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// ID of user that email belongs to
        /// </summary>
        /// <value>ID of user that email belongs to</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// ID of the inbox that received the email
        /// </summary>
        /// <value>ID of the inbox that received the email</value>
        [DataMember(Name = "inboxId", IsRequired = true, EmitDefaultValue = true)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// ID of the domain that received the email
        /// </summary>
        /// <value>ID of the domain that received the email</value>
        [DataMember(Name = "domainId", EmitDefaultValue = true)]
        public Guid? DomainId { get; set; }

        /// <summary>
        /// List of &#x60;To&#x60; recipient email addresses that the email was addressed to. See recipients object for names.
        /// </summary>
        /// <value>List of &#x60;To&#x60; recipient email addresses that the email was addressed to. See recipients object for names.</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public List<string> To { get; set; }

        /// <summary>
        /// Who the email was sent from. An email address - see fromName for the sender name.
        /// </summary>
        /// <value>Who the email was sent from. An email address - see fromName for the sender name.</value>
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
        /// The &#x60;replyTo&#x60; field on the received email message
        /// </summary>
        /// <value>The &#x60;replyTo&#x60; field on the received email message</value>
        [DataMember(Name = "replyTo", EmitDefaultValue = true)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// List of &#x60;CC&#x60; recipients email addresses that the email was addressed to. See recipients object for names.
        /// </summary>
        /// <value>List of &#x60;CC&#x60; recipients email addresses that the email was addressed to. See recipients object for names.</value>
        [DataMember(Name = "cc", EmitDefaultValue = true)]
        public List<string> Cc { get; set; }

        /// <summary>
        /// List of &#x60;BCC&#x60; recipients email addresses that the email was addressed to. See recipients object for names.
        /// </summary>
        /// <value>List of &#x60;BCC&#x60; recipients email addresses that the email was addressed to. See recipients object for names.</value>
        [DataMember(Name = "bcc", EmitDefaultValue = true)]
        public List<string> Bcc { get; set; }

        /// <summary>
        /// Collection of SMTP headers attached to email
        /// </summary>
        /// <value>Collection of SMTP headers attached to email</value>
        [DataMember(Name = "headers", EmitDefaultValue = true)]
        [Obsolete]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Multi-value map of SMTP headers attached to email
        /// </summary>
        /// <value>Multi-value map of SMTP headers attached to email</value>
        [DataMember(Name = "headersMap", EmitDefaultValue = true)]
        public Dictionary<string, List<string>> HeadersMap { get; set; }

        /// <summary>
        /// List of IDs of attachments found in the email. Use these IDs with the Inbox and Email Controllers to download attachments and attachment meta data such as filesize, name, extension.
        /// </summary>
        /// <value>List of IDs of attachments found in the email. Use these IDs with the Inbox and Email Controllers to download attachments and attachment meta data such as filesize, name, extension.</value>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// The subject line of the email message as specified by SMTP subject header
        /// </summary>
        /// <value>The subject line of the email message as specified by SMTP subject header</value>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// The body of the email message as text parsed from the SMTP message body (does not include attachments). Fetch the raw content to access the SMTP message and use the attachments property to access attachments. The body is stored separately to the email entity so the body is not returned in paginated results only in full single email or wait requests.
        /// </summary>
        /// <value>The body of the email message as text parsed from the SMTP message body (does not include attachments). Fetch the raw content to access the SMTP message and use the attachments property to access attachments. The body is stored separately to the email entity so the body is not returned in paginated results only in full single email or wait requests.</value>
        [DataMember(Name = "body", EmitDefaultValue = true)]
        public string Body { get; set; }

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
        /// A hash signature of the email message using MD5. Useful for comparing emails without fetching full body.
        /// </summary>
        /// <value>A hash signature of the email message using MD5. Useful for comparing emails without fetching full body.</value>
        [DataMember(Name = "bodyMD5Hash", EmitDefaultValue = true)]
        public string BodyMD5Hash { get; set; }

        /// <summary>
        /// Is the email body content type HTML?
        /// </summary>
        /// <value>Is the email body content type HTML?</value>
        [DataMember(Name = "isHTML", EmitDefaultValue = true)]
        public bool? IsHTML { get; set; }

        /// <summary>
        /// Detected character set of the email body such as UTF-8
        /// </summary>
        /// <value>Detected character set of the email body such as UTF-8</value>
        [DataMember(Name = "charset", EmitDefaultValue = true)]
        public string Charset { get; set; }

        /// <summary>
        /// Gets or Sets Analysis
        /// </summary>
        [DataMember(Name = "analysis", EmitDefaultValue = true)]
        public EmailAnalysis Analysis { get; set; }

        /// <summary>
        /// When was the email received by MailSlurp
        /// </summary>
        /// <value>When was the email received by MailSlurp</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// When was the email last updated
        /// </summary>
        /// <value>When was the email last updated</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Read flag. Has the email ever been viewed in the dashboard or fetched via the API with a hydrated body? If so the email is marked as read. Paginated results do not affect read status. Read status is different to email opened event as it depends on your own account accessing the email. Email opened is determined by tracking pixels sent to other uses if enable during sending. You can listened for both email read and email opened events using webhooks.
        /// </summary>
        /// <value>Read flag. Has the email ever been viewed in the dashboard or fetched via the API with a hydrated body? If so the email is marked as read. Paginated results do not affect read status. Read status is different to email opened event as it depends on your own account accessing the email. Email opened is determined by tracking pixels sent to other uses if enable during sending. You can listened for both email read and email opened events using webhooks.</value>
        [DataMember(Name = "read", IsRequired = true, EmitDefaultValue = true)]
        public bool Read { get; set; }

        /// <summary>
        /// Can the email be accessed by organization team members
        /// </summary>
        /// <value>Can the email be accessed by organization team members</value>
        [DataMember(Name = "teamAccess", IsRequired = true, EmitDefaultValue = true)]
        public bool TeamAccess { get; set; }

        /// <summary>
        /// Is the email body content type x-amp-html Amp4Email?
        /// </summary>
        /// <value>Is the email body content type x-amp-html Amp4Email?</value>
        [DataMember(Name = "isXAmpHtml", EmitDefaultValue = true)]
        public bool? IsXAmpHtml { get; set; }

        /// <summary>
        /// A list of detected multipart mime message body part content types such as text/plain and text/html. Can be used with email bodyPart endpoints to fetch individual body parts.
        /// </summary>
        /// <value>A list of detected multipart mime message body part content types such as text/plain and text/html. Can be used with email bodyPart endpoints to fetch individual body parts.</value>
        [DataMember(Name = "bodyPartContentTypes", EmitDefaultValue = true)]
        public List<string> BodyPartContentTypes { get; set; }

        /// <summary>
        /// UID used by external IMAP server to identify email
        /// </summary>
        /// <value>UID used by external IMAP server to identify email</value>
        [DataMember(Name = "externalId", EmitDefaultValue = true)]
        public string ExternalId { get; set; }

        /// <summary>
        /// RFC 5322 Message-ID header value without angle brackets.
        /// </summary>
        /// <value>RFC 5322 Message-ID header value without angle brackets.</value>
        [DataMember(Name = "messageId", EmitDefaultValue = true)]
        public string MessageId { get; set; }

        /// <summary>
        /// MailSlurp thread ID for email chain that enables lookup for In-Reply-To and References fields.
        /// </summary>
        /// <value>MailSlurp thread ID for email chain that enables lookup for In-Reply-To and References fields.</value>
        [DataMember(Name = "threadId", EmitDefaultValue = true)]
        public Guid? ThreadId { get; set; }

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
        /// Gets or Sets XampHtml
        /// </summary>
        [DataMember(Name = "xampHtml", EmitDefaultValue = true)]
        public bool XampHtml { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Email {\n");
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
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  HeadersMap: ").Append(HeadersMap).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  BodyExcerpt: ").Append(BodyExcerpt).Append("\n");
            sb.Append("  TextExcerpt: ").Append(TextExcerpt).Append("\n");
            sb.Append("  BodyMD5Hash: ").Append(BodyMD5Hash).Append("\n");
            sb.Append("  IsHTML: ").Append(IsHTML).Append("\n");
            sb.Append("  Charset: ").Append(Charset).Append("\n");
            sb.Append("  Analysis: ").Append(Analysis).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  TeamAccess: ").Append(TeamAccess).Append("\n");
            sb.Append("  IsXAmpHtml: ").Append(IsXAmpHtml).Append("\n");
            sb.Append("  BodyPartContentTypes: ").Append(BodyPartContentTypes).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  InReplyTo: ").Append(InReplyTo).Append("\n");
            sb.Append("  Favourite: ").Append(Favourite).Append("\n");
            sb.Append("  SizeBytes: ").Append(SizeBytes).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  XampHtml: ").Append(XampHtml).Append("\n");
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
