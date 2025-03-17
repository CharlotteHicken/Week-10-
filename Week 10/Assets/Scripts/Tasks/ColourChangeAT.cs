using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ColourChangeAT : ActionTask {

		private Color startColor;
		public Renderer renderer;
		public float durationInSeconds = 1f;

		private float startTime;

		public Color targetColor = Color.white;

		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit() {
			startColor = renderer.material.color;
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			startTime = Time.time;
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			float elapsedTime = Time.time - startTime;
			float stepValue = Mathf.PingPong(Time.time, 1f);

			renderer.material.color = Color.Lerp(startColor, targetColor, stepValue);
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			renderer.material.color = startColor;
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}