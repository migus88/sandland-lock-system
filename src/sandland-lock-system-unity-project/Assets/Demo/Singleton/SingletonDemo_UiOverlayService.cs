using Sandland.LockSystem.Demo.Shared;

namespace Sandland.LockSystem.Demo.Singleton
{
    public class SingletonDemo_UiOverlayService : SimpleLockService<OverlayTag>
    {
        public static SingletonDemo_UiOverlayService Instance { get; } = new();
        
        private SingletonDemo_UiOverlayService()
        {
            
        }
    }
}