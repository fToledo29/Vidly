using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VidlyII.Models;

namespace VidlyII.DTOs
{
    public class CustomerDto

    {
        public int Id { get; set; }

        // Overwritten error message
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewstetter { get; set; }
        
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}