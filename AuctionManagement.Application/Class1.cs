using AuctionManagement.Application.Contracts;
using Framework.Application;

namespace AuctionManagement.Application
{
    public class AuctionService : ICommandHandler<PlaceBidCommand>,
        ICommandHandler<OpenAuctionCommand>
    {
        public Task Handle(PlaceBidCommand command)
        {
            return Task.CompletedTask;
        }

        public Task Handle(OpenAuctionCommand command)
        {
            return Task.CompletedTask;
        }
    }
}