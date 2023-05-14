using AuctionManagement.Application.Contracts;
using Framework.Application;
using System.Threading.Tasks;

namespace AuctionManagement.Application
{
    public class AuctionCommandHandlers :
        ICommandHandler<PlaceBidCommand>,
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