using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Online
{
    public class LogingModel
    {
        public string _UserName;
        public string _PassWord;
        public string UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
        public string UserPassWD
        {
            get
            {
                return _PassWord;
            }
            set
            {
                _PassWord = value;
            }
        }
    }
}
