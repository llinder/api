/* 
 * Tradovate API
 *
 * Tradovate API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
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

namespace Tradovate.Services.Model
{
    /// <summary>
    /// TradeTime
    /// </summary>
    [DataContract]
    public partial class TradeTime :  IEquatable<TradeTime>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeTime" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TradeTime() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeTime" /> class.
        /// </summary>
        /// <param name="Hour">Hour (required).</param>
        /// <param name="Minute">Minute (required).</param>
        public TradeTime(int? Hour = null, int? Minute = null)
        {
            // to ensure "Hour" is required (not null)
            if (Hour == null)
            {
                throw new InvalidDataException("Hour is a required property for TradeTime and cannot be null");
            }
            else
            {
                this.Hour = Hour;
            }
            // to ensure "Minute" is required (not null)
            if (Minute == null)
            {
                throw new InvalidDataException("Minute is a required property for TradeTime and cannot be null");
            }
            else
            {
                this.Minute = Minute;
            }
        }
        
        /// <summary>
        /// Gets or Sets Hour
        /// </summary>
        [DataMember(Name="hour", EmitDefaultValue=false)]
        public int? Hour { get; set; }
        /// <summary>
        /// Gets or Sets Minute
        /// </summary>
        [DataMember(Name="minute", EmitDefaultValue=false)]
        public int? Minute { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TradeTime {\n");
            sb.Append("  Hour: ").Append(Hour).Append("\n");
            sb.Append("  Minute: ").Append(Minute).Append("\n");
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
            return this.Equals(obj as TradeTime);
        }

        /// <summary>
        /// Returns true if TradeTime instances are equal
        /// </summary>
        /// <param name="other">Instance of TradeTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeTime other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Hour == other.Hour ||
                    this.Hour != null &&
                    this.Hour.Equals(other.Hour)
                ) && 
                (
                    this.Minute == other.Minute ||
                    this.Minute != null &&
                    this.Minute.Equals(other.Minute)
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
                if (this.Hour != null)
                    hash = hash * 59 + this.Hour.GetHashCode();
                if (this.Minute != null)
                    hash = hash * 59 + this.Minute.GetHashCode();
                return hash;
            }
        }
    }

}