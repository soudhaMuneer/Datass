using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models;

public partial class User
{
	[Key]
	[Required]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public Guid Id { get; set; }= Guid.NewGuid();

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }
    [EmailAddress]
    public string? Email { get; set; } = null!;
	
	public string Phone { get; set; } = null!;

    public byte[]? Image { get; set; } = null!;
    public string? ConnectionId { get; set; } 
    public bool IsOnline { get; set; } =false;
    public string ? Address { get; set; }
    public Role? Role { get; set; }
    public DateTime? Accountcreated { get; set; }

}
