namespace HaikuWorld.Lib.Application;

internal interface IUseCase<TInput, TOutput>
        where TInput : IRequest
        where TOutput : IResponse
{
    ValueTask<TOutput> Handle(TInput input);
}
