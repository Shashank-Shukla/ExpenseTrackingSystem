using ExpenseTrackingSystem.Models.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTrackingSystem.Models.DatabaseModels
{
    public class ExpenseTransactions
    {
        [Key]
        public int TransactionID { get; set; }
        public int CategoryId { get; set; }
        public ExpenseCategory Category { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        [Column(TypeName = "nvarchar(50)")]
        public TransactionState TransactionState { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string? Note { get; set; } = string.Empty;
    }
}
