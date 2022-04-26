using UnityEngine;
using UnityEngine.UI;

namespace CrazyEight
{
	public class StageUi : MonoBehaviour
	{
		[SerializeField] private Color _color;
		[SerializeField] private Image[] _imageStage;

        private void Start()
        {
            int stage = UiLevel.Stage;
            if (stage <= 4)
            {
                for (int i = 0; i < stage; i++)
                {
                    _imageStage[i].color = _color;
                }

            }
            
        }
    }
}
