using UnityEngine;
using UnityEngine.UI;

namespace CrazyEight
{
	public class MenuUi : MonoBehaviour 
	{
		[SerializeField] private LoadFile _LoadfileReader;
		[SerializeField] private Text _moneyTxt;
		[SerializeField] private Text _scoreTxt;
		[SerializeField] private Text _stageTxt;

		private void Start()
        {
			_LoadfileReader.ReadInfo();
			LoadInfoUi();

		}

        public void LoadInfoUi()
        {
			_moneyTxt.text = _LoadfileReader.ReadMoney.ToString();
			_scoreTxt.text = "SCORE " + _LoadfileReader.ReadScore.ToString();
			_stageTxt.text = "STAGE " + _LoadfileReader.ReadStage.ToString();
		}

       

    }
}
