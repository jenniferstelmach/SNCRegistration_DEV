using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SNCRegistration_20161025.Models
{
    public class Participant
    {
        //Primary key
        [Required]
        public int ParticipantID { get; set; }

        //foreign key
        [Required]
        public int GuardianID { get; set; }

        [Required]
        public string ParticipantFirstName { get; set; }

        [Required]
        public string ParticipantLastName { get; set; }

        //Age Range from age table
        [Required]
        public int ParticipantAge { get; set; }

        //Attendance key from attendance table
        [Required]
        public int AttendingCode { get; set; }
    
        //Classroom Scouting - Y/N value
        public bool ClassroomScouting { get; set; }

        public string ParticipantSchool { get; set; }

        public string ParticipantTeacher { get; set; }

        //health form receipt status (Y/N)
        public bool HealthForm { get; set; }

        //media permission form receipt status (Y/N)
        public bool PhotoAck { get; set; }

        public string Comments { get; set; }
    }
}