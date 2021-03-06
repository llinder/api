/* 
 * Tradovate API
 *
 * Tradovate API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Tradovate.Services.Model
{
    /// <summary>
    /// UnsubscribeHistogram
    /// </summary>
    [DataContract]
    public partial class UnsubscribeHistogram :  IEquatable<UnsubscribeHistogram>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnsubscribeHistogram" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnsubscribeHistogram() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnsubscribeHistogram" /> class.
        /// </summary>
        /// <param name="Symbol">Symbol (required).</param>
        public UnsubscribeHistogram(string Symbol = default(string))
        {
            // to ensure "Symbol" is required (not null)
            if (Symbol == null)
            {
                throw new InvalidDataException("Symbol is a required property for UnsubscribeHistogram and cannot be null");
            }
            else
            {
                this.Symbol = Symbol;
            }
        }
        
        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnsubscribeHistogram {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as UnsubscribeHistogram);
        }

        /// <summary>
        /// Returns true if UnsubscribeHistogram instances are equal
        /// </summary>
        /// <param name="other">Instance of UnsubscribeHistogram to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnsubscribeHistogram other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Symbol == other.Symbol ||
                    this.Symbol != null &&
                    this.Symbol.Equals(other.Symbol)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Symbol != null)
                    hash = hash * 59 + this.Symbol.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
