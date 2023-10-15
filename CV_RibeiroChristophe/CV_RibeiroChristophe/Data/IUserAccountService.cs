﻿namespace CV_RibeiroChristophe.Data
{
    public interface IUserAccountService
    {
        public Task<UserAccountViewModel> GetByLogin(string userLogin);
        public Task<UserAccount> GetUserById(int? id);
        public Task<bool> AddUser(UserAccount user);
        public Task<List<UserAccount>> GetListUser();
    }
}
