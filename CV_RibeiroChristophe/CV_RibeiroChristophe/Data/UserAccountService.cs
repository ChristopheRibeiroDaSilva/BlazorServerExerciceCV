namespace CV_RibeiroChristophe.Data
{
	public class UserAccountService : IUserAccountService
	{
		public List<UserAccount> ListUser;

		public UserAccountService() {

			ListUser = new List<UserAccount>
			{
				new UserAccount{
					Id = 1,
				login = "admin",
				password = "admin",
				role = "admin"},
				new UserAccount
				{
					Id = 2,
					login = "guest",
					password = "guest",
					role = "guest"
				}
			};
		}

		public async Task<UserAccount?> GetByLogin(string userLogin)
		{
			try
			{
				UserAccount returnUserAccount = ListUser.FirstOrDefault(u => u.login == userLogin);
				return returnUserAccount;
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public bool AddUser(string userLogin, string userPassword, string userRole)
		{
			try
			{
				UserAccount newUser = new UserAccount();
				newUser.Id = ListUser.Count + 1;
				newUser.login = userLogin;
				newUser.password = userPassword;
				newUser.role = userRole;

				ListUser.Add(newUser);

				return true;
			}
			catch (Exception ex)
			{
				return false;
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
				return null;
			}
        }

    }
}
