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
    /// SearchEmailsOptions
    /// </summary>
    [DataContract(Name = "SearchEmailsOptions")]
    public partial class SearchEmailsOptions : IEquatable<SearchEmailsOptions>, IValidatableObject
    {
        /// <summary>
        /// Optional createdAt sort direction ASC or DESC
        /// </summary>
        /// <value>Optional createdAt sort direction ASC or DESC</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortDirectionEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            [EnumMember(Value = "ASC")]
            ASC = 1,

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            [EnumMember(Value = "DESC")]
            DESC = 2

        }


        /// <summary>
        /// Optional createdAt sort direction ASC or DESC
        /// </summary>
        /// <value>Optional createdAt sort direction ASC or DESC</value>
        [DataMember(Name = "sortDirection", EmitDefaultValue = false)]
        public SortDirectionEnum? SortDirection { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchEmailsOptions" /> class.
        /// </summary>
        /// <param name="inboxIds">Optional inbox ids to filter by. Can be repeated. By default will use all inboxes belonging to your account..</param>
        /// <param name="pageIndex">Optional page index in email list pagination.</param>
        /// <param name="pageSize">Optional page size in email list pagination. Maximum size is 100. Use page index and sort to page through larger results.</param>
        /// <param name="sortDirection">Optional createdAt sort direction ASC or DESC.</param>
        /// <param name="unreadOnly">Optional filter for unread emails only. All emails are considered unread until they are viewed in the dashboard or requested directly.</param>
        /// <param name="searchFilter">Optional search filter. Searches email recipients, sender, subject, email address and ID. Does not search email body.</param>
        /// <param name="since">Optional filter emails received after given date time.</param>
        /// <param name="before">Optional filter emails received before given date time.</param>
        public SearchEmailsOptions(List<Guid> inboxIds = default(List<Guid>), int pageIndex = default(int), int pageSize = default(int), SortDirectionEnum? sortDirection = default(SortDirectionEnum?), bool unreadOnly = default(bool), string searchFilter = default(string), DateTime since = default(DateTime), DateTime before = default(DateTime))
        {
            this.InboxIds = inboxIds;
            this.PageIndex = pageIndex;
            this.PageSize = pageSize;
            this.SortDirection = sortDirection;
            this.UnreadOnly = unreadOnly;
            this.SearchFilter = searchFilter;
            this.Since = since;
            this.Before = before;
        }

        /// <summary>
        /// Optional inbox ids to filter by. Can be repeated. By default will use all inboxes belonging to your account.
        /// </summary>
        /// <value>Optional inbox ids to filter by. Can be repeated. By default will use all inboxes belonging to your account.</value>
        [DataMember(Name = "inboxIds", EmitDefaultValue = false)]
        public List<Guid> InboxIds { get; set; }

        /// <summary>
        /// Optional page index in email list pagination
        /// </summary>
        /// <value>Optional page index in email list pagination</value>
        [DataMember(Name = "pageIndex", EmitDefaultValue = false)]
        public int PageIndex { get; set; }

        /// <summary>
        /// Optional page size in email list pagination. Maximum size is 100. Use page index and sort to page through larger results
        /// </summary>
        /// <value>Optional page size in email list pagination. Maximum size is 100. Use page index and sort to page through larger results</value>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Optional filter for unread emails only. All emails are considered unread until they are viewed in the dashboard or requested directly
        /// </summary>
        /// <value>Optional filter for unread emails only. All emails are considered unread until they are viewed in the dashboard or requested directly</value>
        [DataMember(Name = "unreadOnly", EmitDefaultValue = true)]
        public bool UnreadOnly { get; set; }

        /// <summary>
        /// Optional search filter. Searches email recipients, sender, subject, email address and ID. Does not search email body
        /// </summary>
        /// <value>Optional search filter. Searches email recipients, sender, subject, email address and ID. Does not search email body</value>
        [DataMember(Name = "searchFilter", EmitDefaultValue = false)]
        public string SearchFilter { get; set; }

        /// <summary>
        /// Optional filter emails received after given date time
        /// </summary>
        /// <value>Optional filter emails received after given date time</value>
        [DataMember(Name = "since", EmitDefaultValue = false)]
        public DateTime Since { get; set; }

        /// <summary>
        /// Optional filter emails received before given date time
        /// </summary>
        /// <value>Optional filter emails received before given date time</value>
        [DataMember(Name = "before", EmitDefaultValue = false)]
        public DateTime Before { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchEmailsOptions {\n");
            sb.Append("  InboxIds: ").Append(InboxIds).Append("\n");
            sb.Append("  PageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  SortDirection: ").Append(SortDirection).Append("\n");
            sb.Append("  UnreadOnly: ").Append(UnreadOnly).Append("\n");
            sb.Append("  SearchFilter: ").Append(SearchFilter).Append("\n");
            sb.Append("  Since: ").Append(Since).Append("\n");
            sb.Append("  Before: ").Append(Before).Append("\n");
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
            return this.Equals(input as SearchEmailsOptions);
        }

        /// <summary>
        /// Returns true if SearchEmailsOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchEmailsOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchEmailsOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InboxIds == input.InboxIds ||
                    this.InboxIds != null &&
                    input.InboxIds != null &&
                    this.InboxIds.SequenceEqual(input.InboxIds)
                ) && 
                (
                    this.PageIndex == input.PageIndex ||
                    this.PageIndex.Equals(input.PageIndex)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.SortDirection == input.SortDirection ||
                    this.SortDirection.Equals(input.SortDirection)
                ) && 
                (
                    this.UnreadOnly == input.UnreadOnly ||
                    this.UnreadOnly.Equals(input.UnreadOnly)
                ) && 
                (
                    this.SearchFilter == input.SearchFilter ||
                    (this.SearchFilter != null &&
                    this.SearchFilter.Equals(input.SearchFilter))
                ) && 
                (
                    this.Since == input.Since ||
                    (this.Since != null &&
                    this.Since.Equals(input.Since))
                ) && 
                (
                    this.Before == input.Before ||
                    (this.Before != null &&
                    this.Before.Equals(input.Before))
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
                if (this.InboxIds != null)
                {
                    hashCode = (hashCode * 59) + this.InboxIds.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageIndex.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.SortDirection.GetHashCode();
                hashCode = (hashCode * 59) + this.UnreadOnly.GetHashCode();
                if (this.SearchFilter != null)
                {
                    hashCode = (hashCode * 59) + this.SearchFilter.GetHashCode();
                }
                if (this.Since != null)
                {
                    hashCode = (hashCode * 59) + this.Since.GetHashCode();
                }
                if (this.Before != null)
                {
                    hashCode = (hashCode * 59) + this.Before.GetHashCode();
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
            // PageSize (int) maximum
            if (this.PageSize > (int)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PageSize, must be a value less than or equal to 100.", new [] { "PageSize" });
            }

            yield break;
        }
    }

}