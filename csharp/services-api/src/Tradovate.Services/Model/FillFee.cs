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
    /// FillFee
    /// </summary>
    [DataContract]
    public partial class FillFee :  IEquatable<FillFee>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FillFee" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="ClearingFee">ClearingFee.</param>
        /// <param name="ClearingCurrencyId">id of Currency.</param>
        /// <param name="ExchangeFee">ExchangeFee.</param>
        /// <param name="ExchangeCurrencyId">id of Currency.</param>
        /// <param name="NfaFee">NfaFee.</param>
        /// <param name="NfaCurrencyId">id of Currency.</param>
        /// <param name="BrokerageFee">BrokerageFee.</param>
        /// <param name="BrokerageCurrencyId">id of Currency.</param>
        /// <param name="IpFee">IpFee.</param>
        /// <param name="IpCurrencyId">id of Currency.</param>
        public FillFee(int? Id = null, double? ClearingFee = null, int? ClearingCurrencyId = null, double? ExchangeFee = null, int? ExchangeCurrencyId = null, double? NfaFee = null, int? NfaCurrencyId = null, double? BrokerageFee = null, int? BrokerageCurrencyId = null, double? IpFee = null, int? IpCurrencyId = null)
        {
            this.Id = Id;
            this.ClearingFee = ClearingFee;
            this.ClearingCurrencyId = ClearingCurrencyId;
            this.ExchangeFee = ExchangeFee;
            this.ExchangeCurrencyId = ExchangeCurrencyId;
            this.NfaFee = NfaFee;
            this.NfaCurrencyId = NfaCurrencyId;
            this.BrokerageFee = BrokerageFee;
            this.BrokerageCurrencyId = BrokerageCurrencyId;
            this.IpFee = IpFee;
            this.IpCurrencyId = IpCurrencyId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets ClearingFee
        /// </summary>
        [DataMember(Name="clearingFee", EmitDefaultValue=false)]
        public double? ClearingFee { get; set; }
        /// <summary>
        /// id of Currency
        /// </summary>
        /// <value>id of Currency</value>
        [DataMember(Name="clearingCurrencyId", EmitDefaultValue=false)]
        public int? ClearingCurrencyId { get; set; }
        /// <summary>
        /// Gets or Sets ExchangeFee
        /// </summary>
        [DataMember(Name="exchangeFee", EmitDefaultValue=false)]
        public double? ExchangeFee { get; set; }
        /// <summary>
        /// id of Currency
        /// </summary>
        /// <value>id of Currency</value>
        [DataMember(Name="exchangeCurrencyId", EmitDefaultValue=false)]
        public int? ExchangeCurrencyId { get; set; }
        /// <summary>
        /// Gets or Sets NfaFee
        /// </summary>
        [DataMember(Name="nfaFee", EmitDefaultValue=false)]
        public double? NfaFee { get; set; }
        /// <summary>
        /// id of Currency
        /// </summary>
        /// <value>id of Currency</value>
        [DataMember(Name="nfaCurrencyId", EmitDefaultValue=false)]
        public int? NfaCurrencyId { get; set; }
        /// <summary>
        /// Gets or Sets BrokerageFee
        /// </summary>
        [DataMember(Name="brokerageFee", EmitDefaultValue=false)]
        public double? BrokerageFee { get; set; }
        /// <summary>
        /// id of Currency
        /// </summary>
        /// <value>id of Currency</value>
        [DataMember(Name="brokerageCurrencyId", EmitDefaultValue=false)]
        public int? BrokerageCurrencyId { get; set; }
        /// <summary>
        /// Gets or Sets IpFee
        /// </summary>
        [DataMember(Name="ipFee", EmitDefaultValue=false)]
        public double? IpFee { get; set; }
        /// <summary>
        /// id of Currency
        /// </summary>
        /// <value>id of Currency</value>
        [DataMember(Name="ipCurrencyId", EmitDefaultValue=false)]
        public int? IpCurrencyId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FillFee {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ClearingFee: ").Append(ClearingFee).Append("\n");
            sb.Append("  ClearingCurrencyId: ").Append(ClearingCurrencyId).Append("\n");
            sb.Append("  ExchangeFee: ").Append(ExchangeFee).Append("\n");
            sb.Append("  ExchangeCurrencyId: ").Append(ExchangeCurrencyId).Append("\n");
            sb.Append("  NfaFee: ").Append(NfaFee).Append("\n");
            sb.Append("  NfaCurrencyId: ").Append(NfaCurrencyId).Append("\n");
            sb.Append("  BrokerageFee: ").Append(BrokerageFee).Append("\n");
            sb.Append("  BrokerageCurrencyId: ").Append(BrokerageCurrencyId).Append("\n");
            sb.Append("  IpFee: ").Append(IpFee).Append("\n");
            sb.Append("  IpCurrencyId: ").Append(IpCurrencyId).Append("\n");
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
            return this.Equals(obj as FillFee);
        }

        /// <summary>
        /// Returns true if FillFee instances are equal
        /// </summary>
        /// <param name="other">Instance of FillFee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FillFee other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ClearingFee == other.ClearingFee ||
                    this.ClearingFee != null &&
                    this.ClearingFee.Equals(other.ClearingFee)
                ) && 
                (
                    this.ClearingCurrencyId == other.ClearingCurrencyId ||
                    this.ClearingCurrencyId != null &&
                    this.ClearingCurrencyId.Equals(other.ClearingCurrencyId)
                ) && 
                (
                    this.ExchangeFee == other.ExchangeFee ||
                    this.ExchangeFee != null &&
                    this.ExchangeFee.Equals(other.ExchangeFee)
                ) && 
                (
                    this.ExchangeCurrencyId == other.ExchangeCurrencyId ||
                    this.ExchangeCurrencyId != null &&
                    this.ExchangeCurrencyId.Equals(other.ExchangeCurrencyId)
                ) && 
                (
                    this.NfaFee == other.NfaFee ||
                    this.NfaFee != null &&
                    this.NfaFee.Equals(other.NfaFee)
                ) && 
                (
                    this.NfaCurrencyId == other.NfaCurrencyId ||
                    this.NfaCurrencyId != null &&
                    this.NfaCurrencyId.Equals(other.NfaCurrencyId)
                ) && 
                (
                    this.BrokerageFee == other.BrokerageFee ||
                    this.BrokerageFee != null &&
                    this.BrokerageFee.Equals(other.BrokerageFee)
                ) && 
                (
                    this.BrokerageCurrencyId == other.BrokerageCurrencyId ||
                    this.BrokerageCurrencyId != null &&
                    this.BrokerageCurrencyId.Equals(other.BrokerageCurrencyId)
                ) && 
                (
                    this.IpFee == other.IpFee ||
                    this.IpFee != null &&
                    this.IpFee.Equals(other.IpFee)
                ) && 
                (
                    this.IpCurrencyId == other.IpCurrencyId ||
                    this.IpCurrencyId != null &&
                    this.IpCurrencyId.Equals(other.IpCurrencyId)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ClearingFee != null)
                    hash = hash * 59 + this.ClearingFee.GetHashCode();
                if (this.ClearingCurrencyId != null)
                    hash = hash * 59 + this.ClearingCurrencyId.GetHashCode();
                if (this.ExchangeFee != null)
                    hash = hash * 59 + this.ExchangeFee.GetHashCode();
                if (this.ExchangeCurrencyId != null)
                    hash = hash * 59 + this.ExchangeCurrencyId.GetHashCode();
                if (this.NfaFee != null)
                    hash = hash * 59 + this.NfaFee.GetHashCode();
                if (this.NfaCurrencyId != null)
                    hash = hash * 59 + this.NfaCurrencyId.GetHashCode();
                if (this.BrokerageFee != null)
                    hash = hash * 59 + this.BrokerageFee.GetHashCode();
                if (this.BrokerageCurrencyId != null)
                    hash = hash * 59 + this.BrokerageCurrencyId.GetHashCode();
                if (this.IpFee != null)
                    hash = hash * 59 + this.IpFee.GetHashCode();
                if (this.IpCurrencyId != null)
                    hash = hash * 59 + this.IpCurrencyId.GetHashCode();
                return hash;
            }
        }
    }

}