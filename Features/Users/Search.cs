using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Friction.WebVS.Features.Users
{
    public class Search
    {
        public class Query : IRequest<Model>
        {
            public string SearchTerm { get; set; }
        }

        public class Model
        {
            public List<SearchResult> Results { get; set; }

            public class SearchResult
            {
                public string FirstName { get; set; }
                public string LastName { get; set; }
            }
        }

        public class QueryHandler : IRequestHandler<Query, Model>
        {
            public async Task<Model> Handle(Query request, CancellationToken cancellationToken)
            {
                // search (e.g. using our ORM or Dapper for performance)
                // return the results
                return new Model
                {
                    Results = new List<Model.SearchResult>
                    {
                        new Model.SearchResult{ FirstName = "Susan", LastName = "Jones" },
                        new Model.SearchResult{ FirstName = "Mark", LastName = "Bates" }
                    }
                };

            }
        }
    }
}