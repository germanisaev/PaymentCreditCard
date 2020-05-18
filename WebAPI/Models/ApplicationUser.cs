
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Column(TypeName ="nvarchar(100)")]
        public string CardOwnerName { get; set; }
    }
}
