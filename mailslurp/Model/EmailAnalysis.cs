/* 
 * MailSlurp API
 *
 * For documentation see [developer guide](https://www.mailslurp.com/developers). [Create an account](https://app.mailslurp.com) in the MailSlurp Dashboard to [view your API Key](https://app). For all bugs, feature requests, or help please [see support](https://www.mailslurp.com/support/).
 *
 * OpenAPI spec version: 0.0.1-alpha
 * Contact: contact@mailslurp.dev
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
    /// Analysis of email
    /// </summary>
    [DataContract]
    public partial class EmailAnalysis :  IEquatable<EmailAnalysis>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAnalysis" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailAnalysis() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailAnalysis" /> class.
        /// </summary>
        /// <param name="dkimVerdict">dkimVerdict (required).</param>
        /// <param name="dmarcVerdict">dmarcVerdict (required).</param>
        /// <param name="spamVerdict">spamVerdict (required).</param>
        /// <param name="spfVerdict">spfVerdict (required).</param>
        /// <param name="virusVerdict">virusVerdict (required).</param>
        public EmailAnalysis(string dkimVerdict = default(string), string dmarcVerdict = default(string), string spamVerdict = default(string), string spfVerdict = default(string), string virusVerdict = default(string))
        {
            // to ensure "dkimVerdict" is required (not null)
            if (dkimVerdict == null)
            {
                throw new InvalidDataException("dkimVerdict is a required property for EmailAnalysis and cannot be null");
            }
            else
            {
                this.DkimVerdict = dkimVerdict;
            }
            // to ensure "dmarcVerdict" is required (not null)
            if (dmarcVerdict == null)
            {
                throw new InvalidDataException("dmarcVerdict is a required property for EmailAnalysis and cannot be null");
            }
            else
            {
                this.DmarcVerdict = dmarcVerdict;
            }
            // to ensure "spamVerdict" is required (not null)
            if (spamVerdict == null)
            {
                throw new InvalidDataException("spamVerdict is a required property for EmailAnalysis and cannot be null");
            }
            else
            {
                this.SpamVerdict = spamVerdict;
            }
            // to ensure "spfVerdict" is required (not null)
            if (spfVerdict == null)
            {
                throw new InvalidDataException("spfVerdict is a required property for EmailAnalysis and cannot be null");
            }
            else
            {
                this.SpfVerdict = spfVerdict;
            }
            // to ensure "virusVerdict" is required (not null)
            if (virusVerdict == null)
            {
                throw new InvalidDataException("virusVerdict is a required property for EmailAnalysis and cannot be null");
            }
            else
            {
                this.VirusVerdict = virusVerdict;
            }
        }
        
        /// <summary>
        /// Gets or Sets DkimVerdict
        /// </summary>
        [DataMember(Name="dkimVerdict", EmitDefaultValue=false)]
        public string DkimVerdict { get; set; }

        /// <summary>
        /// Gets or Sets DmarcVerdict
        /// </summary>
        [DataMember(Name="dmarcVerdict", EmitDefaultValue=false)]
        public string DmarcVerdict { get; set; }

        /// <summary>
        /// Gets or Sets SpamVerdict
        /// </summary>
        [DataMember(Name="spamVerdict", EmitDefaultValue=false)]
        public string SpamVerdict { get; set; }

        /// <summary>
        /// Gets or Sets SpfVerdict
        /// </summary>
        [DataMember(Name="spfVerdict", EmitDefaultValue=false)]
        public string SpfVerdict { get; set; }

        /// <summary>
        /// Gets or Sets VirusVerdict
        /// </summary>
        [DataMember(Name="virusVerdict", EmitDefaultValue=false)]
        public string VirusVerdict { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailAnalysis {\n");
            sb.Append("  DkimVerdict: ").Append(DkimVerdict).Append("\n");
            sb.Append("  DmarcVerdict: ").Append(DmarcVerdict).Append("\n");
            sb.Append("  SpamVerdict: ").Append(SpamVerdict).Append("\n");
            sb.Append("  SpfVerdict: ").Append(SpfVerdict).Append("\n");
            sb.Append("  VirusVerdict: ").Append(VirusVerdict).Append("\n");
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
            return this.Equals(input as EmailAnalysis);
        }

        /// <summary>
        /// Returns true if EmailAnalysis instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailAnalysis to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailAnalysis input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DkimVerdict == input.DkimVerdict ||
                    (this.DkimVerdict != null &&
                    this.DkimVerdict.Equals(input.DkimVerdict))
                ) && 
                (
                    this.DmarcVerdict == input.DmarcVerdict ||
                    (this.DmarcVerdict != null &&
                    this.DmarcVerdict.Equals(input.DmarcVerdict))
                ) && 
                (
                    this.SpamVerdict == input.SpamVerdict ||
                    (this.SpamVerdict != null &&
                    this.SpamVerdict.Equals(input.SpamVerdict))
                ) && 
                (
                    this.SpfVerdict == input.SpfVerdict ||
                    (this.SpfVerdict != null &&
                    this.SpfVerdict.Equals(input.SpfVerdict))
                ) && 
                (
                    this.VirusVerdict == input.VirusVerdict ||
                    (this.VirusVerdict != null &&
                    this.VirusVerdict.Equals(input.VirusVerdict))
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
                if (this.DkimVerdict != null)
                    hashCode = hashCode * 59 + this.DkimVerdict.GetHashCode();
                if (this.DmarcVerdict != null)
                    hashCode = hashCode * 59 + this.DmarcVerdict.GetHashCode();
                if (this.SpamVerdict != null)
                    hashCode = hashCode * 59 + this.SpamVerdict.GetHashCode();
                if (this.SpfVerdict != null)
                    hashCode = hashCode * 59 + this.SpfVerdict.GetHashCode();
                if (this.VirusVerdict != null)
                    hashCode = hashCode * 59 + this.VirusVerdict.GetHashCode();
                return hashCode;
            }
        }
    }

}