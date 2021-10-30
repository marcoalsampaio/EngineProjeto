using System;
using System.ComponentModel.DataAnnotations;

namespace EngineProjeto.Data.Entities
{
    public class InputType
    {
            [Key]
            public int InputTypeID { get; set; }
            public string InputName { get; set; }
            public DateTime CreationTime { get; set; }
            public bool isActive { get; set; }
    }
}
