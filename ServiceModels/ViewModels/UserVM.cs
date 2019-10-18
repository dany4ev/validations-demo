using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace ValidationsDemo.Models
{
    [DataContract]
    public class UserPUT
    {
        [DataMember]
        [Required]
        public int Id { get; set; }

        [DataMember]
        [Required, StringLength(50)]
        public string Name { get; set; }

        [DataMember]
        public string Email { get; set; }
    }

    [DataContract]
    public class UserPOST
    {
        [DataMember]
        [Required, StringLength(50)]
        public string Name { get; set; }
        
        public string Email { get; set; }
    }
}