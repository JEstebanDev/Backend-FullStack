using System;

namespace Post_it.Data
{
    internal class Post : EventArgs
    {
        private int _id;
        private string _name;
        private string _description;
        private Category _category;

        public Post(int id, string name, string description, Category category)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public Category Category { get { return _category; } set { _category = value; } }
    }
}
