using System;
using System.Collections.ObjectModel;

namespace MemoryLeak
{
	public class ObservableDataCollection
	{
        public ObservableCollection<DataElement> Collection { get; private set; }
        public int CollectionSize { get; private set; }
        private static int CallsCount { get; set; } = 0;

        public ObservableDataCollection()
		{
            Collection = new();
            RefreshCollection();

        }

        public void RefreshCollection()
        {
            int CollectionSize = (new Random()).Next(80, 120);

            Collection.Clear();
            for (var i = 0; i < CollectionSize; i++)
            {
                Collection.Add(
                    new DataElement { IconFileName = "iron_white.png", SubTitle = $"Sub{i + CallsCount}", Title = $"Title{i + CallsCount}" });
            }
            CallsCount++;
        }
	}
}