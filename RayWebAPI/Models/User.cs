﻿namespace RayWebAPI.Models
{
    public class User : EntityBase
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDay { get; set; }
        public string Mobile { get; set; }
        public int Rank { get; set; }
    }
}