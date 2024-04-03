namespace Television.Tests
{
    using System;
    using NUnit.Framework;
    public class Tests
    {
        private TelevisionDevice tvDevice;
        private const string Brand = "LG";
        private const double Price = 399.99;
        private const int ScreenWidth = 60;
        private const int ScreenHeight = 20;
        [SetUp]
        public void Setup()
        {
            tvDevice = new TelevisionDevice(Brand, Price, ScreenWidth, ScreenHeight);
        }

        [Test]
        public void Ctor_IfProperties_AreCorrect()
        {
            Assert.That(tvDevice, Is.Not.Null);
            Assert.That(tvDevice.Brand, Is.EqualTo(Brand));
            Assert.That(tvDevice.Price, Is.EqualTo(Price));
            Assert.That(tvDevice.ScreenWidth, Is.EqualTo(ScreenWidth));
            Assert.That(tvDevice.ScreenHeigth, Is.EqualTo(ScreenHeight));
            Assert.That(tvDevice.CurrentChannel, Is.EqualTo(0));
            Assert.That(tvDevice.Volume, Is.EqualTo(13));
            Assert.That(tvDevice.IsMuted, Is.EqualTo(false));
        }

        [Test]
        public void ToString_Returns_CorrectResult()
        {
            string expected = $"TV Device: {Brand}, Screen Resolution: {ScreenWidth}x{ScreenHeight}, Price {Price}$";
            string actual = tvDevice.ToString();
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void SwitchOn()
        {
            string expected = $"Cahnnel 0 - Volume 13 - Sound On";
            string actual = tvDevice.SwitchOn();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ChangeChannel()
        {
            int expected = 7;
            var actual = tvDevice.ChangeChannel(expected);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void ChangeChannel_WhenLessThan0()
        {
            int expected = -7;
            Exception ex = Assert.Throws<ArgumentException>(() =>tvDevice.ChangeChannel(expected));
        }

        [Test]
        public void Mute()
        {
            tvDevice.MuteDevice();
            Assert.That(tvDevice.IsMuted, Is.EqualTo(true));

            tvDevice.MuteDevice();
            Assert.That(tvDevice.IsMuted, Is.EqualTo(false));
        }

        [TestCase(7)]
        [TestCase(-7)]
        public void VolumeUp_Sets_Correct(int volumeChange)
        {
            string expected = "Volume: 20";
            string actual = tvDevice.VolumeChange("UP", volumeChange);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void VolumeUp_WhenVolume_IsMoreThan100()
        {
            string expected = "Volume: 100";
            string actual = tvDevice.VolumeChange("UP", 100);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [TestCase(7)]
        [TestCase(-7)]
        public void VolumeDown_Sets_Correct(int volumeChange)
        {
            string expected = "Volume: 6";
            string actual = tvDevice.VolumeChange("DOWN", volumeChange);
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void VolumeDown_WhenVolume_IsLessThan0()
        {
            string expected = "Volume: 0";
            string actual = tvDevice.VolumeChange("DOWN", -100);
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}