using System.Threading;
using System.Threading.Tasks;
using Friction.WebVS.Models;
using MediatR;

namespace Friction.WebVS.Features.Users
{
    public class Add
    {
        public class Command : IRequest
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public class Handler : AsyncRequestHandler<Command>
        {
            private readonly AppDbContext appContext;

            public Handler(AppDbContext context)
            {
                appContext = context;
            }

            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                await appContext.Users.AddAsync(new User { FirstName = request.FirstName, LastName = request.LastName }, cancellationToken);
                await appContext.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
