namespace TestARC76
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var account = AlgorandARC76AccountDotNet.ARC76.GetEmailAccount("email@example.com", "12345678901234567890123456789012345678901234567890");
            Assert.That(account.Address.EncodeAsString(), Is.EqualTo("5AHWQJ5D52K4GRW4JWQ5GMR53F7PDSJEGT4PXVFSBQYE7VXDVG3WSPWSBM"));
        }
    }
}