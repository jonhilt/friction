using System;

namespace Friction.WebVS.Models
{
    public class User : Entity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastLogin { get; set; }
    }

    public class Entity
    {
    }
}