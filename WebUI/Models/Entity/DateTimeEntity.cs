using System;
using System.ComponentModel.DataAnnotations;

namespace WebUI.Models.Entity
{
    public class DateTimeEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime Value { get; set; }
    }
}