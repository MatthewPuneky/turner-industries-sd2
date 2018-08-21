using SD2.Patterns.ChainOfResponsibility.CacheNodes;

namespace SD2.Patterns.ChainOfResponsibility
{
    public abstract class CacheChainHandler<Request, Response>
    {
        protected CacheChainHandler<Request, Response> _successor;

        public void SetSuccessor(CacheChainHandler<Request, Response> successor)
        {
            _successor = successor;
        }

        public abstract Response HandleRequest(Request request);
        internal abstract void HandleResponse(CachedUser response);
    }
}
