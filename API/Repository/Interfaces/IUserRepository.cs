using System;
using api.Models;
namespace api.Repository.Interfaces
{
    public interface IUserRepository
    {
        public void createUser(User user);
        public User getUserByName(string name);
        public User getUserById(Guid id);
        public void updateUser(User user, Guid id);
        public void deleteUserByName(string name);
        public void deleteUserById(Guid id);
    }
}