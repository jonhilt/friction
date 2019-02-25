using MediatR;

namespace Friction.WebVS.Features.Users {

    public class List {
        public class Query : IRequest<Model> {
        }

        public class Model {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }   

}