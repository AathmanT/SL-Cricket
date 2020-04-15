using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerate : MonoBehaviour {
	// 0.907241173,0.962298025,0.955116697,0.950329144,0.931178935,0.935966487,0.933572711,0.897666068
// 0.976660682
// 0.950329144
// 0.962298025
// 0.940754039
// 0.959904249
// 0.95272292
// 0.933572711

	// Use this for initialization
	void Start () {
		
			// foreach (Transform child in transform)
            //  print("Foreach loop: " + child);
			
	}
	
	int n = 0;
	int i = 0;
    int[] array1 = new int[] { 1,1,1,1,1,1,1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1, 1,1,1,1,1,1,1};
	// Update is called once per frame
	void Update () {
		
		// print(Time.deltaTime);
		// if(n%30==0 && n<300 && n>0 && gameObject.name=="joint_HipLT"){
        //     transform.Rotate(3,0, zAngle: 0);
		// }else if(n==300){
		// 	n = -1*n;
        // }else if(n%30==0 && n<0 && n>-300 && gameObject.name=="joint_HipLT"){
		// 	transform.Rotate(-1*3,0, zAngle: 0);
		// }else{
		// 	n++;
		// }
		print(n);
		// if (i%30==0 && gameObject.name=="joint_HipRT"){
		// // if (n<14 && i%10==0 && gameObject.name=="joint_HipRT"){
		// 	transform.Rotate(array1[Random.Range(0, 13)]*1,0, zAngle: 0);
		// 	transform.Rotate(0,array1[Random.Range(0, 13)]*1, zAngle: 0);
		// 	transform.Rotate(0,0,array1[Random.Range(0, 13)]*1);

		// 	n++;
		// // }else if(n<28 && n>=13 && i%10==0 && gameObject.name=="joint_HipLT"){
		// }else if(i%30==0 && gameObject.name=="joint_HipLT"){
			
		// 	// transform.Rotate(array1[n]*3,0, zAngle: 0);
		// 	transform.Rotate(array1[Random.Range(0, 13)]*1,0, zAngle: 0);
		// 	transform.Rotate(0,array1[Random.Range(0, 13)]*1, zAngle: 0);
		// 	transform.Rotate(0,0,array1[Random.Range(0, 13)]*1);

		// 	n++;
		if(i%30==0 && gameObject.name=="joint_KneeRT"){
			
			// transform.Rotate(array1[n]*3,0, zAngle: 0);
			transform.Rotate(array1[Random.Range(0, 13)]*1,0, zAngle: 0);
			transform.Rotate(0,array1[Random.Range(0, 13)]*1, zAngle: 0);
			transform.Rotate(0,0,array1[Random.Range(0, 13)]*1);

			n++;
		}else if(i%30==0 && gameObject.name=="joint_KneeLT"){
			
			// transform.Rotate(array1[n]*3,0, zAngle: 0);
			transform.Rotate(array1[Random.Range(0, 13)]*1,0, zAngle: 0);
			transform.Rotate(0,array1[Random.Range(0, 13)]*1, zAngle: 0);
			transform.Rotate(0,0,array1[Random.Range(0, 13)]*1);

			n++;
		}
		
		i++;
		
	}
}
