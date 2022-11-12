using Api.LogicLayer.Validators;
using Api.LogicLayer.Validators.Interfaces;
using Tests.MockData.Models;

namespace Tests.Validators
{
    [TestClass]
    public class WeaponsValidatorTests
    {
        private IWeaponValidator Sut;
        public WeaponsValidatorTests()
        {
            Sut = new WeaponValidator();
        }

        [TestMethod]
        public void BoltRifle_OK()
        {
            var testcase = DefaultModels.WeaponRequests.BoltRifle();

            var result = Sut.Validate(testcase);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void KombiRokkit_OK()
        {
            var testcase = DefaultModels.WeaponRequests.KombiRokkit();

            var result = Sut.Validate(testcase);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void FlashmetalGuns_OK()
        {
            var testcase = DefaultModels.WeaponRequests.FlashmetalGuns();

            var result = Sut.Validate(testcase);

            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]
        public void GorksKlaw_OK()
        {
            var testcase = DefaultModels.WeaponRequests.GorksKlaw();

            var result = Sut.Validate(testcase);

            Assert.AreEqual(0, result.Count);
        }
    }
}
