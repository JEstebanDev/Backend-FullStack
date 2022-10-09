using Post_it.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Post_it.Logic
{
    internal class PostServices : IPostService
    {
        List<Post> post = new List<Post>();
        public PostServices(List<Post> post)
        {
            this.post = post;
        }
        public void List()
        {
            Console.WriteLine("List Post its...\n");
            foreach (var item in post)
            {
                Console.WriteLine("Id:{0}\nName:{1}\nDescription:{2}\nCategory:{3}\n", item.Id, item.Name, item.Description, item.Category.Name);
            }
        }

        public void Update(object sender, Post postUpdate)
        {
            Console.WriteLine("Updating info...");
            foreach (var item in post)
            {
                if (item.Id.Equals(postUpdate.Id))
                {
                    item.Name = postUpdate.Name;
                    item.Description = postUpdate.Description;
                    item.Category = postUpdate.Category;
                }
            }
        }
    }
}
