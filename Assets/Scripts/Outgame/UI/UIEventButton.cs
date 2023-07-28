using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Outgame
{
    public class UIEventButton : UIView
    {
        private void Awake()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
        }
        public void Show()
        {
            Active();
        }

        public void Hide()
        {
            Disactive();
        }
    }
}