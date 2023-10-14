namespace CV_RibeiroChristophe.Data
{
    public interface IUserAccountService
    {
		public Task<UserAccount?> GetByLogin(string userLogin);
        public bool AddUser(string userLogin, string userPassword, string userRole);
        public Task<List<UserAccount>> GetListUser();
    }
}
