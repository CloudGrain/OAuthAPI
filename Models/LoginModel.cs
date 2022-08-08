using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OAuthV2API.Models
{
    public class LoginModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonIgnore]
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        [JsonIgnore]
        public string RefreshToken { get; set; }
        [JsonIgnore]
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
