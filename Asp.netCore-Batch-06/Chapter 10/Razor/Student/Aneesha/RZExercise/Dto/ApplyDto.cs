namespace RZExercise.Dto
{
    public class ApplyDto
    {
        public Guid ApplyId { get; set; }

        public Guid UserId { get; set; }

        public Guid JobId { get; set; }

        public string? Resume { get; set; }

        public string? CoverLetter { get; set; }

        public DateTime? AppliedDate { get; set; }
    }
}
