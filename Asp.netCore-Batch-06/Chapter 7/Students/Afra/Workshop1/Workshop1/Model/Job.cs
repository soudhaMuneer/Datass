namespace Workshop1.Model
{
    public class Job
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Experience { get; set; }
        public string Type {  get; set; }
        public long Salary {  get; set; }
        public string CompanyName {  get; set; }
        public string CompanyId {  get; set; }
        public Job() { }
        public Job(int id, string title, string description, string location, string experience, string type, long salary, string companyName, string companyId)
        {
            Id = id;
            Title = title;
            Description = description;
            Location = location;
            Experience = experience;
            Type = type;
            Salary = salary;
            CompanyName = companyName;
            CompanyId = companyId;
        }
    }
}
