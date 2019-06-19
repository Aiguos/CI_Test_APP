using System;
using Xunit;

namespace XunitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            const bool boool = true;

            Assert.True(boool);
        }
    }
}
