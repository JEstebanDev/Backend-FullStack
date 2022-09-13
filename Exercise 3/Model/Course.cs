using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ClassManager.Model
{
    public struct Course
    {
        private string _id;
        private string _name;
        private Member _manager;
        private Member _trainer;

        public Course(string _id, string _name, Member _manager, Member _trainer)
        {
            this._id = _id;
            this._name = _name;
            this._manager = _manager;
            this._trainer = _trainer;
        }

        public string Id => _id;
        public string Name => _name;
        public Member Manager => _manager;
        public Member Trainer => _trainer;

        public override string ToString()
        {
            return String.Format("Course Info:\n" +
                                "ID = {0}\n" +
                                "Name = {1}\n", 
                                _id, _name);
        }
    }
}
