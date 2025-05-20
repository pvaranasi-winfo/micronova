
namespace TimerFunction.ObserverablePattern
{
    /// <summary>
    /// Observer interface 
    /// </summary>
    public interface ISubscriber
    {
        void Update(List<Device> devices);
    }
}
