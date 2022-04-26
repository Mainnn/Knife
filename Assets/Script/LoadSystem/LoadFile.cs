using System.IO;
using UnityEngine;


namespace CrazyEight
{
	public class LoadFile : MonoBehaviour
	{
		private string _filefName = "Save.txt";
        private string _filePath;

        private int _money;
        private int _score;
        private int _stage;

        public int ReadMoney => this._money;
        public int ReadScore => this._score;
        public int ReadStage => this._stage;

        private void Awake()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
			_filePath = Path.Combine(Application.persistentDataPath, _filefName);
#else
            _filePath = Path.Combine(Application.dataPath, _filefName);
#endif
            ReadInfo();
        }
        public void ReadInfo()
        {
            StreamReader reader = new StreamReader(_filePath);
            _money = int.Parse(reader.ReadLine());
            _score = int.Parse(reader.ReadLine());
            _stage = int.Parse(reader.ReadLine());
            reader.Close();
        }
    }
}
