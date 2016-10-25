using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SNCRegistration_20161025.Models
{
    public class FamilyMember
    {
        //primary key
        [Required]
        public int FamilyMemberID { get; set; }

        //foreign key
        [Required]
        public int GuardianID { get; set; }

        [Required]
        public string FamilyFirstName { get; set; }

        [Required]
        public string FamilyLastName { get; set; }

        [Required]
        public int FamilyMemberAge { get; set; }

        [Required]
        public string AttendingCode { get; set; }

        //health form receipt status (Y/N)
        public bool HealthForm { get; set; }

        //media permission form receipt status (Y/N)
        public bool PhotoAck { get; set; }

        public string  Comments { get; set; }
    }
}