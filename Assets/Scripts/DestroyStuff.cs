using UnityEngine;
using System.Collections;

namespace AssemblyCSharp
{
	public class DestroyStuff : MonoBehaviour
	{
		public int scale = 10;
		void OnCollisionEnter (Collision col) {
			if (!col.gameObject.CompareTag("dead")) {
				Destroy (col.gameObject);
				for (int i = 0; i < scale; i++) {
					GameObject temp = (GameObject) Instantiate (col.gameObject, col.gameObject.transform.position, Random.rotation);
					temp.tag = "dead";
					temp.transform.localScale = new Vector3 (3.0f / scale, 3.0f / scale, 3.0f / scale);
				}
			}
		}
	}
}

