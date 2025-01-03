namespace RZExercise.Exceptions
{
    [Serializable]
    public class UserAlreadyExistException : Exception
    {
        public UserAlreadyExistException() { }
        public UserAlreadyExistException(string email) : base(String.Format("User already Exist with this email", email))
        { 

        }
    }
}
