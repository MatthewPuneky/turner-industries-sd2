using SD2.Patterns.ChainOfResponsibility.CacheNodes;
using SD2.SharedFeatures.Menus;

namespace SD2.Patterns.ChainOfResponsibility
{
    public class Run
    {
        public static void Operation()
        {
            SetState();
            MenuFactory.FindUserMenu().Display();
        }

        private static void SetState()
        {
            var state = StorageState.Instance;

            state.TopOfChain = null;

            var cacheL1 = new IndexCache();
            var cacheL2 = new LinkedListCache();
            var longTermUserStorage = new LongTermUserStorage();

            state.SetNextInChain(cacheL1);
            state.SetNextInChain(cacheL2);
            state.SetNextInChain(longTermUserStorage);
        }
    }
}
