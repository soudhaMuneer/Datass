﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BlazorworkShop.Models
{
	public class Skill
	{
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public Guid? UserId { get; set; }

        public string? Title { get; set; }

        public string? Status { get; set; }
        [JsonIgnore]
        public virtual User? User { get; set; }
    }
}

