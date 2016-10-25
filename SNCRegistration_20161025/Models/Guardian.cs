using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SNCRegistration_20161025.Models
{
    public class Guardian
    {
        //primary key
        [Required]
        public int GuardianID { get; set; }

        [Required]
        public string GuardianFirstName { get; set; }

        [Required]
        public string GuardianLastName { get; set; }

        //relationship to participant --> TO DO: will this be normalized to look up values?
        public string Relationship { get; set; }

        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        //tent needed is Y/N value
        public bool TentNeeded { get; set; }

        //number of people tent must sleep
        public int TentCount { get; set; }

        //look up from attendance table for value
        public int AttendingCode { get; set; }

        public string Comments { get; set; }

        //records date registered
        //NOTE: replaces "packet sent date"
        [DataType(DataType.DateTime)]
        public DateTime DateRegistered { get; set; }

        //health form receipt status (Y/N)
        public bool HealthForm { get; set; }

        //media permission form receipt status (Y/N)
        public bool PhotoAck { get; set; }

        //records date registration complete confirmation sent (all forms received for self & ALL RELATED attendees)
        //NOTE: replaces "receipt date"
        [DataType(DataType.DateTime)]
        public DateTime DateCompleted { get; set; }

        //records date email confirming completed registration sent (all forms received)
        [DataType(DataType.DateTime)]
        public DateTime DateConfirmSent { get; set; }
        
   
    }
}