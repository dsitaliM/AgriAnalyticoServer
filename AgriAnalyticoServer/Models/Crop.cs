using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgriAnalyticoServer.Models
{
    public class Crop
    {
        [Key]
        [Required]
        public Guid CropId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public float AlkalinityLow { get; set; }

        [Required]
        public float AlkalinityHigh { get; set; }

        [Required]
        public float RootDepthLow { get; set; }

        [Required]
        public float RootDepthHigh { get; set; }

        [Required]
        public float MADEstablishment { get; set; }

        [Required]
        public float MADVegetative { get; set; }

        [Required]
        public float MADFlowering { get; set; }

        [Required]
        public float MADMature { get; set; }

    }
}