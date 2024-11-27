//Shady
using UnityEngine;

[ExecuteInEditMode]
public class Reveal : MonoBehaviour
{
    [SerializeField] Material Mat;
    [SerializeField] Light luzlint;
	
	void Update ()
    {
        if(Mat && luzlint){ 
        Mat.SetVector("MyLightPosition",  luzlint.transform.position);
        Mat.SetVector("MyLightDirection", -luzlint.transform.forward );
        Mat.SetFloat ("MyLightAngle", luzlint.spotAngle         );
        }
    }//Update() end
}//class end