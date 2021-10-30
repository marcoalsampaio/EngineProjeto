using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EngineProjeto.Data.Entities
{
    [Keyless]
    public class Teste
    {
       
        public string InputName { get; set; }
        public bool isActive { get; set; }
        public bool Mandatory { get; set; }
        public string Label { get; set; }
        public bool ReadOnly { get; set; }
        public string Color { get; set; }
        public string TextColor { get; set; }
        public string Font { get; set; }
        public int FontSize { get; set; }
        public string align { get; set; }

    }
}
