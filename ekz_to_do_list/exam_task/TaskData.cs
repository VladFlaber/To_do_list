using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace exam_task
{
	[Serializable]
	public class TaskData
	{
		public List<Task> tasks_to_add = null;
		public string path_data = "data/list.dat";
		BinaryFormatter formatter = null;
		public TaskData()
		{
			formatter = new BinaryFormatter();
			//tasks_to_add = new List<Task>();
			tasks_to_add = DeserializeData();
		}

		public void SerializeData()
		{
			// создаем объект BinaryFormatter
			formatter = new BinaryFormatter();
			// получаем поток, куда будем записывать сериализованный объект
			using (FileStream fs = new FileStream(path_data, FileMode.OpenOrCreate))
			{
				formatter.Serialize(fs, tasks_to_add);
			}
		}

		public List<Task> DeserializeData()
		{
			List<Task> list = null;
			using (FileStream fs = new FileStream(path_data, FileMode.Open))
			{
				list = (List<Task>)formatter.Deserialize(fs);
			}
			return list;
		}
	}
}
