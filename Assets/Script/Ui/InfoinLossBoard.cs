using UnityEngine;
using UnityEngine.UI;

namespace CrazyEight
{
	public class InfoinLossBoard : MonoBehaviour
	{
		[SerializeField] private Text _moneyTxt;
		[SerializeField] private Text _scoreTxt;
		[SerializeField] private Text _stageTxt;
	
		private void Awake()
        {
			LoadInfo();
		}

		private void LoadInfo()
        {
			_moneyTxt.text ="Money : " + UiLevel.Money.ToString();
			_scoreTxt.text ="Score : " + UiLevel.Score.ToString();
			_stageTxt.text ="STAGE : " + UiLevel.Stage.ToString();
		}
	}
}
