using MVCWorkshop.Exceptions;
using MVCWorkshop.Interfaces;
using MVCWorkshop.Models;

namespace MVCWorkshop.Services
{
    public class PublicService : IPublicService
    {
        public IUserRepository userRepository;
        public PublicService(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }
        public User LoggedUser = new User();
        bool _isLogged = false;
        public User LoginJobSeeker(string email, string password)
        {
            try
            {

                LoggedUser = userRepository.login(email, password);
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

        public User Register(User user)
        {
            return userRepository.register(user);
        }
        public User RegisterAdmin(User user)
        {
            return userRepository.registerAdmin(user);
        }
    }
}

