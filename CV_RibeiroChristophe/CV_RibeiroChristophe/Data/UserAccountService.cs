using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;

namespace CV_RibeiroChristophe.Data
{
	public class UserAccountService : IUserAccountService
	{
        public List<UserAccount> ListUser = new List<UserAccount>();
        public List<Role> ListRole = new List<Role>();

        public UserAccountService() {

			ListUser.Add(new UserAccount
			{
				Id = 1,
                login = "admin",
                password = "admin",
                roleId = 1

            });

            ListUser.Add(new UserAccount
            {
                Id = 2,
                login = "guest",
                password = "guest",
                roleId = 2
            });

            ListRole.Add(new Role
            {
                roleId = 2,
                name = "guest"
            }); ListRole.Add(new Role
            {
                roleId = 1,
                name = "admin"
            });

        }

        public Task<UserAccountViewModel> GetByLogin(string userLogin)
        {
            UserAccount? UserAccount;
            UserAccountViewModel returnUserAccount = new UserAccountViewModel();

            try
            {
                UserAccount = ListUser.FirstOrDefault(u => u.login == userLogin);
                if (UserAccount == null)
                {
                    returnUserAccount = new UserAccountViewModel();

                    return Task.FromResult(returnUserAccount);
                }
                returnUserAccount.Id = UserAccount.Id;
                returnUserAccount.login = UserAccount.login;
                returnUserAccount.password = UserAccount.password;
                returnUserAccount.roleName = GetRoleById(UserAccount.roleId);

                return Task.FromResult(returnUserAccount);
            }
            catch (Exception)
            {
                returnUserAccount = new UserAccountViewModel();
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
        public Task<bool> EditUser(UserAccount user)
        {
            
            try
            {
                var oldUser = ListUser.FirstOrDefault(u => u.Id == user.Id);

                ListUser.Remove(oldUser);

                oldUser.Id = user.Id;
                oldUser.roleId = user.roleId;
                oldUser.login = user.login;
                oldUser.password = user.password;

                ListUser.Add(oldUser);

                return Task.FromResult(true);
            }
            catch (Exception ex)
            {
                return Task.FromResult(false);
            }
        }
        public Task<bool> DeleteUser(UserAccount user)
        {
            try
            {
                ListUser.Remove(user);

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

        public Task<List<Role>> GetListRole()
        {
            try { 
            return Task.FromResult(ListRole);
            }
            catch
            {
                ListRole = new List<Role>();
                return Task.FromResult(ListRole);
            }
        }


		public string GetRoleById(int id)
		{

			try
			{

				return ListRole.FirstOrDefault(u => u.roleId == id).name;
			}
			catch
			{
				return null;
			}
		}
		public Task<string> GetRole(int id)
		{

			try
			{

				return Task.FromResult(ListRole.FirstOrDefault(u => u.roleId == id).name);
			}
			catch
			{
				return null;
			}
		}

	}
}
