namespace CV_RibeiroChristophe.Data
{
    public interface IUserAccountService
    {
        public Task<UserAccountViewModel> GetByLogin(string userLogin);
        public Task<UserAccount> GetUserById(int? id);
        public Task<bool> AddUser(UserAccount user);
        public Task<bool> EditUser(UserAccount user);
        public Task<bool> DeleteUser(UserAccount user);
        public Task<List<UserAccount>> GetListUser();
        public Task<List<Role>> GetListRole();
		public string GetRoleById(int id);
		public Task<string> GetRole(int id);

	}
}
