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
    /// UserAccountAutoLiq
    /// </summary>
    [DataContract]
    public partial class UserAccountAutoLiq :  IEquatable<UserAccountAutoLiq>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAccountAutoLiq" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="MarginPercentageAlert">Margin % for an Alert.</param>
        /// <param name="DailyLossPercentageAlert">Daily Loss % for an Alert.</param>
        /// <param name="DailyLossAlert">$ Daily Loss for an Alert.</param>
        /// <param name="MarginPercentageLiqOnly">Margin % for an Liq Only.</param>
        /// <param name="DailyLossPercentageLiqOnly">Daily Loss % for an Liq Only.</param>
        /// <param name="DailyLossLiqOnly">$ Daily Loss for an Liq Only.</param>
        /// <param name="MarginPercentageAutoLiq">Margin % for an Auto-Liq.</param>
        /// <param name="DailyLossPercentageAutoLiq">Daily Loss % for an AutoLiq.</param>
        /// <param name="DailyLossAutoLiq">$ Daily Loss for an Auto-Liq.</param>
        /// <param name="WeeklyLossAutoLiq">$ Weekly Loss for an Auto-Liq.</param>
        /// <param name="FlattenTimestamp">Flatten &amp;amp; Cancel.</param>
        /// <param name="TrailingMaxDrawdown">$ Trailing Max Drawdown.</param>
        /// <param name="TrailingMaxDrawdownLimit">$ Trailing Max Drawdown Limit.</param>
        public UserAccountAutoLiq(int? Id = null, double? MarginPercentageAlert = null, double? DailyLossPercentageAlert = null, double? DailyLossAlert = null, double? MarginPercentageLiqOnly = null, double? DailyLossPercentageLiqOnly = null, double? DailyLossLiqOnly = null, double? MarginPercentageAutoLiq = null, double? DailyLossPercentageAutoLiq = null, double? DailyLossAutoLiq = null, double? WeeklyLossAutoLiq = null, DateTime? FlattenTimestamp = null, double? TrailingMaxDrawdown = null, double? TrailingMaxDrawdownLimit = null)
        {
            this.Id = Id;
            this.MarginPercentageAlert = MarginPercentageAlert;
            this.DailyLossPercentageAlert = DailyLossPercentageAlert;
            this.DailyLossAlert = DailyLossAlert;
            this.MarginPercentageLiqOnly = MarginPercentageLiqOnly;
            this.DailyLossPercentageLiqOnly = DailyLossPercentageLiqOnly;
            this.DailyLossLiqOnly = DailyLossLiqOnly;
            this.MarginPercentageAutoLiq = MarginPercentageAutoLiq;
            this.DailyLossPercentageAutoLiq = DailyLossPercentageAutoLiq;
            this.DailyLossAutoLiq = DailyLossAutoLiq;
            this.WeeklyLossAutoLiq = WeeklyLossAutoLiq;
            this.FlattenTimestamp = FlattenTimestamp;
            this.TrailingMaxDrawdown = TrailingMaxDrawdown;
            this.TrailingMaxDrawdownLimit = TrailingMaxDrawdownLimit;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Margin % for an Alert
        /// </summary>
        /// <value>Margin % for an Alert</value>
        [DataMember(Name="marginPercentageAlert", EmitDefaultValue=false)]
        public double? MarginPercentageAlert { get; set; }
        /// <summary>
        /// Daily Loss % for an Alert
        /// </summary>
        /// <value>Daily Loss % for an Alert</value>
        [DataMember(Name="dailyLossPercentageAlert", EmitDefaultValue=false)]
        public double? DailyLossPercentageAlert { get; set; }
        /// <summary>
        /// $ Daily Loss for an Alert
        /// </summary>
        /// <value>$ Daily Loss for an Alert</value>
        [DataMember(Name="dailyLossAlert", EmitDefaultValue=false)]
        public double? DailyLossAlert { get; set; }
        /// <summary>
        /// Margin % for an Liq Only
        /// </summary>
        /// <value>Margin % for an Liq Only</value>
        [DataMember(Name="marginPercentageLiqOnly", EmitDefaultValue=false)]
        public double? MarginPercentageLiqOnly { get; set; }
        /// <summary>
        /// Daily Loss % for an Liq Only
        /// </summary>
        /// <value>Daily Loss % for an Liq Only</value>
        [DataMember(Name="dailyLossPercentageLiqOnly", EmitDefaultValue=false)]
        public double? DailyLossPercentageLiqOnly { get; set; }
        /// <summary>
        /// $ Daily Loss for an Liq Only
        /// </summary>
        /// <value>$ Daily Loss for an Liq Only</value>
        [DataMember(Name="dailyLossLiqOnly", EmitDefaultValue=false)]
        public double? DailyLossLiqOnly { get; set; }
        /// <summary>
        /// Margin % for an Auto-Liq
        /// </summary>
        /// <value>Margin % for an Auto-Liq</value>
        [DataMember(Name="marginPercentageAutoLiq", EmitDefaultValue=false)]
        public double? MarginPercentageAutoLiq { get; set; }
        /// <summary>
        /// Daily Loss % for an AutoLiq
        /// </summary>
        /// <value>Daily Loss % for an AutoLiq</value>
        [DataMember(Name="dailyLossPercentageAutoLiq", EmitDefaultValue=false)]
        public double? DailyLossPercentageAutoLiq { get; set; }
        /// <summary>
        /// $ Daily Loss for an Auto-Liq
        /// </summary>
        /// <value>$ Daily Loss for an Auto-Liq</value>
        [DataMember(Name="dailyLossAutoLiq", EmitDefaultValue=false)]
        public double? DailyLossAutoLiq { get; set; }
        /// <summary>
        /// $ Weekly Loss for an Auto-Liq
        /// </summary>
        /// <value>$ Weekly Loss for an Auto-Liq</value>
        [DataMember(Name="weeklyLossAutoLiq", EmitDefaultValue=false)]
        public double? WeeklyLossAutoLiq { get; set; }
        /// <summary>
        /// Flatten &amp;amp; Cancel
        /// </summary>
        /// <value>Flatten &amp;amp; Cancel</value>
        [DataMember(Name="flattenTimestamp", EmitDefaultValue=false)]
        public DateTime? FlattenTimestamp { get; set; }
        /// <summary>
        /// $ Trailing Max Drawdown
        /// </summary>
        /// <value>$ Trailing Max Drawdown</value>
        [DataMember(Name="trailingMaxDrawdown", EmitDefaultValue=false)]
        public double? TrailingMaxDrawdown { get; set; }
        /// <summary>
        /// $ Trailing Max Drawdown Limit
        /// </summary>
        /// <value>$ Trailing Max Drawdown Limit</value>
        [DataMember(Name="trailingMaxDrawdownLimit", EmitDefaultValue=false)]
        public double? TrailingMaxDrawdownLimit { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAccountAutoLiq {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MarginPercentageAlert: ").Append(MarginPercentageAlert).Append("\n");
            sb.Append("  DailyLossPercentageAlert: ").Append(DailyLossPercentageAlert).Append("\n");
            sb.Append("  DailyLossAlert: ").Append(DailyLossAlert).Append("\n");
            sb.Append("  MarginPercentageLiqOnly: ").Append(MarginPercentageLiqOnly).Append("\n");
            sb.Append("  DailyLossPercentageLiqOnly: ").Append(DailyLossPercentageLiqOnly).Append("\n");
            sb.Append("  DailyLossLiqOnly: ").Append(DailyLossLiqOnly).Append("\n");
            sb.Append("  MarginPercentageAutoLiq: ").Append(MarginPercentageAutoLiq).Append("\n");
            sb.Append("  DailyLossPercentageAutoLiq: ").Append(DailyLossPercentageAutoLiq).Append("\n");
            sb.Append("  DailyLossAutoLiq: ").Append(DailyLossAutoLiq).Append("\n");
            sb.Append("  WeeklyLossAutoLiq: ").Append(WeeklyLossAutoLiq).Append("\n");
            sb.Append("  FlattenTimestamp: ").Append(FlattenTimestamp).Append("\n");
            sb.Append("  TrailingMaxDrawdown: ").Append(TrailingMaxDrawdown).Append("\n");
            sb.Append("  TrailingMaxDrawdownLimit: ").Append(TrailingMaxDrawdownLimit).Append("\n");
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
            return this.Equals(obj as UserAccountAutoLiq);
        }

        /// <summary>
        /// Returns true if UserAccountAutoLiq instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAccountAutoLiq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAccountAutoLiq other)
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
                    this.MarginPercentageAlert == other.MarginPercentageAlert ||
                    this.MarginPercentageAlert != null &&
                    this.MarginPercentageAlert.Equals(other.MarginPercentageAlert)
                ) && 
                (
                    this.DailyLossPercentageAlert == other.DailyLossPercentageAlert ||
                    this.DailyLossPercentageAlert != null &&
                    this.DailyLossPercentageAlert.Equals(other.DailyLossPercentageAlert)
                ) && 
                (
                    this.DailyLossAlert == other.DailyLossAlert ||
                    this.DailyLossAlert != null &&
                    this.DailyLossAlert.Equals(other.DailyLossAlert)
                ) && 
                (
                    this.MarginPercentageLiqOnly == other.MarginPercentageLiqOnly ||
                    this.MarginPercentageLiqOnly != null &&
                    this.MarginPercentageLiqOnly.Equals(other.MarginPercentageLiqOnly)
                ) && 
                (
                    this.DailyLossPercentageLiqOnly == other.DailyLossPercentageLiqOnly ||
                    this.DailyLossPercentageLiqOnly != null &&
                    this.DailyLossPercentageLiqOnly.Equals(other.DailyLossPercentageLiqOnly)
                ) && 
                (
                    this.DailyLossLiqOnly == other.DailyLossLiqOnly ||
                    this.DailyLossLiqOnly != null &&
                    this.DailyLossLiqOnly.Equals(other.DailyLossLiqOnly)
                ) && 
                (
                    this.MarginPercentageAutoLiq == other.MarginPercentageAutoLiq ||
                    this.MarginPercentageAutoLiq != null &&
                    this.MarginPercentageAutoLiq.Equals(other.MarginPercentageAutoLiq)
                ) && 
                (
                    this.DailyLossPercentageAutoLiq == other.DailyLossPercentageAutoLiq ||
                    this.DailyLossPercentageAutoLiq != null &&
                    this.DailyLossPercentageAutoLiq.Equals(other.DailyLossPercentageAutoLiq)
                ) && 
                (
                    this.DailyLossAutoLiq == other.DailyLossAutoLiq ||
                    this.DailyLossAutoLiq != null &&
                    this.DailyLossAutoLiq.Equals(other.DailyLossAutoLiq)
                ) && 
                (
                    this.WeeklyLossAutoLiq == other.WeeklyLossAutoLiq ||
                    this.WeeklyLossAutoLiq != null &&
                    this.WeeklyLossAutoLiq.Equals(other.WeeklyLossAutoLiq)
                ) && 
                (
                    this.FlattenTimestamp == other.FlattenTimestamp ||
                    this.FlattenTimestamp != null &&
                    this.FlattenTimestamp.Equals(other.FlattenTimestamp)
                ) && 
                (
                    this.TrailingMaxDrawdown == other.TrailingMaxDrawdown ||
                    this.TrailingMaxDrawdown != null &&
                    this.TrailingMaxDrawdown.Equals(other.TrailingMaxDrawdown)
                ) && 
                (
                    this.TrailingMaxDrawdownLimit == other.TrailingMaxDrawdownLimit ||
                    this.TrailingMaxDrawdownLimit != null &&
                    this.TrailingMaxDrawdownLimit.Equals(other.TrailingMaxDrawdownLimit)
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
                if (this.MarginPercentageAlert != null)
                    hash = hash * 59 + this.MarginPercentageAlert.GetHashCode();
                if (this.DailyLossPercentageAlert != null)
                    hash = hash * 59 + this.DailyLossPercentageAlert.GetHashCode();
                if (this.DailyLossAlert != null)
                    hash = hash * 59 + this.DailyLossAlert.GetHashCode();
                if (this.MarginPercentageLiqOnly != null)
                    hash = hash * 59 + this.MarginPercentageLiqOnly.GetHashCode();
                if (this.DailyLossPercentageLiqOnly != null)
                    hash = hash * 59 + this.DailyLossPercentageLiqOnly.GetHashCode();
                if (this.DailyLossLiqOnly != null)
                    hash = hash * 59 + this.DailyLossLiqOnly.GetHashCode();
                if (this.MarginPercentageAutoLiq != null)
                    hash = hash * 59 + this.MarginPercentageAutoLiq.GetHashCode();
                if (this.DailyLossPercentageAutoLiq != null)
                    hash = hash * 59 + this.DailyLossPercentageAutoLiq.GetHashCode();
                if (this.DailyLossAutoLiq != null)
                    hash = hash * 59 + this.DailyLossAutoLiq.GetHashCode();
                if (this.WeeklyLossAutoLiq != null)
                    hash = hash * 59 + this.WeeklyLossAutoLiq.GetHashCode();
                if (this.FlattenTimestamp != null)
                    hash = hash * 59 + this.FlattenTimestamp.GetHashCode();
                if (this.TrailingMaxDrawdown != null)
                    hash = hash * 59 + this.TrailingMaxDrawdown.GetHashCode();
                if (this.TrailingMaxDrawdownLimit != null)
                    hash = hash * 59 + this.TrailingMaxDrawdownLimit.GetHashCode();
                return hash;
            }
        }
    }

}
