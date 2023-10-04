namespace CV_RibeiroChristophe.Data
{
    public class UserAccountService : IUserAccountService
    {
        public List<UserAccount> ListUser;
        
        public UserAccountService() { 

            ListUser = new List<UserAccount>
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
        }

        public async Task<UserAccount?> GetByLogin(string userLogin)
        {
            try { 
                UserAccount returnUserAccount =  ListUser.FirstOrDefault(u => u.login == userLogin);
                return returnUserAccount;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
