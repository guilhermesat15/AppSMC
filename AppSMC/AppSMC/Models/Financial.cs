using System;
using System.Collections.Generic;
using System.Text;

namespace AppSMC.Models
{
    public class Financial
    {
        public int FinancialId { get; set; }
        public DateTime FinancialDateExpire { get; set; }
        public DateTime? FinancialDatePayment { get; set; }
        public double FinancialValue { get; set; }
        public int FinancialPortion { get; set; }
        public string Situation { get; set; }
        public string TypePayment { get; set; }
        public int DisciplineId { get; set; }
        public int UserId { get; set; }
        public object Discipline { get; set; }
        public object Users { get; set; }
    }
}
