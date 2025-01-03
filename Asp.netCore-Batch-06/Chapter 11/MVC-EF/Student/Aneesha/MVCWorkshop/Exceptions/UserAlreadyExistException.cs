namespace MVCWorkshop.Exceptions
{
    [Serializable]
    public class UserAlreadyExistException:Exception
    {
        public UserAlreadyExistException() { }
        public UserAlreadyExistException(string email) : base("User Already Exist with this email" +email) { }
        public UserAlreadyExistException(string message, Exception innerException) : base(message, innerException) { }
    }
}
