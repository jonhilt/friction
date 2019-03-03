using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Friction.WebVS.Models;
using MediatR;

namespace Friction.WebVS.Features.Users
{
    public class RecentLogins
    {
        public class Query : IRequest<Model>
        {
        }

        public class Model
        {
            public List<User> RecentLogins { get; set; } = new List<User>();

            public class User
            {
                public string FirstName { get; set; }
                public string LastName { get; set; }
                public string LastLogin { get; set; }
            }
        }

        public class QueryHandler : IRequestHandler<Query, Model>
        {
            private readonly AppDbContext appDbContext;

            public QueryHandler(AppDbContext dbContext)
            {
                appDbContext = dbContext;
            }

            public async Task<Model> Handle(Query request, CancellationToken cancellationToken)
            {
                var topUsers = appDbContext.Users.OrderByDescending(x => x.LastLogin).Take(2);

                var result = new Model();
                foreach (var topUser in topUsers)
                {
                    result.RecentLogins.Add(new Model.User
                    {
                        FirstName = topUser.FirstName,
                        LastName = topUser.LastName,
                        LastLogin = topUser.LastLogin.ToString("dd/MM/yyyy")
                    });
                }
                return result;
            }
        }
    }

}