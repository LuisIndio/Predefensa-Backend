using Domain.Factories.Users;
using Domain.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.Command.User.CreateUser
{
    internal class CreateUserHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IUserFactory _userFactory;
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateUserHandler(IUserFactory userFactory, IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userFactory = userFactory;
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _userFactory.RegisterUser(request.Name, request.Email, request.Password);
            //user.AddCategory(user.Id,"alimentos","esta categoria es para los alimentos");
            //user.AddAccount(user.Id,"colchon",120);
            await _userRepository.CreateAsync(user);
            await _unitOfWork.Commit();
            return user.Id;
        }
    }
}
