using Subfactorials;
using NUnit.Framework;

namespace Subfactorials.Tests {

    [TestFixture]
    public class SubfactorialTest {
        Subfactorial _sut;

        [SetUp]
        public void Setup() {
            _sut = new Subfactorial();
        }

        [Test]
        [TestCase(1, 0)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(5, 44)]
        [TestCase(6, 265)]
        [TestCase(9, 133496)]
        [TestCase(14, 32071101049)]
        public void DearangementTest(long inputValue, long expectedOutput) {
            Assert.That(_sut.Dearangement(inputValue), Is.EqualTo(expectedOutput));
        }
    }
}
