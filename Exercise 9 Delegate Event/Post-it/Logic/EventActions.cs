using Post_it.Data;
using System;

namespace Post_it.Logic
{
    internal class EventActions
    {
        public delegate void EventHandler();
        public event EventHandler actions;

        public delegate Post EventHandlerUpdate(Post post);
        public event EventHandler<Post> eventHandler;
        public void OnProgress()
        {
            if (actions != null)
            {
                actions.Invoke();
            }
        }
        public void OnProgressUpdate(Post post)
        {
            if (eventHandler != null)
            {
                eventHandler.Invoke(this, post);
            }
        }
    }
}
