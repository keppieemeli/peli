using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;






namespace UnityStandardAssets.Utility
{
    [RequireComponent(typeof(Text))]

    public class SliderThing : MonoBehaviour
    {

        public Text CurrentFpsCap;
        public Slider FPSSlider;
        public float fpsCapp01;
        public int fpsCapp02;
        // Use this for initialization
        void Start()
        {
            FPSSlider.value = 30;
            fpsCapp01 = 30f;
            fpsCapp02 = 30;
            FPSSlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });

        }
        void ValueChangeCheck()
        {
            Debug.Log("Value:" + FPSSlider.value);
        }
        // Update is called once per frame
        void Update()
        {
            CurrentFpsCap.text = fpsCapp01.ToString();

            fpsCapp01 = FPSSlider.value;
            
            


            Application.targetFrameRate = (int)fpsCapp01;

            










          //  FPSSlider.value = fpsCapp01;
          // fpsCapp02 = fpsCapp01 = Mathf.RoundToInt(fpsCapp02);
          //  Application.targetFrameRate = fpsCapp02;
            // FPSSlider.value = Mathf.RoundToInt(fpsCapp01 = FPSSlider.value);
            //FPSSlider.value = fpsCapp01;
            //FPSSlider.value = Application.targetFrameRate;
           // CurrentFpsCap.text = fpsCapp02.ToString();

        }
    }
}