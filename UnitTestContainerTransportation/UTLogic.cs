using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContainerTransport;
using ContainerTransport.Logic;
using ContainerTransport.Models;

namespace UnitTestContainerTransportation
{
    [TestClass]
    public class UTLogic
    {
        private ShipAlgorithm TestLogic;
        private List<Container> testContainers = new List<Container>();
        private int _totalValuable;
        private int _totalCooled;

        [TestInitialize]
        public void initialize()
        {
            TestLogic = new ShipAlgorithm(1200000);
        }

        [TestMethod]
        public void Check_if_can_add_container()
        {
            //add standard container
            TestLogic.AddContainer(30000, true, false, false);

            Assert.AreEqual(30000, TestLogic.WeightOfDockedContainers);
        }

        [TestMethod]
        public void Check_remove_container_from_ship()
        {
            //Add container
            TestLogic.AddContainer(30000, true, false, false);

            TestLogic.WeightOfDockedContainers -= TestLogic.DockedContainers[0].Weight;
            //Remove container
            TestLogic.DockedContainers.RemoveAt(0);
            Assert.AreEqual(0, TestLogic.WeightOfDockedContainers);

        }

        //test if minimum weight is matched
        [TestMethod]
        public void Check_minimum_weight_on_ship()
        {
            try
            {
                for (int i = 0; i < 5; i++)
                {
                    decimal Weight = 30000;
                    bool Standard = true;
                    bool Valuable = false;
                    bool Cooled = false;

                    TestLogic.AddContainer(Weight, Standard, Valuable, Cooled);
                }
                TestLogic.StartAlgorithm();
            }
            catch (ExceptionHandler e)
            {
                string expectedString = String.Format("The total docked containers weight do not require the minimum ship weight of {0}! other wise the ship will capsize!", TestLogic.ship.MinWeight);
                Assert.AreEqual(expectedString, e.Message);
            }
        }

        //test if maximum weight is matched
        [TestMethod]
        public void Check_maximum_weight_on_ship()
        {
            try
            {
                //add default
                for (int i = 0; i < 45; i++)
                {
                    decimal Weight = 30000;
                    bool Standard = true;
                    bool Valuable = false;
                    bool Cooled = false;
                    TestLogic.AddContainer(Weight, Standard, Valuable, Cooled);
                }
                TestLogic.StartAlgorithm();
            }
            catch (ExceptionHandler e)
            {
                string expectedString = String.Format("The total docked containers weight is higher than the maximum ship weight of {0} other wise it will capsize!", TestLogic.ship.MaxWeight);
                Assert.AreEqual(expectedString, e.Message);
            }
        }

        //test if maximum valuable containers is matched
        [TestMethod]
        public void Check_valuable_containers_maximum_on_ship()
        {
            try
            {
                //add valuable
                for (int i = 0; i < 5; i++)
                {
                    decimal Weight = 30000;
                    bool Standard = false;
                    bool Valuable = true;
                    bool Cooled = false;

                    TestLogic.AddContainer(Weight, Standard, Valuable, Cooled);
                }

                //add default
                for (int i = 0; i < 35; i++)
                {
                    decimal Weight = 30000;
                    bool Standard = true;
                    bool Valuable = false;
                    bool Cooled = false;

                    TestLogic.AddContainer(Weight, Standard, Valuable, Cooled);
                }

                TestLogic.StartAlgorithm();
            }
            catch (ExceptionHandler e)
            {
                //check totalValuable containers
                _totalValuable = TestLogic.DockedContainers.FindAll(c => c.Valuable).Count;
                string expectedString = String.Format("There are to many valuable containers! There are current {0} and there are only 4 allowed on this ship",
                    _totalValuable);
                Assert.AreEqual(expectedString, e.Message);
            }
        }

        //test if maximum cooled containers is matched
        [TestMethod]
        public void Check_cooled_maximum_on_ship()
        {
            try
            {
                //add cooled
                for (int i = 0; i < 10; i++)
                {
                    decimal Weight = 30000;
                    bool Standard = false;
                    bool Valuable = false;
                    bool Cooled = true;

                    TestLogic.AddContainer(Weight, Standard, Valuable, Cooled);
                }

                //add valuable
                for (int i = 0; i < 4; i++)
                {
                    decimal Weight = 30000;
                    bool Standard = false;
                    bool Valuable = true;
                    bool Cooled = false;

                    TestLogic.AddContainer(Weight, Standard, Valuable, Cooled);
                }

                //add default
                for (int i = 0; i < 15; i++)
                {
                    decimal Weight = 30000;
                    bool Standard = true;
                    bool Valuable = false;
                    bool Cooled = false;

                    TestLogic.AddContainer(Weight, Standard, Valuable, Cooled);
                }
                TestLogic.StartAlgorithm();
            }
            catch (ExceptionHandler e)
            {
                _totalCooled = TestLogic.DockedContainers.FindAll(c => c.Cooled).Count;
                _totalValuable = TestLogic.DockedContainers.FindAll(c => c.Valuable).Count;
                string expectedString = String.Format("There are to many cooled containers! There are current {0} and you can only have at max 10 if there are no valuable containers. the total valuable containers are {1}",
                    _totalCooled, _totalValuable);
                Assert.AreEqual(expectedString, e.Message);
            }
        }
    }
}
