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
    /// JSON output schema for structured content repsonses. This schema dictates the format that an AI should use when responding to your instructions.
    /// </summary>
    [DataContract(Name = "StructuredOutputSchema")]
    public partial class StructuredOutputSchema : IValidatableObject
    {
        /// <summary>
        /// Primitive JSON schema types with a fallback CUSTOM for unknown values.
        /// </summary>
        /// <value>Primitive JSON schema types with a fallback CUSTOM for unknown values.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum String for value: string
            /// </summary>
            [EnumMember(Value = "string")]
            String = 1,

            /// <summary>
            /// Enum Number for value: number
            /// </summary>
            [EnumMember(Value = "number")]
            Number = 2,

            /// <summary>
            /// Enum Integer for value: integer
            /// </summary>
            [EnumMember(Value = "integer")]
            Integer = 3,

            /// <summary>
            /// Enum Boolean for value: boolean
            /// </summary>
            [EnumMember(Value = "boolean")]
            Boolean = 4,

            /// <summary>
            /// Enum Object for value: object
            /// </summary>
            [EnumMember(Value = "object")]
            Object = 5,

            /// <summary>
            /// Enum Array for value: array
            /// </summary>
            [EnumMember(Value = "array")]
            Array = 6,

            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = "null")]
            Null = 7
        }


        /// <summary>
        /// Primitive JSON schema types with a fallback CUSTOM for unknown values.
        /// </summary>
        /// <value>Primitive JSON schema types with a fallback CUSTOM for unknown values.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredOutputSchema" /> class.
        /// </summary>
        /// <param name="anyOf">anyOf.</param>
        /// <param name="varDefault">varDefault.</param>
        /// <param name="description">Provide a description of the schema to help the AI understand the schema..</param>
        /// <param name="varEnum">When using type string and format enum pass a collection of enum values here..</param>
        /// <param name="example">example.</param>
        /// <param name="format">Format for string types. Can be null, date-time or enum..</param>
        /// <param name="items">items.</param>
        /// <param name="maxItems">maxItems.</param>
        /// <param name="minItems">minItems.</param>
        /// <param name="maxLength">maxLength.</param>
        /// <param name="minLength">minLength.</param>
        /// <param name="pattern">pattern.</param>
        /// <param name="properties">Properties of an OBJECT schema. These are key value pairs where the key is the property name and the value is the schema for that property..</param>
        /// <param name="propertyOrdering">Pass an array of property names to specify the order of properties in the generated JSON object if required..</param>
        /// <param name="required">required.</param>
        /// <param name="maxProperties">maxProperties.</param>
        /// <param name="minProperties">minProperties.</param>
        /// <param name="maximum">maximum.</param>
        /// <param name="minimum">minimum.</param>
        /// <param name="nullable">nullable.</param>
        /// <param name="title">title.</param>
        /// <param name="type">Primitive JSON schema types with a fallback CUSTOM for unknown values..</param>
        public StructuredOutputSchema(List<StructuredOutputSchema> anyOf = default, Object varDefault = default, string description = default, List<string> varEnum = default, Object example = default, string format = default, StructuredOutputSchema items = default, long? maxItems = default, long? minItems = default, long? maxLength = default, long? minLength = default, string pattern = default, Dictionary<string, StructuredOutputSchema> properties = default, List<string> propertyOrdering = default, List<string> required = default, long? maxProperties = default, long? minProperties = default, decimal? maximum = default, decimal? minimum = default, bool? nullable = default, string title = default, TypeEnum? type = default)
        {
            this.AnyOf = anyOf;
            this.Default = varDefault;
            this.Description = description;
            this.Enum = varEnum;
            this.Example = example;
            this.Format = format;
            this.Items = items;
            this.MaxItems = maxItems;
            this.MinItems = minItems;
            this.MaxLength = maxLength;
            this.MinLength = minLength;
            this.Pattern = pattern;
            this.Properties = properties;
            this.PropertyOrdering = propertyOrdering;
            this.Required = required;
            this.MaxProperties = maxProperties;
            this.MinProperties = minProperties;
            this.Maximum = maximum;
            this.Minimum = minimum;
            this.Nullable = nullable;
            this.Title = title;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets AnyOf
        /// </summary>
        [DataMember(Name = "anyOf", EmitDefaultValue = true)]
        public List<StructuredOutputSchema> AnyOf { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name = "default", EmitDefaultValue = true)]
        public Object Default { get; set; }

        /// <summary>
        /// Provide a description of the schema to help the AI understand the schema.
        /// </summary>
        /// <value>Provide a description of the schema to help the AI understand the schema.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// When using type string and format enum pass a collection of enum values here.
        /// </summary>
        /// <value>When using type string and format enum pass a collection of enum values here.</value>
        [DataMember(Name = "enum", EmitDefaultValue = true)]
        public List<string> Enum { get; set; }

        /// <summary>
        /// Gets or Sets Example
        /// </summary>
        [DataMember(Name = "example", EmitDefaultValue = true)]
        public Object Example { get; set; }

        /// <summary>
        /// Format for string types. Can be null, date-time or enum.
        /// </summary>
        /// <value>Format for string types. Can be null, date-time or enum.</value>
        [DataMember(Name = "format", EmitDefaultValue = true)]
        public string Format { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public StructuredOutputSchema Items { get; set; }

        /// <summary>
        /// Gets or Sets MaxItems
        /// </summary>
        [DataMember(Name = "maxItems", EmitDefaultValue = true)]
        public long? MaxItems { get; set; }

        /// <summary>
        /// Gets or Sets MinItems
        /// </summary>
        [DataMember(Name = "minItems", EmitDefaultValue = true)]
        public long? MinItems { get; set; }

        /// <summary>
        /// Gets or Sets MaxLength
        /// </summary>
        [DataMember(Name = "maxLength", EmitDefaultValue = true)]
        public long? MaxLength { get; set; }

        /// <summary>
        /// Gets or Sets MinLength
        /// </summary>
        [DataMember(Name = "minLength", EmitDefaultValue = true)]
        public long? MinLength { get; set; }

        /// <summary>
        /// Gets or Sets Pattern
        /// </summary>
        [DataMember(Name = "pattern", EmitDefaultValue = true)]
        public string Pattern { get; set; }

        /// <summary>
        /// Properties of an OBJECT schema. These are key value pairs where the key is the property name and the value is the schema for that property.
        /// </summary>
        /// <value>Properties of an OBJECT schema. These are key value pairs where the key is the property name and the value is the schema for that property.</value>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public Dictionary<string, StructuredOutputSchema> Properties { get; set; }

        /// <summary>
        /// Pass an array of property names to specify the order of properties in the generated JSON object if required.
        /// </summary>
        /// <value>Pass an array of property names to specify the order of properties in the generated JSON object if required.</value>
        [DataMember(Name = "propertyOrdering", EmitDefaultValue = true)]
        public List<string> PropertyOrdering { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public List<string> Required { get; set; }

        /// <summary>
        /// Gets or Sets MaxProperties
        /// </summary>
        [DataMember(Name = "maxProperties", EmitDefaultValue = true)]
        public long? MaxProperties { get; set; }

        /// <summary>
        /// Gets or Sets MinProperties
        /// </summary>
        [DataMember(Name = "minProperties", EmitDefaultValue = true)]
        public long? MinProperties { get; set; }

        /// <summary>
        /// Gets or Sets Maximum
        /// </summary>
        [DataMember(Name = "maximum", EmitDefaultValue = true)]
        public decimal? Maximum { get; set; }

        /// <summary>
        /// Gets or Sets Minimum
        /// </summary>
        [DataMember(Name = "minimum", EmitDefaultValue = true)]
        public decimal? Minimum { get; set; }

        /// <summary>
        /// Gets or Sets Nullable
        /// </summary>
        [DataMember(Name = "nullable", EmitDefaultValue = true)]
        public bool? Nullable { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StructuredOutputSchema {\n");
            sb.Append("  AnyOf: ").Append(AnyOf).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Enum: ").Append(Enum).Append("\n");
            sb.Append("  Example: ").Append(Example).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  MaxItems: ").Append(MaxItems).Append("\n");
            sb.Append("  MinItems: ").Append(MinItems).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("  Pattern: ").Append(Pattern).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  PropertyOrdering: ").Append(PropertyOrdering).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  MaxProperties: ").Append(MaxProperties).Append("\n");
            sb.Append("  MinProperties: ").Append(MinProperties).Append("\n");
            sb.Append("  Maximum: ").Append(Maximum).Append("\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
            sb.Append("  Nullable: ").Append(Nullable).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            // MaxItems (long?) minimum
            if (this.MaxItems < (long?)0)
            {
                yield return new ValidationResult("Invalid value for MaxItems, must be a value greater than or equal to 0.", new [] { "MaxItems" });
            }

            // MinItems (long?) minimum
            if (this.MinItems < (long?)0)
            {
                yield return new ValidationResult("Invalid value for MinItems, must be a value greater than or equal to 0.", new [] { "MinItems" });
            }

            // MaxLength (long?) minimum
            if (this.MaxLength < (long?)0)
            {
                yield return new ValidationResult("Invalid value for MaxLength, must be a value greater than or equal to 0.", new [] { "MaxLength" });
            }

            // MinLength (long?) minimum
            if (this.MinLength < (long?)0)
            {
                yield return new ValidationResult("Invalid value for MinLength, must be a value greater than or equal to 0.", new [] { "MinLength" });
            }

            // MaxProperties (long?) minimum
            if (this.MaxProperties < (long?)0)
            {
                yield return new ValidationResult("Invalid value for MaxProperties, must be a value greater than or equal to 0.", new [] { "MaxProperties" });
            }

            // MinProperties (long?) minimum
            if (this.MinProperties < (long?)0)
            {
                yield return new ValidationResult("Invalid value for MinProperties, must be a value greater than or equal to 0.", new [] { "MinProperties" });
            }

            yield break;
        }
    }

}
