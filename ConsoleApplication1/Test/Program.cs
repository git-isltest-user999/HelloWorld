using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public sealed class ConsoleApplication1Test
    {
        [Test]
        public void GetMessageTest()
        {
            const String Greeting = "Hello, World!";
            Message message = new Message();
            message.SetMessage(Greeting );
            
            //Verify
            Assert.AreEqual(Greeting, message.GetMessage());
        }


        [Test]
        public void GetMessageTest2()
        {
            const String Greeting = "Hello, C# !";
            Message message = new Message();
            message.SetMessage(Greeting);

            //Verify
            Assert.AreEqual(Greeting, message.GetMessage());
        }
    }
}