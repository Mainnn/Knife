using UnityEngine;
using UnityEngine.UI;

namespace CrazyEight
{
    public class UiLevel : MonoBehaviour
    {
        [SerializeField] private LoadFile _LoadfileReader;
        [SerializeField] private Text _moneyTxt;
        [SerializeField] private Text _scoreTxt;
        [SerializeField] private Text _stageTxt;
   
        public static int Money { get; private set; }
        public static int Score { get; private set; }
        public static int Stage { get; private set; }

        private void OnEnable()
        {
            KnifeCollision.OnWood += AddScore;
            ShadowAmmoUi.OnWin += AddStage;
            Aple.OnAple += AddMoney;
            LossePAnelButton.OnRestart += RestartLevel;
            KnifeCollision.OnFail += Fail;
        }
        private void OnDisable()
        {
            KnifeCollision.OnWood -= AddScore;
            ShadowAmmoUi.OnWin -= AddStage;
            Aple.OnAple -= AddMoney;
            LossePAnelButton.OnRestart -= RestartLevel;
            KnifeCollision.OnFail -= Fail;


        }
        private void Awake()
        {
            if(Stage == 0)
            {
                Stage = 1;
            }
            if(Money == 0)
            {
                Money = _LoadfileReader.ReadMoney;
            }

            LoadInfoUi();
        }

        private void LoadInfoUi()
        {
            _moneyTxt.text = Money.ToString();
            _scoreTxt.text = Score.ToString();
            _stageTxt.text = Stage.ToString();
        }
        private void AddMoney()
        {
            Money++;
            LoadInfoUi();
        }
        private void AddScore()
        {
            Score++;
            LoadInfoUi();
        }
        private void AddStage ()
        {
            //Handheld.Vibrate();
            Stage++;
            LoadInfoUi();
        }
        private void Fail()
        {
            Invoke(nameof(RestartLevel), 1);
        }
        private void RestartLevel()
        {
            Stage = 1;
            Score = 0;
        }

    }
}
