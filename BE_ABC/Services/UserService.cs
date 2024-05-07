using foody_be.Models.CommonModels;
using foody_be.Models.Context;
using foody_be.Models.ErdModels;
using foody_be.Services.GenericService;
using System.Collections.Generic;

namespace foody_be.Services
{
    public class UserService: GenericService<User>
    {
        public UserService(MyDbContext context) : base(context)
        {

        }
        public List<User> getAll(Pagination pagination)
        {
            int skip = (pagination.page - 1) * pagination.limit;
            return db.User.Skip(skip).Take(pagination.page).ToList();
        }
    }
}
