using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriAnalyticoServer.Models
{
    public class Soil
    {
        [Key]
        [Required]
        public Guid SoilId { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public float FieldCapacity { get; set; }

        [Required]
        public float PermanentWiltingPoint { get; set; }

        [Required]
        public float TotalAvailableWater { get; set; }

    }
}