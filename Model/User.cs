using System.Collections.Generic;

namespace dotnet_rpg.Model
{
    public class User
    {
        //Notes: Save a hash value to create a unique password hash
        public int Id { get; set; }

        public string Username { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public List<Character> Characters { get; set; }
    }
}