namespace mini_package_api.Exceptions
{
    [Serializable]
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException() { }

        public UserNotFoundException(string name) : base(string.Format("User with username: {0} not found.", name)) { }
    }
}
