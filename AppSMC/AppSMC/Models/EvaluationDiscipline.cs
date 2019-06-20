using System;
using System.Collections.Generic;
using System.Text;

namespace AppSMC.Models
{
    public class EvaluationDiscipline
    {
        public int EvaluationDisciplineId { get; set; }
        public DateTime EvaluationDisciplineDate { get; set; }
        public int Attempt { get; set; }
        public int Takes { get; set; }
        public string Situation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int EvaluationId { get; set; }
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public string CourseName { get; set; }
        public string EvaluationName { get; set; }
        public string DisciplineName { get; set; }
    }
}
