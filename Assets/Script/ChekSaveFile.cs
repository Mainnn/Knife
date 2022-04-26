using UnityEngine;
using System.IO;

namespace CrazyEight
{
	public class ChekSaveFile : MonoBehaviour
	{
		private string _filefName = "Save.txt";
		private string _filePath;
		
		private void Awake()
		{
#if UNITY_ANDROID && !UNITY_EDITOR
			_filePath = Path.Combine(Application.persistentDataPath, _filefName);
#else
			_filePath = Path.Combine(Application.dataPath, _filefName);
#endif
            Chek();
		}

		private void Chek()
        {
			if (!File.Exists(_filePath))
			{
				StreamWriter writer = new StreamWriter(_filePath);
				writer.WriteLine(0);
				writer.WriteLine(0);
				writer.WriteLine(0);
				writer.Close();

			}

        }
	}
}
