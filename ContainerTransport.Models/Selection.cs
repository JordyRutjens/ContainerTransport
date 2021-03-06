﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContainerTransport;

namespace ContainerTransport.Models
{
    public class Selection
    {
        public int Place { get; set; }
        public RowSide Side { get; set; }
        public bool ContainsValue { get; set; }
        public decimal SelectionWeight { get; set; }
        public decimal SelectionMaxweight { get; private set; } = 150000;
        public List<Container> Containers { get; set; } = new List<Container>();

        public enum RowSide
        {
            left,
            right
        }
        public bool AddContainer(Container model)
        {
            if (model.Valuable && ContainsValue)
                return false;

            decimal _newWeight = model.Weight + SelectionWeight;

            if (_newWeight <= SelectionMaxweight)
            {
                Containers.Add(model);
                SelectionWeight = _newWeight;

                if (model.Valuable)
                    ContainsValue = true;
                return true;
            }
            return false;
        }

        public bool DeleteContainer(Container model)
        {
            var deleted = Containers.Remove(model);

            if (!deleted) return false;

            SelectionWeight -= model.Weight;

            return true;
        }
    }
}
