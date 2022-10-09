using Post_it.Data;
using System;

namespace Post_it.Logic
{
    internal interface IPostService
    {
        void List();
        void Update(object sender, Post postUpdate);
    }
}
