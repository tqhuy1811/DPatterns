/*
 My favorite pattern. Wonderful usage of composition. It's still hard to debug and reason though.
*/
namespace DesignPattern
{
    public interface ICommandHandler<TCommand>
    {
        void Handle(TCommand command);
    }

    public class TransactionCommandHandlerDecorator<TCommand>
    : ICommandHandler<TCommand>
    {
        private readonly ICommandHandler<TCommand> decorated;

        public TransactionCommandHandlerDecorator(
            ICommandHandler<TCommand> decorated)
        {
            this.decorated = decorated;
        }

        public void Handle(TCommand command)
        {
           // Do Addtional Stuff
        }
    }
}