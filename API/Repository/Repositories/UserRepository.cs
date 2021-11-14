using System;
using api.Repository.Interfaces;
using api.Services;
using MongoDB.Driver;
using api.Models;

namespace api.Repository.Repositories
{
    public class UserRepository : IUSerRepository
    {
        public void createUser(User user)
        {
            MongoContext context = new MongoContext("User");
            var collection = context.db.GetCollection<User>()
        }
        public User getUserByName(string name)
        {

        }
        public User getUSerById(Guid id)
        {

        }
        public void updateUser(User user)
        {

        }
        public void deleteUserByName(string name)
        {

        }
        public void deleteUserById(Guid id)
        {

        }
    }
}