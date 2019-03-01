using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Friction.WebVS.Features.Users {

    public class Search {
        public class Query : IRequest<Model> {
            public string Term { get; set; }
        }

        public class Model {
            public List<SearchResult> Results { get;set; }

            public class SearchResult {
                public int Id { get; set; }
                public string FirstName { get; set; }
                public string LastName { get; set; }
            }
        }

        public class QueryHandler : IRequestHandler<Query, Model>
        {
            public async Task<Model> Handle(Query request, CancellationToken cancellationToken)
            {
                // search using EF Core/Dapper etc...

                return new Model { Results = new List<Model.SearchResult> {
                    new Model.SearchResult { FirstName = "Bob", LastName = "Smith", Id = 1 },
                    new Model.SearchResult { FirstName = "Susan", LastName = "Jones", Id = 2 },
                } };
            }
        }
    }   

}