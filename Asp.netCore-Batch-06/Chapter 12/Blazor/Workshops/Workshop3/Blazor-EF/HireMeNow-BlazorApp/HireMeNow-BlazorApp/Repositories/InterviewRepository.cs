using HireMeNow_BlazorApp.Interfaces;
using HireMeNow_BlazorApp.Models;
using Microsoft.EntityFrameworkCore;
using Mvc_HireMeNow.Models;

namespace HireMeNow_BlazorApp.Repositories
{
	public class InterviewRepository : IInterviewRepository
	{
        HireMeNowDbContext _context = new HireMeNowDbContext();

        public InterviewRepository(HireMeNowDbContext context)
        {
            _context = context;
        }

        public Interview shduleInterview(Interview interview)
		{
			interview.Id = Guid.NewGuid();
			
			_context.Interviews.Add(interview);
			_context.SaveChanges();
			return interview;
			
		}
		public List<Interview> sheduledInterviewList(Guid CmpId)
		{

			var shedule = _context.Interviews.Where(e => e.CompanyId == CmpId).Include(e=>e.Job).ToList();
			return shedule;

		}
		public void removeInterview(Guid id)
		{
			Interview interview = _context.Interviews.FirstOrDefault(e => e.Id == id);
			if(interview!=null)
			{
				_context.Interviews.Remove(interview);
				_context.SaveChanges();
			}
			
		}

	}
}
