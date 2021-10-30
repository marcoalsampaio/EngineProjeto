using System.ComponentModel.DataAnnotations;

namespace EngineProjeto.Data.Entities
{
    public class InputStyle
    {
        [Key]
        public int InputStyleID { get; set; }
        public string Color { get; set; }
        public string Aligh { get; set; }
        public string TextColor { get; set; }
        public string Font { get; set; }
        public int FontSize { get; set; }

    }
}
