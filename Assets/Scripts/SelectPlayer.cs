using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayer : MonoBehaviour
{
    public static int SelectedPlayerNumb;
    public GameObject PlayerObject;

    public Material GrassBallMat;
    public Material LeatherBallMat;
    public Material PaperBallMat;
    public Material SandBallMat;
    public Material WoodenBallMat;
    public Material DenimBallMat;
    public Material StoneBallMat;
    public Material SoftBallMat;
    public Material TennisBallMat;
    public Material ColorBallMat;


    void Start()
    {
        SelectedPlayerNumb = Player.SelectedPlayerNumb;

        if (SelectedPlayerNumb == 1)
        {
            PlayerObject.GetComponent<MeshRenderer>().material = GrassBallMat;
        }
        else if (SelectedPlayerNumb == 2)
        {
            PlayerObject.GetComponent<MeshRenderer>().material = LeatherBallMat;
        }
        else if (SelectedPlayerNumb == 3)
        {
            PlayerObject.GetComponent<MeshRenderer>().material = PaperBallMat;
        }
        else if (SelectedPlayerNumb == 4)
        {
            PlayerObject.GetComponent<MeshRenderer>().material = SandBallMat;
        }
        else if (SelectedPlayerNumb == 5)
        {
            PlayerObject.GetComponent<MeshRenderer>().material = WoodenBallMat;
        }
        else if (SelectedPlayerNumb == 6)
        {
            PlayerObject.GetComponent<MeshRenderer>().material = DenimBallMat;
        }
        else if (SelectedPlayerNumb == 7)
        {
            PlayerObject.GetComponent<MeshRenderer>().material = StoneBallMat;
        }
        else if (SelectedPlayerNumb == 8)
        {
            PlayerObject.GetComponent<MeshRenderer>().material = SoftBallMat;
        }
        else if (SelectedPlayerNumb == 9)
        {
            PlayerObject.GetComponent<MeshRenderer>().material = TennisBallMat;
        }
        else if (SelectedPlayerNumb == 10)
        {
            PlayerObject.GetComponent<MeshRenderer>().material = ColorBallMat;
        }

    }
}
