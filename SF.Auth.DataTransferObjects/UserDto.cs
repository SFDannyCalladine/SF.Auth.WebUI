﻿using System;

namespace SF.Auth.DataTransferObjects
{
    public class UserDto
    {
        public string Email { get; set; }

        public string Name { get; set; }

        public Guid UserGuid { get; set; }

        public int UserId { get; set; }
    }
}