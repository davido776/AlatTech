using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBTest.Services.Core;

namespace TestProject
{

    [TestClass]
    public class WBTests
    {
        [TestMethod]
        public void Otp_Is_Six_Digit()
        {
            var otpService = new OtpService();

            var otp = otpService.GenerateOtp();

            Assert.AreEqual(6, otp.Length);
        }

        [TestMethod]
        public void Otp_Is_Random()
        {
            var otpService = new OtpService();

            var otp1 = otpService.GenerateOtp();

            var otp2 = otpService.GenerateOtp();

            Assert.AreNotEqual(otp1, otp2);
        }
    }
}
