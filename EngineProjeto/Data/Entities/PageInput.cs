using System;
using System.ComponentModel.DataAnnotations;

namespace EngineProjeto.Data.Entities
{
    public class PageInput
    {

        [Key]
        public int PageID { get; set; }
        [Key]
        public int InputTypeID { get; set; }
        public DateTime CreationTime { get; set; }
        public bool isActive { get; set; }
        public int InputPropertiesID { get; set; }
    }
}
