using System;
using api.Repository.Interfaces;
using api.Services;
using MongoDB.Driver;
using api.Models;

namespace api.Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        public void createUser(User user)
        {
            MongoContext context = new MongoContext("testdb");
            try
            {
                var collection = context.db.GetCollection<User>("User");
                collection.InsertOne(user);
            }
            catch (Exception)
            {
                context.db.CreateCollection("User");
                var collection = context.db.GetCollection<User>("User");
                collection.InsertOne(user);
            }

        }
        public User getUserByName(string name)
        {
            MongoContext context = new MongoContext("testdb");
            try
            {
                var collection = context.db.GetCollection<User>("User");
                var target = Builders<User>.Filter.Eq("Name", name);
                return collection.Find(target).FirstOrDefault();
            }
            catch (Exception)
            {
                context.db.CreateCollection("User");
                var collection = context.db.GetCollection<User>("User");
                var target = Builders<User>.Filter.Eq("Name", name);
                return collection.Find(target).FirstOrDefault();
            }
        }
        public User getUserById(Guid id)
        {
            MongoContext context = new MongoContext("testdb");
            try
            {
                var collection = context.db.GetCollection<User>("User");
                var target = Builders<User>.Filter.Eq("Id", id);
                return collection.Find(target).FirstOrDefault();
            }
            catch (Exception)
            {
                context.db.CreateCollection("User");
                var collection = context.db.GetCollection<User>("User");
                var target = Builders<User>.Filter.Eq("Id", id);
                return collection.Find(target).FirstOrDefault();
            }
        }
        public void updateUser(User user, Guid id)
        {
            MongoContext context = new MongoContext("testdb");
            try
            {
                var collection = context.db.GetCollection<User>("User");
                var target = Builders<User>.Filter.Eq("Id", id);
                collection.ReplaceOne(target, user);
            }
            catch (Exception)
            {
                context.db.CreateCollection("User");
                var collection = context.db.GetCollection<User>("User");
                var target = Builders<User>.Filter.Eq("Id", id);
                collection.ReplaceOne(target, user);
            }
        }
        public void deleteUserByName(string name)
        {
            MongoContext context = new MongoContext("testdb");
            try
            {
                var collection = context.db.GetCollection<User>("User");
                var target = Builders<User>.Filter.Eq("Name", name);
                collection.DeleteOne(target);
            }
            catch (Exception)
            {
                context.db.CreateCollection("User");
                var collection = context.db.GetCollection<User>("User");
                var target = Builders<User>.Filter.Eq("Name", name);
                collection.DeleteOne(target);
            }
        }
        public void deleteUserById(Guid id)
        {
            MongoContext context = new MongoContext("testdb");
            try
            {
                var collection = context.db.GetCollection<User>("User");
                var target = Builders<User>.Filter.Eq("Id", id);
                collection.DeleteOne(target);
            }
            catch (Exception)
            {
                context.db.CreateCollection("User");
                var collection = context.db.GetCollection<User>("User");
                var target = Builders<User>.Filter.Eq("Id", id);
                collection.DeleteOne(target);
            }
        }
    }
}