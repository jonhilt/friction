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

    public class Search
    {
        public class Query : IRequest<Model>
        {
            public string Term { get; set; }
        }

        public class Model
        {
            public List<SearchResult> Results { get; set; } = new List<SearchResult>();

            public class SearchResult
            {
                public Guid Id { get; set; }
                public string FirstName { get; set; }
                public string LastName { get; set; }
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
                if (string.IsNullOrEmpty(request.Term))
                    return new Model();

                // could easily replace with dapper etc. if query needs to be super fast!

                var results = appContext.Users.Where(x => x.FirstName.Contains(request.Term) || x.LastName.Contains(request.Term))
                    .Select(x => new Model.SearchResult
                    {
                        FirstName = x.FirstName,
                        LastName = x.LastName,
                        Id = x.Id
                    });

                return new Model
                {
                    Results = await results.ToListAsync(cancellationToken)
                };
            }
        }
    }
}