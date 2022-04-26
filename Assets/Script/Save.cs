using System.IO;
using UnityEngine;

namespace CrazyEight
{
	public class Save : MonoBehaviour
	{
        [SerializeField] private LoadFile load;

        private int _money =>load.ReadMoney;
        private int _score =>load.ReadScore;
        private int _stage =>load.ReadStage;

        private void OnEnable()
        {
            LossePAnelButton.OnSave += CheckStatistics;
            KnifeCollision.OnFail += CheckStatistics;
        }
        private void OnDisable()
        {
            LossePAnelButton.OnSave -= CheckStatistics;
            KnifeCollision.OnFail -= CheckStatistics;
        }

        private string _filefName = "Save.txt";
        private string _filePath;

        private void Awake()
        {
#if UNITY_ANDROID && !UNITY_EDITOR
			_filePath = Path.Combine(Application.persistentDataPath, _filefName);
#else
            _filePath = Path.Combine(Application.dataPath, _filefName);
#endif
        }

        private void CheckStatistics()
        {
            StreamWriter writer = new StreamWriter(_filePath);
            if (UiLevel.Money > _money)
            {
                writer.WriteLine(UiLevel.Money);
            }
            else
            {
                writer.WriteLine(_money);
            }
            if(UiLevel.Score > _score)
            {
                writer.WriteLine(UiLevel.Score);
                writer.WriteLine(UiLevel.Stage);
            }
            else
            {
                writer.WriteLine(_score);
                writer.WriteLine(_stage);
            }
            writer.Close();
        }
    }
}
