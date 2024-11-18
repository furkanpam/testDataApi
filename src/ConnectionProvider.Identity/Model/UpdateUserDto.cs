﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionProvider.Identity.Model
{
    public class UpdateUserDto
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long DepartmentId { get; set; }
        public long JobTitleId { get; set; }
        public long RoleId { get; set; }
        public long UserStatusId { get; set; }
        public long UpdatedUserId { get; set; }
        public bool AdminFlag { get; set; }
        public int? IncorrectPinCount { get; set; }
    }
}
