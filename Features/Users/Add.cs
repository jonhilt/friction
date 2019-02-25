using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Friction.WebVS.Features.Users {

    public class Add {
        public class Command : IRequest {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public class CommandHandler : AsyncRequestHandler<Command>
        {
            protected override async Task Handle(Command request, CancellationToken cancellationToken)
            {
                // save to DB
            }
        }
    }   

}