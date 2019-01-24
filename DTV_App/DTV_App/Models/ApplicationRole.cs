using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTV_App.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base() {  }

        public ApplicationRole(string RoleName) : base(RoleName)
        {
        }

        public ApplicationRole(string RoleName, string Description, DateTime CreationDate) : base(RoleName)
        {
            this.Description = Description;
            this.CreationDate = CreationDate;
        }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

    }
}
