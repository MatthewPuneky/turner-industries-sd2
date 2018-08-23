using SD2.Patterns.ChainOfResponsibility.CacheNodes;

namespace SD2.Patterns.ChainOfResponsibility
{
    public abstract class CacheChainHandler<TRequest, TResponse>
    {
        public CacheChainHandler<TRequest, TResponse> Successor { get; protected set; }

        public void SetSuccessor(CacheChainHandler<TRequest, TResponse> successor)
        {
            Successor = successor;
        }

        public abstract TResponse HandleRequest(TRequest request);
        internal abstract void HandleResponse(CachedUser response);
    }
}
