using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodManager : MonoBehaviour
{
   public bool canMove = false;

    public List<GameObject> foodTypes;

    private Vector3 _foodOriginalPos;
	private Quaternion _foodOriginalRotation;
	private Vector3 _foodOriginalLocalPos;

    public GameObject selectedFood;
      public GameObject spawnedFood;

void Awake(){
    
}
    // Start is called before the first frame update
    void Start()
    {
//          _foodOriginalPos = this.transform.position;
// 	_foodOriginalRotation = this.transform.rotation;
// selectedFood = foodTypes[Random.Range(0, foodTypes.Count)];
//           spawnedFood=  Instantiate(selectedFood, new Vector3(0, 0, 0), Quaternion.identity);

      StartCoroutine("MoveBox");
//       _foodOriginalPos = this.transform.position;
// 	_foodOriginalRotation = this.transform.rotation;
// selectedFood = foodTypes[Random.Range(0, foodTypes.Count)];
//             Instantiate(selectedFood, new Vector3(0, 0, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        // transform.Translate()
        if (canMove)
        {
            transform.position += Vector3.forward * Time.deltaTime;
        }

        if (transform.position.z >= 31.7f) {
            canMove = false;
        }
    }

    IEnumerator MoveBox()
    {
        // anim.SetBool("OpenDoor", true);
        yield return new WaitForSeconds(3);
        canMove = true;
       // transform.position += Vector3.forward * Time.deltaTime;
        //anim.SetBool("OpenDoor", false);
    }

    	public void ResetValues()
	{
        canMove = false;
	// 	transform.position = _foodOriginalPos;
	// 	transform.rotation = _foodOriginalRotation;
    //     Destroy(spawnedFood);
    //         spawnedFood = Instantiate(selectedFood, new Vector3(0, 0, 0), Quaternion.identity);
    //     //INSTANTIATE NEW FOODS
	// 		// Debug.Log("Resseting!!!!!!");
	}
}
