using System;

namespace Post_it.Data
{
    internal class Category
    {
        private int _id;
        private string _name;

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
    }
}
