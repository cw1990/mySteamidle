using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace idleApp
{
    class AppMember
    {
        string id;
        string name;
        string cardNum;

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string CardNum
        {
            get
            {
                return cardNum;
            }

            set
            {
                cardNum = value;
            }
        }
    }
}
