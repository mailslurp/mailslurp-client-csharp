/* 
 * MailSlurp API
 *
 * ## Introduction  [MailSlurp](https://www.mailslurp.com) is an Email API for developers and QA testers. It let's users: - create emails addresses on demand - receive emails and attachments in code - send templated HTML emails  ## About  This page contains the REST API documentation for MailSlurp. All requests require API Key authentication passed as an `x-api-key` header.  Create an account to [get your free API Key](https://app.mailslurp.com/sign-up/).  ## Resources - 🔑 [Get API Key](https://app.mailslurp.com/sign-up/)                    - 🎓 [Developer Portal](https://www.mailslurp.com/docs/)           - 📦 [Library SDKs](https://www.mailslurp.com/docs/) - ✍️ [Code Examples](https://www.mailslurp.com/examples) - ⚠️ [Report an issue](https://drift.me/mailslurp)  ## Explore  
 *
 * The version of the OpenAPI document: 6.5.2
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = mailslurp.Client.OpenAPIDateConverter;

namespace mailslurp.Model
{
    /// <summary>
    /// PageWebhookProjection
    /// </summary>
    [DataContract]
    public partial class PageWebhookProjection :  IEquatable<PageWebhookProjection>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageWebhookProjection" /> class.
        /// </summary>
        /// <param name="content">content.</param>
        /// <param name="empty">empty.</param>
        /// <param name="first">first.</param>
        /// <param name="last">last.</param>
        /// <param name="number">number.</param>
        /// <param name="numberOfElements">numberOfElements.</param>
        /// <param name="pageable">pageable.</param>
        /// <param name="size">size.</param>
        /// <param name="sort">sort.</param>
        /// <param name="totalElements">totalElements.</param>
        /// <param name="totalPages">totalPages.</param>
        public PageWebhookProjection(List<WebhookProjection> content = default(List<WebhookProjection>), bool empty = default(bool), bool first = default(bool), bool last = default(bool), int number = default(int), int numberOfElements = default(int), Pageable pageable = default(Pageable), int size = default(int), Sort sort = default(Sort), long totalElements = default(long), int totalPages = default(int))
        {
            this.Content = content;
            this.Empty = empty;
            this.First = first;
            this.Last = last;
            this.Number = number;
            this.NumberOfElements = numberOfElements;
            this.Pageable = pageable;
            this.Size = size;
            this.Sort = sort;
            this.TotalElements = totalElements;
            this.TotalPages = totalPages;
        }
        
        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public List<WebhookProjection> Content { get; set; }

        /// <summary>
        /// Gets or Sets Empty
        /// </summary>
        [DataMember(Name="empty", EmitDefaultValue=false)]
        public bool Empty { get; set; }

        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name="first", EmitDefaultValue=false)]
        public bool First { get; set; }

        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public bool Last { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public int Number { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfElements
        /// </summary>
        [DataMember(Name="numberOfElements", EmitDefaultValue=false)]
        public int NumberOfElements { get; set; }

        /// <summary>
        /// Gets or Sets Pageable
        /// </summary>
        [DataMember(Name="pageable", EmitDefaultValue=false)]
        public Pageable Pageable { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int Size { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public Sort Sort { get; set; }

        /// <summary>
        /// Gets or Sets TotalElements
        /// </summary>
        [DataMember(Name="totalElements", EmitDefaultValue=false)]
        public long TotalElements { get; set; }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name="totalPages", EmitDefaultValue=false)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PageWebhookProjection {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Empty: ").Append(Empty).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  NumberOfElements: ").Append(NumberOfElements).Append("\n");
            sb.Append("  Pageable: ").Append(Pageable).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PageWebhookProjection);
        }

        /// <summary>
        /// Returns true if PageWebhookProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of PageWebhookProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageWebhookProjection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    this.Content != null &&
                    input.Content != null &&
                    this.Content.SequenceEqual(input.Content)
                ) && 
                (
                    this.Empty == input.Empty ||
                    (this.Empty != null &&
                    this.Empty.Equals(input.Empty))
                ) && 
                (
                    this.First == input.First ||
                    (this.First != null &&
                    this.First.Equals(input.First))
                ) && 
                (
                    this.Last == input.Last ||
                    (this.Last != null &&
                    this.Last.Equals(input.Last))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.NumberOfElements == input.NumberOfElements ||
                    (this.NumberOfElements != null &&
                    this.NumberOfElements.Equals(input.NumberOfElements))
                ) && 
                (
                    this.Pageable == input.Pageable ||
                    (this.Pageable != null &&
                    this.Pageable.Equals(input.Pageable))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) && 
                (
                    this.TotalElements == input.TotalElements ||
                    (this.TotalElements != null &&
                    this.TotalElements.Equals(input.TotalElements))
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    (this.TotalPages != null &&
                    this.TotalPages.Equals(input.TotalPages))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Empty != null)
                    hashCode = hashCode * 59 + this.Empty.GetHashCode();
                if (this.First != null)
                    hashCode = hashCode * 59 + this.First.GetHashCode();
                if (this.Last != null)
                    hashCode = hashCode * 59 + this.Last.GetHashCode();
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.NumberOfElements != null)
                    hashCode = hashCode * 59 + this.NumberOfElements.GetHashCode();
                if (this.Pageable != null)
                    hashCode = hashCode * 59 + this.Pageable.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.TotalElements != null)
                    hashCode = hashCode * 59 + this.TotalElements.GetHashCode();
                if (this.TotalPages != null)
                    hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
                return hashCode;
            }
        }
    }

}