using IdentityProvider.DataAccess.Interfaces;
using IdentityProvider.Domain.Entities;
using IdentityProvider.Persistence.Dtos.Auth;
using IdentityProvider.Persistence.Dtos.Users;
using IdentityProvider.Service.Interface.Users;
using IdentityProvider.Service.Security;

namespace IdentityProvider.Service.Service.Users
{
    public class UserService : IUserService
    {
        private IUnitOfWork _repository;

        public UserService(IUnitOfWork unitOfWork)
        {
            this._repository = unitOfWork;
        }
        public int CreateAsync(UserRegisterDto dto)
        {
            User user = new User()
            {
               
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                PhoneNumber= dto.PhoneNumber,
                Provider= dto.Provider,
                ProviderConfirme= dto.ProviderConfirme
            };
            
            var hasher = PasswordHasher.Hash(dto.Password);

            user.Salt = hasher.Salt;
            user.PasswordHash = hasher.Hash;

             _repository.User.Add(user);

            var result = _repository.SaveChangesAsycn();

        }

        public Task<int> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(UserUpdateDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
