using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Friction.WebVS.Features.Users {

    public class List {
        public class Query : IRequest<Model> {
        }

        public class Model {
            public List<User> Users { get;set; }

            public class User {
                public int Id { get; set; }
                public string FirstName { get; set; }
                public string LastName { get; set; }
                public string LastLogin { get; set; }
            }
        }

        public class QueryHandler : IRequestHandler<Query, Model>
        {
            public async Task<Model> Handle(Query request, CancellationToken cancellationToken)
            {
                return new Model { Users = new List<Model.User> {
                    new Model.User { FirstName = "Bob", LastName = "Smith", Id = 1, LastLogin = "01/01/2019" },
                    new Model.User { FirstName = "Susan", LastName = "Jones", Id = 2, LastLogin = "01/02/2019" },
                } };
            }
        }
    }   

}