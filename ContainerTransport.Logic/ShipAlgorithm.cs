using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainerTransport.Models;

namespace ContainerTransport.Logic
{
    public class ShipAlgorithm
    {
        public Ship ship;
        public decimal WeightOfDockedContainers { get; set; }
        public List<Container> DockedContainers { get; set; } = new List<Container>();

        public ShipAlgorithm(decimal maxWeight)
        {
            ship = new Ship(maxWeight, 8);
        }

        public void AddContainer(decimal weight, bool standard, bool valuable, bool cooled)
        {
            Container newContainer = new Container
            {
                Weight = weight,
                Standard = standard,
                Valuable = valuable,
                Cooled = cooled
            };

            DockedContainers.Add(newContainer);
            WeightOfDockedContainers += newContainer.Weight;
        }

        public void RemoveContainer(int index)
        {
            WeightOfDockedContainers -= DockedContainers[index].Weight;
            DockedContainers.RemoveAt(index);
        }

        public void StartAlgorithm()
        {
            CheckLimitedContainersOnShip();
            PlaceContainersOnBoat();

            if (!ship.CalculateBalance())
            {
                while (!ship.CalculateBalance())
                {
                    BalanceShip();
                }
            }
        }

        private void CheckCooledAndValueContainersOnShip()
        {
            int _totalValuable = 0;
            int _totalCooled = 0;

            _totalValuable = DockedContainers.FindAll(c => c.Valuable).Count;

            if (_totalValuable > 4)
                throw new ExceptionHandler(
                    "There are to many valuable containers! There are current {0} and there are only 4 allowed on this ship",
                    _totalValuable);

            _totalCooled = DockedContainers.FindAll(c => c.Cooled).Count;

            if ((_totalValuable > 2 && _totalCooled > 10))
                throw new ExceptionHandler(
                    "There are to many cooled containers! There are current {0} and you can only have at max 10 if there are no valuable containers. the total valuable containers are {1}",
                    _totalCooled, _totalValuable);
        }

        private void CheckDefaultContainersOnShip()
        {
            if (WeightOfDockedContainers < ship.MinWeight)
                throw new ExceptionHandler(
                    "The total docked containers weight do not require the minimum ship weight of {0}! other wise the ship will capsize!",
                    ship.MinWeight);

            if (WeightOfDockedContainers > ship.MaxWeight)
                throw new ExceptionHandler(
                    "The total docked containers weight is higher than the maximum ship weight of {0} other wise it will capsize!",
                    ship.MaxWeight);
        }

        private void CheckLimitedContainersOnShip()
        {
            CheckDefaultContainersOnShip();
            CheckCooledAndValueContainersOnShip();
        }

        private void PlaceCooledContainersOnBoat(Selection selection)
        {
            bool _hasCooledContainer = DockedContainers.Exists(c => c.Cooled);

            if (_hasCooledContainer && (selection.Place == 1 || selection.Place == 2))
            {
                List<Container> _tempCooledContainers = DockedContainers.FindAll(c => c.Cooled);

                foreach (Container container in _tempCooledContainers.ToList())
                {
                    if (selection.AddContainer(container))
                    {
                        _tempCooledContainers.Remove(container);
                        DockedContainers.Remove(container);
                    }
                }
            }
        }

        private void PlaceValueContainersOnBoat(Selection selection)
        {
            bool _hasValueContainer = DockedContainers.Exists(c => c.Valuable);

            if (_hasValueContainer && (selection.Place == 1 || selection.Place == 2 || selection.Place == 7 ||
                                       selection.Place == 8))
            {
                List<Container> _tempValueContainers = DockedContainers.FindAll(c => c.Valuable);

                foreach (Container container in _tempValueContainers.ToList())
                {
                    if (selection.AddContainer(container))
                    {
                        _tempValueContainers.Remove(container);
                        DockedContainers.Remove(container);
                    }
                }
            }
        }

        private void PlaceDefualtContainersOnBoat(Selection selection)
        {
            bool _hasDefualtContainer = DockedContainers.Exists(c => c.Standard);

            if (_hasDefualtContainer)
            {
                List<Container> _tempDefaultContainers = DockedContainers.FindAll(c => c.Standard);

                foreach (Container container in _tempDefaultContainers.ToList())
                {
                    if (selection.AddContainer(container))
                    {
                        _tempDefaultContainers.Remove(container);
                        DockedContainers.Remove(container);
                    }
                }
            }
        }

        private void PlaceContainersOnBoat()
        {
            for (int i = 0; i < 8; i++)
            {
                Selection selection = ship.Selections[i];
                PlaceValueContainersOnBoat(selection);
                PlaceCooledContainersOnBoat(selection);
                PlaceDefualtContainersOnBoat(selection);
            }
        }

        private void BalanceShip()
        {
            Enum Side;
            decimal _leftWeight = ship.GetTotalSides().Item1;
            decimal _rightWeight = ship.GetTotalSides().Item2;

            Side = _leftWeight > _rightWeight ? Selection.RowSide.left : Selection.RowSide.right;
            List<Selection> _HSelection = ship.Selections.FindAll(s => s.Side == (Selection.RowSide)Side);
            List<Selection> _LSelection = ship.Selections.FindAll(s => s.Side != (Selection.RowSide)Side);

            foreach (Selection _currentSelection in _LSelection)
            {
                foreach (Selection _HSSelection in _HSelection)
                {
                    foreach (Container container in _HSSelection.Containers.ToList())
                    {
                        if (ship.CalculateBalance())
                            break;
                        if (container.Valuable)
                            continue;
                        if (container.Cooled && !(_currentSelection.Place == 1 || _currentSelection.Place == 2))
                            continue;
                        if (_currentSelection.AddContainer(container))
                            _HSSelection.DeleteContainer(container);
                    }
                }
            }
        }
    }
}
