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
    /// ModifyPassword
    /// </summary>
    [DataContract]
    public partial class ModifyPassword :  IEquatable<ModifyPassword>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyPassword" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModifyPassword() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifyPassword" /> class.
        /// </summary>
        /// <param name="UserId">id of User.</param>
        /// <param name="Password">Password (required).</param>
        /// <param name="CurrentPassword">CurrentPassword (required).</param>
        public ModifyPassword(int? UserId = null, string Password = null, string CurrentPassword = null)
        {
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for ModifyPassword and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
            // to ensure "CurrentPassword" is required (not null)
            if (CurrentPassword == null)
            {
                throw new InvalidDataException("CurrentPassword is a required property for ModifyPassword and cannot be null");
            }
            else
            {
                this.CurrentPassword = CurrentPassword;
            }
            this.UserId = UserId;
        }
        
        /// <summary>
        /// id of User
        /// </summary>
        /// <value>id of User</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// Gets or Sets CurrentPassword
        /// </summary>
        [DataMember(Name="currentPassword", EmitDefaultValue=false)]
        public string CurrentPassword { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyPassword {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  CurrentPassword: ").Append(CurrentPassword).Append("\n");
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
            return this.Equals(obj as ModifyPassword);
        }

        /// <summary>
        /// Returns true if ModifyPassword instances are equal
        /// </summary>
        /// <param name="other">Instance of ModifyPassword to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifyPassword other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.CurrentPassword == other.CurrentPassword ||
                    this.CurrentPassword != null &&
                    this.CurrentPassword.Equals(other.CurrentPassword)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.CurrentPassword != null)
                    hash = hash * 59 + this.CurrentPassword.GetHashCode();
                return hash;
            }
        }
    }

}
