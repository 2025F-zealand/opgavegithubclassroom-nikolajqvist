﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class Demo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }

        public Demo(string name, string email, string description)
        {
            Name = name;
            Email = email;
            Description = description;
        }
    }
}
