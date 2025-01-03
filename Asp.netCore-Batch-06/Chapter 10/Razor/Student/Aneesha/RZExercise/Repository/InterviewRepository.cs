using Microsoft.VisualBasic;
using RZExercise.DAL;
using RZExercise.Interface;
using RZExercise.Models;

namespace RZExercise.Repository
{
    public class InterviewRepository : IInterviewRepo
    {
        private SeekerDBContext _dbContext;
        public Interview Interview =  new Interview();
        public List<Interview> Interviews = new List<Interview>();
        
        public void AddInterview(Apply apply)
        {
            var newInterview = new Interview()
            {
                ApplyId = apply.ApplyId
            };

            _dbContext.Interviews.Add(newInterview);
            _dbContext.SaveChanges();
        }

        public void DeleteInterview(Guid id)
        {
            var interview = _dbContext.Interviews.FirstOrDefault(e => e.InterviewId == id);

            if (interview != null)
            {
                _dbContext.Interviews.Remove(interview);
                _dbContext.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Interview not found");
            }
        }
        public List<Interview> GetAll()
        {
            return _dbContext.Interviews.ToList();
        }
        public Interview GetById(Guid id)
        {
            return _dbContext.Interviews.FirstOrDefault(e => e.InterviewId == id);
        }
    }
}
