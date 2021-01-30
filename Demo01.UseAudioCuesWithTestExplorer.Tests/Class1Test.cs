using System;
using Xunit;

namespace Demo01.UseAudioCuesWithTestExplorer.Tests
{
    public class Class1Test
    {
#if NET5_0
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            Assert.True(false);
        }

    }
}
