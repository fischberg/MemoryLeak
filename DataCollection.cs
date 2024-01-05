using System;
namespace MemoryLeak
{
	public class DataCollection
	{
		public List<DataElement> Collection { get; private set; }

		public DataCollection()
		{
			Collection = new();

			for(var i=0; i<1000; i++ ) {
				Collection.Add(
					new DataElement { IconFileName = "iron_white.png", SubTitle = $"Sub{i}", Title = $"Title{i}" });
			}

		}
	}
}

