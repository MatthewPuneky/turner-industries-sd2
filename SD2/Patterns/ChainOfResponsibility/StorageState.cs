using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SD2.Patterns.ChainOfResponsibility.CacheNodes;

namespace SD2.Patterns.ChainOfResponsibility
{
    public sealed class StorageState
    {
        private StorageState() { }
        private static StorageState _instance;
        public static StorageState Instance => _instance ?? (_instance = new StorageState());

        public CacheChainHandler<int, CachedUser> TopOfChain { get; set; }

        public void SetNextInChain(CacheChainHandler<int, CachedUser> nextLinkInChain)
        {
            if (TopOfChain == null)
            {
                TopOfChain = nextLinkInChain;
            }
            else
            {
                var currentLink = TopOfChain;

                while (currentLink.Successor != null)
                {
                    currentLink = currentLink.Successor;
                }

                currentLink.SetSuccessor(nextLinkInChain);
            }
        }
    }
}
