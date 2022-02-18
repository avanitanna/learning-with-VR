using OpenAI_API;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.XR;


namespace OpenAI_Unity
{
    /// <summary>
    /// Allows us to communicate with the Completion engine without any presets
    /// </summary>
    public class OAIGenericCompletion : OAICompletion
    {
        [SerializeField, Tooltip("Used to send data next frame. Can be useful when testing")]
        private bool addToStoryNextFrame;

        [SerializeField, TextArea(5, 20)]
        private string _description;
        public override string Description { get => _description; set => _description = value; }

        [SerializeField]
        private string _appendToQuestion;
        public override string InjectStartText { get => _appendToQuestion; set => _appendToQuestion = value; }

        [SerializeField]
        private string _appendToResponse;
        public override string InjectRestartText { get => _appendToResponse; set => _appendToResponse = value; }

        [SerializeField]
        private string[] _stopSequences;
        public override string[] StopSequences { get => _stopSequences; set => _stopSequences = value; }

        [SerializeField]
        private int _numOutputs;
        public override int NumOutputs { get => _numOutputs; set => _numOutputs = value; }

        public Text inputText;
        public Text outputText;

        private bool active = false;

        private float time = 0f;

        private InputDevice targetDevice;

        private void Update()
        {
            // targetDevice.TryGetFeatureValue(CommonUsages.grip, out float enableValue);
            //
            // _description = inputText.text;
            if (Time.time - time > 3f)//(enableValue > 0.1f && !active)|| Input.GetKeyDown(KeyCode.K))
            {
                addToStoryNextFrame = false;
                AddToStory(_description);
                string response = getMemory().ToString();
                outputText.text = response;
                active = true;
                
                time = Time.time;
            }
        }
    }
}