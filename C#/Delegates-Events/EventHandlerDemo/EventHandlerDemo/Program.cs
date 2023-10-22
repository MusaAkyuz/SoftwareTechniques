namespace EventHandlerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyEventClass eventClass = new MyEventClass();
            EventListener listener = new EventListener();

            //Olaya abone ol
            eventClass.MyEvent += listener.HandleEvent;
            eventClass.MyEvent += listener.HandleEvent;

            //Olayı tetikle
            eventClass.TriggerEvent();

            //Olaya aboneliği kaldır
            eventClass.MyEvent -= listener.HandleEvent;
        }
    }

    //İlk olarak, olayı tanımlamak için bir delegeniz olmalıdır. Delege, olayı dinleyecek yöntemleri işaret eder
    public delegate void MyEventHandler(object sender, EventArgs e);

    //Bir sınıfın içinde bu delegeyi kullanarak bir olay tanımlayın
    public class MyEventClass
    {
        //Olay tanımlanır
        public event MyEventHandler MyEvent;

        //Olayı tetikleyen yöntem
        public void TriggerEvent()
        {
            if(MyEvent != null)
            {
                MyEvent(this, EventArgs.Empty);
            }
        }
    }

    //Olayı dinlemek için bir başka sınıf veya nesne oluşturun ve bu olayı dinlemek istediğiniz bir yöntemi bu olaya bağlayın
    public class EventListener
    {
        public void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event Handled");
        }
    }
}