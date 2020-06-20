using System;
using Fennec.Server.Domain.Enums;

namespace Fennec.Server.Domain.Entites
{
    public class RegisteredUser
    {
        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }
        public string IsBanned { get; private set; }
        public UserType UserType { get; private set; }
        
    }
}