using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour {
	public float damage = 10;

	void OnTriggerEnter(Collider col){
		if (col.CompareTag ("Player") || col.CompareTag ("Enemy")) {
            if (!col.name.Contains(transform.tag)){
                HP hp = col.gameObject.GetComponent<HP>();
                if (hp != null) {
                    hp.TakeDamage(damage);
                }
            }
			Destroy (gameObject);
		}
	}
}
