using System;
using BlazorworkShop.Models;

namespace BlazorworkShop.Dtos
{
	public class ApplicationDto
	{
        public Guid Id { get; set; }
        public Guid JobID { get; set; }
        public Guid UserID { get; set; }
        public virtual JobDto? Job { get; set; }

        public ApplicationDto(Guid id, Guid jobID, Guid userID)
		{
            Id = id;
            JobID = jobID;
            UserID = userID;
        }
	}
}

