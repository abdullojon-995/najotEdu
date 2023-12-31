﻿using NajotTalim.Domain.Enums;

namespace NajotTalim.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string PasswordHash { get; set; }
        public UserRole Role { get; set; }
        public string? PhotoPath { get; set; }

        public ICollection<Group> Groups { get; set; }
    }
}
