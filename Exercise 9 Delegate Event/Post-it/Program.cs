using Post_it.Data;
using Post_it.Logic;
using System.Collections.Generic;

namespace Post_it
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Post> post = new List<Post>();
            //Saving tasks
            post.Add(new Post(1, "Task", "I have to clean my desk", new Category(1, "Home")));
            post.Add(new Post(2, "Gaia's Homework", "I have to do exercises with delegate, event and eventHandler", new Category(2, "BootCamp")));
            post.Add(new Post(3, "Find a Girlfriend", "Ask to Joaquin how to flirt with girls", new Category(3, "Girls")));
            PostServices postServices = new PostServices(post);
            EventActions eventActions = new EventActions();
            eventActions.actions += postServices.List;
            eventActions.OnProgress();

            EventActions eventActions2 = new EventActions();
            eventActions2.eventHandler += postServices.Update;
            Post postUpdate = new Post(1, "Task", "I have to take a shower and go out", new Category(1, "Home"));

            eventActions2.eventHandler += (s, postDeleted) =>
            {
                System.Console.WriteLine("Deleting...");
                for (int i = 0; i < post.Count; i++)
                {
                    if (post[i].Id.Equals(postDeleted.Id))
                    {
                        post.RemoveAt(i);
                    }
                }
            };

            eventActions2.OnProgressUpdate(postUpdate);

            eventActions.OnProgress();
        }
    }
}
