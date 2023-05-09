using Autofac;
using Framework.Application;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Framework.Autofac
{
    public class AutofacCommandBus : ICommandBus
    {
        private readonly ILifetimeScope _scope;

        public AutofacCommandBus(ILifetimeScope scope)
        {
            _scope = scope;
        }

        public async Task Dispatch<T>(T command) where T : ICommand
        {
            var handlers = _scope.Resolve<IEnumerable<ICommandHandler<T>>>();

            foreach (var handler in handlers)
            {
                await handler.Handle(command);
            }
        }
    }
}
