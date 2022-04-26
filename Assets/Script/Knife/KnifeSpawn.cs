using UnityEngine;

namespace CrazyEight
{
	public class KnifeSpawn : MonoBehaviour
	{
		[SerializeField] private KnifeData _knifeDataPrefab;

        private int _countAmmo;

        private void OnEnable()
        {
            AmmoCount.OnAmmoCount += GetCountAmmo;
            KnifeCollision.OnWood += Spawn;
            KnifeCollision.OnFail += StopSpawn;
        }
        private void OnDisable()
        {
            AmmoCount.OnAmmoCount -= GetCountAmmo;
            KnifeCollision.OnWood -= Spawn;
            KnifeCollision.OnFail -= StopSpawn;
        }

        private void GetCountAmmo(int countAmmo)
        {
            _countAmmo = countAmmo;
            Spawn();
        }

        private void Spawn()
        {
            if (_countAmmo > 0)
            {
                Instantiate(_knifeDataPrefab.PrefabKnife, transform.position, _knifeDataPrefab.PrefabKnife.transform.rotation);
                _countAmmo--;
            } 
        }
        private void StopSpawn()
        {
            Destroy(gameObject);
        }
    }
}
