namespace Activity
{
    class Activity
    {
        static void Main(string[] args)
        {
            JobSeeker seeker = new JobSeeker();
            seeker.FirstName = "Haneesha";
            seeker.LastName = "Rh";

            seeker.Email = "Aneesha@gmail.com";
            seeker.Password = "123";

            seeker.Login("Aneesha@gmail.com", "123");

            seeker.Welcome();

            seeker.ApplyJob(1);
        }
    }
}
