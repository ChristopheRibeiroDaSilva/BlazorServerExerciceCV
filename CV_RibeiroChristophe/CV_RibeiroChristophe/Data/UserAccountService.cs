namespace CV_RibeiroChristophe.Data
{
	public class UserAccountService : IUserAccountService
	{
        public List<UserAccount> ListUser = new List<UserAccount>();

        public UserAccountService() {

			ListUser.Add(new UserAccount
			{
				Id = 1,
				login = "admin",
				password = "admin",
                role = "admin"
            });

			ListUser.Add(new UserAccount
			{
				Id = 2,
				login = "guest",
				password = "guest",
				role = "guest"
            });
            
        }


        public Task<UserAccount> GetByLogin(string userLogin)
        {
            UserAccount? returnUserAccount;

            try
            {
                returnUserAccount = ListUser.FirstOrDefault(u => u.login == userLogin);
                if (returnUserAccount == null)
                {
                    returnUserAccount = new UserAccount();

                    return Task.FromResult(returnUserAccount);
                }
                return Task.FromResult(returnUserAccount);
            }
            catch (Exception)
            {
                returnUserAccount = new UserAccount();
                return Task.FromResult(returnUserAccount);
            }
        }

        public Task<UserAccount> GetUserById(int? id)
        {
            UserAccount? returnUserAccount;

            try
            {
                returnUserAccount = ListUser.FirstOrDefault(u => u.Id == id);
                if (returnUserAccount == null)
                {
                    returnUserAccount = new UserAccount();

                    return Task.FromResult(returnUserAccount);
                }
                return Task.FromResult(returnUserAccount);
            }
            catch (Exception)
            {
                returnUserAccount = new UserAccount();
                return Task.FromResult(returnUserAccount);
            }
        }

        public Task<bool> AddUser(UserAccount user)
		{
			try
			{
                user.Id = ListUser.Count + 1;
				ListUser.Add(user);

				return Task.FromResult(true);
			}
			catch (Exception ex)
			{
				return Task.FromResult(false);
			}
		}

		public Task<List<UserAccount>> GetListUser()
		{

            List<UserAccount> ListUsers = new List<UserAccount>();

            try
			{
				ListUsers = ListUser;
				return Task.FromResult(ListUsers);
			}
			catch
			{
                ListUsers.Clear();
			}
            return Task.FromResult(ListUsers);
        }

    }
}
