using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace EngineProjeto.Data
{
    public class Pages
    {
        [Key]
        public int PageID { get; set; }
        public string PageName { get; set; }
        public DateTime CreationTime { get; set; }
        public bool isActive { get; set; }
        public bool isVisible { get; set; }
    }
}
