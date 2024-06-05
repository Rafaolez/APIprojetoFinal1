/*using Api.Data;
using Api.Models;
using Api.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Api.Repositorios
{
    public class UsersRepositorio : IUsuarioRepositorio
    {
        private readonly Contexto _dbContext;

        public UsersRepositorio(Contexto dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UsersModel>> GetAll()
        {
            return await _dbContext.User.ToListAsync();
        }

        public async Task<UsersModel> GetById(int id)
        {
            return await _dbContext.User.FirstOrDefaultAsync(x => x.UserId == id);
        }

        public async Task<UsersModel> InsertUser(UsersModel user)
        {
            await _dbContext.User.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return user;
        }

        public async Task<UsersModel> UpdateUser(UsersModel user, int id)
        {
            UsersModel users = await GetById(id);
            if(users == null)
            {
                throw new Exception("Não encontrado.");
            }
            else
            {
                users.UserName = user.UserName;
                users.UserPassword = user.UserPassword;
                users.UserEmail = user.UserEmail;
                _dbContext.User.Update(users);
                await _dbContext.SaveChangesAsync();
            }
            return users;
           
        }

        public async Task<bool> DeleteUser(int id)
        {
            UsersModel users = await GetById(id);
            if (users == null)
            {
                throw new Exception("Não encontrado.");
            }

            _dbContext.User.Remove(users);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        
    }
}
*/