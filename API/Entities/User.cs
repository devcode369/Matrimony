using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{

    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? UserName { get; set; }
    }
}