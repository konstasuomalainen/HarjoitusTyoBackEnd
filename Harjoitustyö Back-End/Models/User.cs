﻿using System.ComponentModel.DataAnnotations;

namespace HarjoitusTyoBackEnd.Models
{
    public class User
    {

        public long Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(255)]

        public string? UserName { get; set; }
        [Required]
        [MaxLength(255)]

        public string Password { get; set; }
        public byte[]? Salt { get; set; }    
        [MaxLength(255)]


        public string? FirstName { get; set; }
        [MaxLength(255)]

        public string? LastName { get; set; }

        public DateTime? JoinDate { get; set; }

        public DateTime? LastJoinDate { get; set; }


    }

    public class UserDTO
    {

      

        public string UserName { get; set; }
        [MaxLength(255)]


        public string? FirstName { get; set; }
        [MaxLength(255)]

        public string? LastName { get; set; }

        public DateTime? JoinDate { get; set; }

        public DateTime? LastJoinDate { get; set; }


    }
}
