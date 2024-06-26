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
    /// ConnectorSyncRequestResult
    /// </summary>
    [DataContract(Name = "ConnectorSyncRequestResult")]
    public partial class ConnectorSyncRequestResult : IEquatable<ConnectorSyncRequestResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorSyncRequestResult" /> class.
        /// </summary>
        /// <param name="syncResult">syncResult.</param>
        /// <param name="exception">exception.</param>
        /// <param name="eventId">eventId.</param>
        public ConnectorSyncRequestResult(ConnectorSyncResult syncResult = default(ConnectorSyncResult), ConnectorSyncRequestResultException exception = default(ConnectorSyncRequestResultException), Guid eventId = default(Guid))
        {
            this.SyncResult = syncResult;
            this.Exception = exception;
            this.EventId = eventId;
        }

        /// <summary>
        /// Gets or Sets SyncResult
        /// </summary>
        [DataMember(Name = "syncResult", EmitDefaultValue = false)]
        public ConnectorSyncResult SyncResult { get; set; }

        /// <summary>
        /// Gets or Sets Exception
        /// </summary>
        [DataMember(Name = "exception", EmitDefaultValue = false)]
        public ConnectorSyncRequestResultException Exception { get; set; }

        /// <summary>
        /// Gets or Sets EventId
        /// </summary>
        [DataMember(Name = "eventId", EmitDefaultValue = false)]
        public Guid EventId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectorSyncRequestResult {\n");
            sb.Append("  SyncResult: ").Append(SyncResult).Append("\n");
            sb.Append("  Exception: ").Append(Exception).Append("\n");
            sb.Append("  EventId: ").Append(EventId).Append("\n");
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
            return this.Equals(input as ConnectorSyncRequestResult);
        }

        /// <summary>
        /// Returns true if ConnectorSyncRequestResult instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorSyncRequestResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorSyncRequestResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SyncResult == input.SyncResult ||
                    (this.SyncResult != null &&
                    this.SyncResult.Equals(input.SyncResult))
                ) && 
                (
                    this.Exception == input.Exception ||
                    (this.Exception != null &&
                    this.Exception.Equals(input.Exception))
                ) && 
                (
                    this.EventId == input.EventId ||
                    (this.EventId != null &&
                    this.EventId.Equals(input.EventId))
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
                if (this.SyncResult != null)
                {
                    hashCode = (hashCode * 59) + this.SyncResult.GetHashCode();
                }
                if (this.Exception != null)
                {
                    hashCode = (hashCode * 59) + this.Exception.GetHashCode();
                }
                if (this.EventId != null)
                {
                    hashCode = (hashCode * 59) + this.EventId.GetHashCode();
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
