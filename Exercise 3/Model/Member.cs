using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ClassManager.Model
{
    public class Member
    {
        private string _id;
        private string _name;
        private string _lastName;
        private string _email;
        private Role _role;

        public Member()
        {
        }

        public Member(string _id, string _name, string _lastName, string _email, Role _role)
        {
            this._id = _id;
            this._name = _name;
            this._lastName = _lastName;
            this._email = _email;
            this._role = _role;
        }

        public string Id
        {
            get => _id;
            set => _id = value;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value;
        }
        public Role Role
        {
            get => _role;
            set => _role = value;
        }

        public override string ToString()
        {
            return String.Format("Member Info:\n" +
                                "ID = {0}\n" +
                                "Name = {1} {2}\n" +
                                "Email = {3}\n" +
                                "Rol = {4}\n", _id, _name, _lastName, _email, _role);
        }
    }
}
