using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FaceBookSlotsApp;


namespace UnitTestProject1
{
    [TestClass]
    public class WheelTests
    {
        Wheel wheel;
        List<string> testNames = new List<string>();

        [TestInitialize]
        public void Initialize()
        {
            testNames.Add("Davey Jones");
            testNames.Add("Bob Ross");
            testNames.Add("Jane Dunnicliffe");
            wheel = new Wheel(testNames);
        }

        [TestMethod]
        public void HasVelocity()
        {
            var velocity = wheel.Velocity;

            Assert.AreEqual(0, velocity);
        }

        [TestMethod]
        public void DoesAccellerate()
        {
            wheel.Start();
            wheel.Tick(0.1f);

            var velocity = wheel.Velocity;
            Assert.IsTrue(velocity > 0);
        }

        [TestMethod]
        public void DoesDecellerate()
        {
            wheel.Start();
            wheel.Tick(1f);
            var startVelocity = wheel.Velocity;

            wheel.Stop();
            wheel.Tick(1f);
            var endVelocity = wheel.Velocity;

            Assert.IsTrue(endVelocity < startVelocity);
        }

        [TestMethod]
        public void HasNames()
        {
            var wheelNameList = wheel.Names;
            Assert.IsTrue(wheelNameList == testNames);
        }

        [TestMethod]
        public void HasLength()
        {
            var spacing = wheel.NameSize;
            var wheelLength = wheel.Length;

            var properLength =  spacing * testNames.Count;

            Assert.AreEqual(properLength, wheelLength);
        }

        [TestMethod]
        public void HasPointer()
        {
            var pointerPosition = wheel.Pointer;
            Assert.AreEqual(pointerPosition, 0);
        }

        [TestMethod]
        public void PointerMoves()
        {
            var pointerPosition = wheel.Pointer;
            wheel.Start();
            wheel.Tick(1f);
            var newPointerPosition = wheel.Pointer;

            Assert.AreNotEqual(pointerPosition, newPointerPosition);
        }

        [TestMethod]
        public void PointerLoops()
        {
            var pointerPosition = wheel.Pointer;
            wheel.NameSize = 5;
            wheel.SpinSpeed = 5;
            wheel.Start();
            wheel.Tick(3f);
            var newPointerPosition = wheel.Pointer;

            Assert.AreEqual(pointerPosition, newPointerPosition);
        }


        [TestMethod]
        public void CanReturnName()
        {
            var pointerName = wheel.NamePointedAt;
            var FirstName = testNames[0];

            Assert.AreEqual(FirstName, pointerName);
        }

        [TestMethod]
        public void NameChanges()
        {
            var pointerName = wheel.NamePointedAt;
            wheel.NameSize = 5;
            wheel.SpinSpeed = 5;
            wheel.Start();
            wheel.Tick(2f);

            var newPointerName = wheel.NamePointedAt;

            Assert.AreNotEqual(pointerName, newPointerName);
        }
    }
}
