using NUnit.Framework;
using SimpleSong.Controller.MenuManager;

namespace SimpleSongTest
{
    [TestFixture]
    public class SongTests
    {
        private AddNewSong newSong;
        [SetUp]
        public void Setup()
        {
            newSong = new AddNewSong();
        }

        [Test]
        public void IsLengthSongDouble()
        {
            string lengthAsString = "1.25";
            Assert.AreEqual(newSong.IsCorrectLengthFormat(lengthAsString), true);
        }

        [Test]
        public void IsLengthSongInt()
        {
            string lengthAsString = "1";
            Assert.AreEqual(newSong.IsCorrectLengthFormat(lengthAsString), true);
        }

        [Test]
        public void IsLengthSongString()
        {
            string lengthAsString = "abcd";
            Assert.AreEqual(newSong.IsCorrectLengthFormat(lengthAsString), false);
        }

        [Test]
        public void IsStringEmpty()
        {
            string param = "";
            Assert.AreEqual(newSong.IsNotEmptyString(param), false);
        }

        [Test]
        public void IsStringNotEmpty()
        {
            string param = "dsad";
            Assert.AreEqual(newSong.IsNotEmptyString(param), true);
        }
    }
}