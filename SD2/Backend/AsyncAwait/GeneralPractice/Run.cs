using System.Threading.Tasks;

namespace SD2.Backend.AsyncAwait.GeneralPractice
{
    public static class Run
    {
        public static void Operation()
        {
            var asyncPractice = new AsyncPractice();

            var task = Task.Run(() => asyncPractice.Start());
            Task.WaitAll(task);
        }
    }
}
