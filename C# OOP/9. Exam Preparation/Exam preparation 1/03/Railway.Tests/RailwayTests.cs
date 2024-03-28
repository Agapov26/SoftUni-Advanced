namespace Railway.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class Tests
    {
        private RailwayStation station;

        [SetUp]
        public void Setup()
        {
            station = new RailwayStation("station");
        }

        [Test]
        public void CheckConstructor_Correctly()
        {
            Assert.AreEqual("station", station.Name);
            Assert.AreEqual(0, station.ArrivalTrains.Count);
            Assert.AreEqual(0, station.DepartureTrains.Count);
        }

        [Test]
        public void NullOrWhiteSpace_Throws()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                var newStation = new RailwayStation(null);
            });

            Assert.Throws<ArgumentException>(() =>
            {
                var newStation = new RailwayStation(" ");
            });
        }

        [Test]
        public void NewArrival_ShouldBeAdded()
        {
            station.NewArrivalOnBoard("pleven-sofia");

            Assert.AreEqual(1, station.ArrivalTrains.Count);
            Assert.AreEqual("pleven-sofia", station.ArrivalTrains.Dequeue());
        }

        [Test]
        public void TrainHasArrived_IsCorrect()
        {
            station.NewArrivalOnBoard("pleven-sofia");

            Assert.AreEqual("There are other trains to arrive before varna-sofia.", station.TrainHasArrived("varna-sofia"));

            Assert.AreEqual("pleven-sofia is on the platform and will leave in 5 minutes.", station.TrainHasArrived("pleven-sofia"));

            Assert.AreEqual(1, station.DepartureTrains.Count);
            Assert.AreEqual("pleven-sofia", station.DepartureTrains.Dequeue());
            Assert.AreEqual(0, station.ArrivalTrains.Count());
        }

        [Test]
        public void CheckIf_TrainHasLeft()
        {
            station.NewArrivalOnBoard("pleven-sofia");

            station.TrainHasArrived("pleven-sofia");

            Assert.AreEqual(false, station.TrainHasLeft("Non existant"));
            Assert.AreEqual(true, station.TrainHasLeft("pleven-sofia"));
            Assert.AreEqual(0, station.ArrivalTrains.Count);
        }
    }
}