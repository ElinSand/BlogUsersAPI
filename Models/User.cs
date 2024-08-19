using System.ComponentModel.DataAnnotations.Schema;

namespace BlogUsersAPI.Models
{
    
    
        [Table("AspNetUsers")]
        public class User
        {
            public string Id { get; set; }
            public string NickName { get; set; }
            public string Email { get; set; }
        }
    
}
