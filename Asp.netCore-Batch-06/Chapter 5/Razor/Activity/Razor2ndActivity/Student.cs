namespace Razor2ndActivity
{
    public class Student
    {
        public Guid Id { get; set; }=Guid.NewGuid();
        public string Name { get; set; }    
        public string Email  { get; set; }
        public string Image {  get; set; }  
    }
}
