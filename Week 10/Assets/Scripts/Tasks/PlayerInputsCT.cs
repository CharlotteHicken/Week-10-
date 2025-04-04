using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class PlayerInputsCT : ConditionTask {

		public bool pressedStart = false;
		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
			if (Input.GetKey(KeyCode.Space))
			{
				pressedStart = true;
			}

			return pressedStart;
		}
	}
}