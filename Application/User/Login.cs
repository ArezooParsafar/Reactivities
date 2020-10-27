using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;
using FluentValidation;

namespace Application.User
{
    public class Query : IRequest<User>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class QueryValidator : AbstractValidator<Query>
    {
        public QueryValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Password).NotEmpty();
        }
    }

    public class Handler : IRequestHandler<Query, User>
    {
        private readonly DataContext _context;
        public Handler(DataContext context)
        {
            _context = context;

        }


        public async Task<User> Handle(Query request,
            CancellationToken cancellationToken)
        {
            _context.
         }
    }
}