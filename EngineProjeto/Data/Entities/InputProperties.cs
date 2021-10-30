using System.ComponentModel.DataAnnotations;

namespace EngineProjeto.Data.Entities
{
    public class InputProperties
    {
        [Key]
        public int InputPropertiesID { get; set; }
        public bool Mandatory { get; set; }
        public string Label { get; set; }
        public bool ReadOnly { get; set; }
        public int InputStyleID { get; set; }

    }
}
