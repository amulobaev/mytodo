using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MyToDo.Core;

namespace MyToDo.Data
{
    public class UserRepository : IRepository<ApplicationUser>
    {
        static UserRepository()
        {
            Mapper.CreateMap<ApplicationUser, UserEntity>();
            Mapper.CreateMap<UserEntity, ApplicationUser>();
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            //using (var context = new MyToDoContext())
            //{
            //    List<UserEntity> entities = context.Users.ToList();
            //    var models = 
            //}
            throw new NotImplementedException();
        }

        public IQueryable<ApplicationUser> Query()
        {
            var context = new MyToDoContext();
            return context.Users.Project().To<ApplicationUser>();
        }

        public ApplicationUser GetById(Guid id)
        {
            using (var context = new MyToDoContext())
            {
                UserEntity entity = context.Users.FirstOrDefault(x => x.Id == id);
                return entity != null ? Mapper.Map<UserEntity, ApplicationUser>(entity) : null;
            }
        }

        public void Create(ApplicationUser model)
        {
            UserEntity entity = Mapper.Map<ApplicationUser, UserEntity>(model);
            using (var context = new MyToDoContext())
            {
                context.Users.Add(entity);
                context.SaveChanges();
            }
        }

        public void Update(ApplicationUser model)
        {
            throw new NotImplementedException();
        }

        public void Delete(ApplicationUser model)
        {
            throw new NotImplementedException();
        }
    }
}
