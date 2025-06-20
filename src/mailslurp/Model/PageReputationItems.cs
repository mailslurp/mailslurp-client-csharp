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
    /// Paginated reputation items like complaints and bounces. Page index starts at zero. Projection results may omit larger entity fields. For fetching a full entity use the projection ID with individual method calls.
    /// </summary>
    [DataContract(Name = "PageReputationItems")]
    public partial class PageReputationItems : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageReputationItems" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PageReputationItems() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PageReputationItems" /> class.
        /// </summary>
        /// <param name="content">content.</param>
        /// <param name="pageable">pageable.</param>
        /// <param name="totalElements">totalElements (required).</param>
        /// <param name="totalPages">totalPages (required).</param>
        /// <param name="last">last.</param>
        /// <param name="numberOfElements">numberOfElements.</param>
        /// <param name="first">first.</param>
        /// <param name="size">size.</param>
        /// <param name="number">number.</param>
        /// <param name="sort">sort.</param>
        /// <param name="empty">empty.</param>
        public PageReputationItems(List<ReputationItemProjection> content = default, PageableObject pageable = default, long totalElements = default, int totalPages = default, bool last = default, int numberOfElements = default, bool first = default, int size = default, int number = default, SortObject sort = default, bool empty = default)
        {
            this.TotalElements = totalElements;
            this.TotalPages = totalPages;
            this.Content = content;
            this.Pageable = pageable;
            this.Last = last;
            this.NumberOfElements = numberOfElements;
            this.First = first;
            this.Size = size;
            this.Number = number;
            this.Sort = sort;
            this.Empty = empty;
        }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public List<ReputationItemProjection> Content { get; set; }

        /// <summary>
        /// Gets or Sets Pageable
        /// </summary>
        [DataMember(Name = "pageable", EmitDefaultValue = false)]
        public PageableObject Pageable { get; set; }

        /// <summary>
        /// Gets or Sets TotalElements
        /// </summary>
        [DataMember(Name = "totalElements", IsRequired = true, EmitDefaultValue = true)]
        public long TotalElements { get; set; }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name = "totalPages", IsRequired = true, EmitDefaultValue = true)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [DataMember(Name = "last", EmitDefaultValue = true)]
        public bool Last { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfElements
        /// </summary>
        [DataMember(Name = "numberOfElements", EmitDefaultValue = false)]
        public int NumberOfElements { get; set; }

        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name = "first", EmitDefaultValue = true)]
        public bool First { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public int Number { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name = "sort", EmitDefaultValue = false)]
        public SortObject Sort { get; set; }

        /// <summary>
        /// Gets or Sets Empty
        /// </summary>
        [DataMember(Name = "empty", EmitDefaultValue = true)]
        public bool Empty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PageReputationItems {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Pageable: ").Append(Pageable).Append("\n");
            sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  NumberOfElements: ").Append(NumberOfElements).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Empty: ").Append(Empty).Append("\n");
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
