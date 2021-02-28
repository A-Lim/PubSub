using Microsoft.VisualStudio.TestTools.UnitTesting;
using PubSub;
using System;

namespace IBSTest
{
    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod]
        public void SateliteTransmissionFormat_Correct_Format()
        {
            string message = "Test Format";
            DateTime dateTime = DateTime.Now;

            string stringOutput = StringExtension.SateliteTransmissionFormat(message, dateTime);

            string stringExpected = dateTime.ToLongTimeString() + ": " + message;
            Assert.AreEqual(stringExpected, stringOutput);
        }
    }
}
