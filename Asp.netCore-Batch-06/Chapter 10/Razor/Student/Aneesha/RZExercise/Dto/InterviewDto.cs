using RZExercise.Models;

namespace RZExercise.Dto
{
    public class InterviewDto
    {
        public Guid InterviewId { get; set; }

        public Guid ApplyId { get; set; }

        public TimeOnly? InterviewTime { get; set; }

        public DateOnly? InterviewDate { get; set; }

        public string? InterviewNotes { get; set; }

        public virtual Apply? Apply { get; set; }
    }
}
