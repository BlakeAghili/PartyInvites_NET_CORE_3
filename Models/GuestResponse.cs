using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Your Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please Say You Coming Or Not?")]
        public bool? WillAttend { get; set; }
    }
}
