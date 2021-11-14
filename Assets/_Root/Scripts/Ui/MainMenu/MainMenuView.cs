using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Ui
{
    public class MainMenuView : MonoBehaviour
    {
        [SerializeField] private Button _buttonStart;
        [SerializeField] private Button _buttonSettings;


        public void Init(UnityAction startGame) =>
            _buttonStart.onClick.AddListener(startGame);

        public void Init1(UnityAction Settings) =>
            _buttonSettings.onClick.AddListener(Settings);

        public void OnDestroy() =>
            _buttonStart.onClick.RemoveAllListeners();


    }
}
