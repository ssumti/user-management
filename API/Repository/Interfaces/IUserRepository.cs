using System;
using api.Models;
namespace api.Repository.Interfaces
{
    public interface IUSerRepository
    {
        public void createUser(User user);
        public User getUserByName(string name);
        public User getUSerById(Guid id);
        public void updateUser(User user);
        public void deleteUserByName(string name);
        public void deleteUserById(Guid id);
    }
}