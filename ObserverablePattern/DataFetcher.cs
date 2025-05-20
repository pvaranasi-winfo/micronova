namespace TimerFunction.ObserverablePattern
{
    public class DataFetcher
    {
        private readonly List<ISubscriber> subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

        public void Notify(List<Device> devices) 
        {
            foreach (var item in subscribers)
            {
                item.Update(devices);
            }
        }

    }
}
