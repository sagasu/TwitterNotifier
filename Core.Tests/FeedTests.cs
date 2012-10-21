using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Core;

namespace Core.Tests
{
    [TestFixture]
    public class FeedTests
    {
        [Test]
        public void GetFeedes() 
        {
            var raw = new FeedProvider().GetRawFeed;
            Console.WriteLine(raw);
        }
    }
}
