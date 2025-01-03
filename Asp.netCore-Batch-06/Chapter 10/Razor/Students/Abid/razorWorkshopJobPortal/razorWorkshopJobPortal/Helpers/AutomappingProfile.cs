using AutoMapper;
using razorWorkshopJobPortal.DTO;
using razorWorkshopJobPortal.Models;
namespace razorWorkshopJobPortal.Helpers

{
	public class AutomappingProfile : Profile
	{
		public AutomappingProfile()
		{
			CreateMap<userDTO, User>().ReverseMap();

		}

	}
}
