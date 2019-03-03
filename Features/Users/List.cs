using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Friction.WebVS.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Friction.WebVS.Features.Users
{

    public class List
    {
        public class Query : IRequest<Model>
        {
        }

        public class Model
        {
            public List<User> Users { get; set; }

            public class User
            {
                public Guid Id { get; set; }
                public string FirstName { get; set; }
                public string LastName { get; set; }
                public string LastLogin { get; set; }
            }
        }

        public class QueryHandler : IRequestHandler<Query, Model>
        {
            private readonly AppDbContext appContext;

            public QueryHandler(AppDbContext appContext)
            {
                this.appContext = appContext;
            }

            public async Task<Model> Handle(Query request, CancellationToken cancellationToken)
            {
                var users = appContext.Users.Select(x => new Model.User
                {
                    FirstName = x.FirstName,
                    LastLogin = x.LastLogin.ToString("dd/MM/yyyy"),
                    LastName = x.LastName,
                    Id = x.Id
                });

                return new Model { Users = await users.ToListAsync(cancellationToken) };
            }
        }
    }

}