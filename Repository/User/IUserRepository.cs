namespace GeekHub.Repository.User
{
    public interface IUserRepository
    {
        #region Validations
        internal bool UniqueId(string id);
        internal bool UniqueUsername(string userName);
        internal bool UniqueEmail(string email);
        internal bool IsValidPassword(string password);
        internal bool IsValidUserName(string userName);
        internal bool IsValidEmail(string email);
        #endregion

        #region Lists Service

        #endregion
    }
}
