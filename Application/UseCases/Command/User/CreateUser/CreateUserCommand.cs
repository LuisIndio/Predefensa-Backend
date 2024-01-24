using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Command.User.CreateUser
{
    public record CreateUserCommand : IRequest<Guid>
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public CreateUserCommand(string name,string email,string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
