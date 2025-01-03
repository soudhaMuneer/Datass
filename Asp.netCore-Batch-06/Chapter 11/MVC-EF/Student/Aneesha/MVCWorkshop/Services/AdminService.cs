using MVCWorkshop.Exceptions;
using MVCWorkshop.Interfaces;
using MVCWorkshop.Models;

namespace MVCWorkshop.Services
{
    public class AdminService : IAdminService
    {
        public bool _isLogged = false;
        public IUserRepository _userRepository;
        public User LoggedUser = new User();

        public AdminService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public User getLoggedUser()
        {
            return _userRepository.getLoggedUser();
        }
        public List<User> JobSeekerListing()
        {

            try
            {
                List<User> list = _userRepository.JobSeekerListing();

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public User LoginAdmin(string email, string password)
            {

            try
            {

                LoggedUser = _userRepository.login(email, password);
                if (LoggedUser.Email != null)
                {
                    Console.WriteLine("Login successful!");
                    _isLogged = true;
                    Console.WriteLine("Welcome " + LoggedUser.FirstName);
                    return LoggedUser;
                }
                else
                {
                    Console.WriteLine("Login failed. Please try again.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new ServiceException("technical error occured");
            }
          }
        public User UpdateProfile(User updatedAdmin)
        {
            try
            {

                return _userRepository.UpdateProfile(updatedAdmin);



            }
            catch (UserAlreadyExistException ex)
            {
                throw ex;
            }
            catch (Exception ex) { throw ex; }
        }
    }

}
