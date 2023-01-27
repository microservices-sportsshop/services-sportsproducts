﻿using System.ComponentModel.DataAnnotations;

namespace Sports.Data.Dtos
{

    public record ProductAddDto
    {
        public string Sku { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public Guid CategoryId { get; set; }

        [Required]
        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public string? ModifiedBy => CreatedBy;

        public DateTime ModifiedDate => CreatedDate;
    }

}
