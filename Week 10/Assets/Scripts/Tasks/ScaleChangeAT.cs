using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ScaleChangeAT : ActionTask {

		public Transform transform;

		public float targetScale = 2f;

		private float originalScale;

        protected override string OnInit()
        {
			originalScale = transform.localScale.x;
			return null;
        }

        //This is called once each time the task is enabled.
        //Call EndAction() to mark the action as finished, either in success or failure.
        //EndAction can be called from anywhere.
        protected override void OnExecute() {
			
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			float stepValue = Mathf.PingPong(Time.time, 1f);

			float currentScale = Mathf.Lerp(originalScale, targetScale, stepValue);

			transform.localScale = new Vector3(currentScale, currentScale, currentScale);
			
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			transform.localScale = new Vector3(originalScale, originalScale, originalScale);
		}

	}
}