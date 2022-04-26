using UnityEngine;

namespace CrazyEight
{

	public class SpawnAple : MonoBehaviour
	{
        [SerializeField] private ApleData _apleData;

        private void Start()
        {
            if (_apleData == null)
            {
                ReadAllData();
            }
            SpawnApleData();
        }
        private void ReadAllData()
        {
            var allApleDatas = Resources.LoadAll<ApleData>("Data/");
            var random = Random.Range(0, allApleDatas.Length);
            _apleData = allApleDatas[random];
        }

        private void SpawnApleData()
        {
            if (_apleData.ChangeSpawn >= Random.Range(0.01f, 1.0f))
            {
                GameObject aple = Instantiate(_apleData.Prefab, transform.position, transform.rotation);
                aple.transform.SetParent(transform);
            }
        }
    }
}
