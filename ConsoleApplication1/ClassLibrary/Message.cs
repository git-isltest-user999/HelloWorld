using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public sealed class Message
    {
        private String message;
        public void SetMessage(String message)
        {
            this.message = message;
        }
        public String GetMessage()
        {
            return message;
        }
    }
}
