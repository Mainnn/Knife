using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace CrazyEight
{
	public class InputTach : MonoBehaviour
	{
        public static event Action OnTach;

        private void Update()
        {
#if UNITY_EDITOR
            if (Input.GetMouseButtonUp(0))
            {
                if (!EventSystem.current.IsPointerOverGameObject())
                {
                    OnTach?.Invoke();
                }
            }
#endif
#if UNITY_ANDROID
            if (Input.touchCount > 0 )
            {
                GetTouchInput();
            }
#endif
        }

        private void GetTouchInput()
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                        Debug.Log(EventSystem.current.tag);
                    if (!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                    {
                        OnTach?.Invoke();
                    }
                    break;
            }
        }
    }
}
