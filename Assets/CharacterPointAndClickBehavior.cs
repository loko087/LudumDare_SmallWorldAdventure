using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;
public class CharacterPointAndClickBehavior : MonoBehaviour {

    public GameObject bigCharacter;
    public ThirdPersonCharacter thirdPersonController;
    
	// Use this for initialization
	void Start () {
        thirdPersonController = bigCharacter.GetComponent<ThirdPersonCharacter>();

	}
	
	// Update is called once per frame
	void Update () {

        	
        
	}

    
}
