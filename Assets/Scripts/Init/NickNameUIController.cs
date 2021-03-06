﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CatTower
{
    public class NickNameUIController : MonoBehaviour
    {
        [SerializeField] NickNameController controller = null;
        [SerializeField] InputField inputField = null;
        [SerializeField] Button okButton = null;
        [SerializeField] Text warnText = null;

        // Start is called before the first frame update
        void Start()
        {
            warnText.gameObject.SetActive(false);
            okButton.onClick.AddListener(OkButtonClicked);
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OkButtonClicked()
        {
            if (string.IsNullOrEmpty(inputField.text))
            {
                warnText.gameObject.SetActive(true);
                return;
            }
            controller.UpdateUserInfo(inputField.text);

        }
    }
}