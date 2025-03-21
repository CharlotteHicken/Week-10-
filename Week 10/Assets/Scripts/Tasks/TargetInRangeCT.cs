using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Conditions {

	public class TargetInRangeCT : ConditionTask {

        public BBParameter<Transform> currentTransform;
        public float radius;
		bool atLine = false;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
            float distanceToTarget = Mathf.Abs(agent.transform.position.x - currentTransform.value.position.x);

			if (distanceToTarget < radius)
			{
				atLine = true;
			}

			return atLine;
        }
	}
}