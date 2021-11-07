using System.Collections.Generic;

namespace Enums1
{
    class OrderSystem
    {
        private List<Sweater> _sweaters;

        public OrderSystem()
        {
            _sweaters = new List<Sweater>()
            {
                new Sweater() { Title = "Red sweater", Size = "Small" },
                new Sweater() { Title = "Blue sweater", Size = "Small" },
                new Sweater() { Title = "Christmas sweater", Size = "Medium" },
            };
        }

        public List<Sweater> ListSweaters(string size)
        {
            List<Sweater> result = new List<Sweater>();
            foreach (Sweater sweater in _sweaters)
            {
                if (sweater.Size == size)
                {
                    result.Add(sweater);
                }
            }
            return result;
        }

        public void AddSweater(string title, string size)
        {
            Sweater newSweater = new Sweater()
            {
                Title = title,
                Size = size
            };
            _sweaters.Add(newSweater);
        }
    }
}
