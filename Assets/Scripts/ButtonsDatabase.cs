using UnityEngine;
using UnityEngine.UI;

public class ButtonsDatabase : MonoBehaviour {
	public Image button1Image;
	public Image button2Image;
	public Image button3Image;
	public Image button4Image;
	public Image button5Image;
	public Image button6Image;
	public Image button7Image;
	public Image button8Image;
	public Image button9Image;

	public bool button1IsEmpty = true;
	public bool button2IsEmpty = true;
	public bool button3IsEmpty = true;
	public bool button4IsEmpty = true;
	public bool button5IsEmpty = true;
	public bool button6IsEmpty = true;
	public bool button7IsEmpty = true;
	public bool button8IsEmpty = true;
	public bool button9IsEmpty = true;

	// Use this for initialization
	void Start () {
		button1Image = button1Image.GetComponent<Image>();
		button2Image = button2Image.GetComponent<Image>();
		button3Image = button3Image.GetComponent<Image>();
		button4Image = button4Image.GetComponent<Image>();
		button5Image = button5Image.GetComponent<Image>();
		button6Image = button6Image.GetComponent<Image>();
		button7Image = button7Image.GetComponent<Image>();
		button8Image = button8Image.GetComponent<Image>();
		button9Image = button9Image.GetComponent<Image>();
	}

}
