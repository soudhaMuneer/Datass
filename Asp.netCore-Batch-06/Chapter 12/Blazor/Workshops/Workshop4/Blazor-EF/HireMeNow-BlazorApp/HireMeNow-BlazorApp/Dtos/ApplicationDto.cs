using Mvc_HireMeNow.Models;
using Microsoft.Extensions.Hosting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HireMeNow_BlazorApp.Dtos
{
	public class ApplicationDto
	{
		public ApplicationDto(Guid id, Guid jobID, Guid userID)
		{
			Id = id;
			JobID = jobID;
			UserID = userID;
		}

		public Guid Id { get; set; }
		 public Guid JobID { get; set; }
		public Guid UserID { get; set; }
        public virtual JobDto? Job { get; set; }

    }
}
