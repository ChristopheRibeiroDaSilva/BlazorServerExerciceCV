namespace CV_RibeiroChristophe.Data
{
    public interface IUserAccountService
    {
        public Task<UserAccount> GetByLogin(UserAccount useraccount);
    }
}
