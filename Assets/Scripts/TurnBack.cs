using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[ExecuteInEditMode]
public class TurnBack : MonoBehaviour
{
	public AudioSource aSource;
	
	public float adder;

	[Space(10)]
	[Header("Toggle for the gui on off")]
	public bool GuiOn;


	[Space(10)]
	[Header("The text to Display on Trigger")]
	[Tooltip("To edit the look of the text Go to Assets > Create > GUIskin. Add the new Guiskin to the Custom Skin proptery. If you select the GUIskin in your project tab you can now adjust the Label section to change this text")]
	public string Text = "Turn Back";

	[Tooltip("This is the window Box's size. It will be mid screen. Add or reduce the X and Y to move the box in Pixels. ")]
	public Rect BoxSize = new Rect(0, 0, 200, 100);


	[Space(10)]
	[Tooltip("To edit the look of the text Go to Assets > Create > GUIskin. Add the new Guiskin to the Custom Skin proptery. If you select the GUIskin in your project tab you can now adjust the font, colour, size etc of the text")]
	public GUISkin customSkin;

	//Check in zone;

	public bool playerInZone;
	public bool playerLooking;

	
	Score score;
	public GameObject UI;
	Animator animator;

	public Animator playerAni;
	void Awake()
	{
		score = UI.GetComponent<Score>();
		animator = playerAni.GetComponent<Animator>();
	}

	// if this script is on an object with a collider display the Gui
	void OnTriggerEnter()
	{
		playerInZone = true;
		
	}

    private void OnMouseEnter()
    {
		playerLooking = true;

	}

    private void OnMouseExit()
    {
		playerLooking = false;

	}


    void OnTriggerExit()
	{
		playerInZone = false;
	}

    private void Update()
    {
        if( playerInZone && playerLooking == true)
        {
			GuiOn = true;
		}
        else
        {
			GuiOn = false;
		}
    }

    void OnGUI()
	{

		animator.GetBool("PICKUP");

		if (customSkin != null)
		{
			GUI.skin = customSkin;
		}

		if (GuiOn == true)
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				aSource.Play();

				score.Points += adder;
				gameObject.SetActive(false);
				animator.SetBool("PICKUP", true);
				Invoke("aniReset", 0.2f);
			}
			
  
				
			

			// Make a group on the center of the screen
			GUI.BeginGroup(new Rect((Screen.width - BoxSize.width) / 2 + 50, (Screen.height - BoxSize.height) / 2 +50, BoxSize.width, BoxSize.height));
			// All rectangles are now adjusted to the group. (0,0) is the topleft corner of the group.

			GUI.Label(BoxSize, Text);

			// End the group we started above. This is very important to remember!
			GUI.EndGroup();

		}


	}

	void aniReset()
    {
		animator.SetBool("PICKUP", false);
	}
}