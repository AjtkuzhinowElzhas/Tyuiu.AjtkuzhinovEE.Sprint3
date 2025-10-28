using System.Collections.Specialized;
using Tyuiu.AjtkuzhinovEE.Sprint3.Task3.V22.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint3.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMaxCharCount()
        {
            DataService ds = new DataService();

            string value = "tbtbbb dsfbg bbg";
            char chr = 'b';
            
            int res = ds.GetMaxCharCount(value, chr);

            int wait = 3;
            Assert.AreEqual(wait, res);

        }
    }
}
