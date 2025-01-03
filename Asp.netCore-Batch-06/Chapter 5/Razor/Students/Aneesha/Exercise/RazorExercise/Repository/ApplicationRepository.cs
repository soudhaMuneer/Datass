using RazorExercise.Model;

namespace RazorExercise.Repository
{
    public class ApplicationRepository
    {
        public static List<Application> App = new List<Application>();

        public bool AddApplication(Application applications)
        {
            App.Add(applications);
            return true;
        }
        public List<Application> GetApplications()
        {
            return App;
        }
    }
}
