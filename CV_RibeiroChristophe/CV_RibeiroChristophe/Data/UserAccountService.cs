namespace CV_RibeiroChristophe.Data
{
    public class UserAccountService : IUserAccountService
    {
        public List<UserAccount> ListUser = new List<UserAccount>
        { 
            new UserAccount{
            login = "admin",
            password = "admin",
            role = "admin"},
            new UserAccount
            {
                login = "guest",
                password = "guest",
                role = "guest"
            }
        };

        public Task<UserAccount> GetByLogin(UserAccount userAccount)
        {
            UserAccount returnUserAccount = ListUser.FirstOrDefault(u => u.login == userAccount.login);
            return Task.FromResult(returnUserAccount);
        }

        /*public Task<UserAccount> GetByLogin(UserAccount useraccount)
        {
            throw new NotImplementedException();
        }*/
    }
}
