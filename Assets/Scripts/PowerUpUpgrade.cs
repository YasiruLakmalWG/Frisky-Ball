using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpUpgrade : MonoBehaviour
{
    public static int NumbCoins;

    [SerializeField]
    public static float powerUp1time;
    public int powerup1Value;
    public static int powerup1currentLevel;
    public Text powerUp1Val;
    public Text PU1im1 , PU1im2, PU1im3, PU1im4, PU1im5, PU1im6, PU1im7, PU1im8;

    [SerializeField]
    public static float powerUp2time;
    public int powerup2Value;
    public static int powerup2currentLevel;
    public Text powerUp2Val;
    public Text PU2im1, PU2im2, PU2im3, PU2im4, PU2im5, PU2im6, PU2im7, PU2im8;

    [SerializeField]
    public static float freezetime;
    public int freezeValue;
    public static int FreezecurrentLevel;
    public Text freezeVal;
    public Text Fim1, Fim2, Fim3, Fim4, Fim5, Fim6, Fim7, Fim8;

    [SerializeField]
    public static float ICtime;
    public int ICValue;
    public static int ICcurrentLevel;
    public Text ICVal;
    public Text ICim1, ICim2, ICim3, ICim4, ICim5, ICim6, ICim7, ICim8;

    [SerializeField]
    public static float IStime;
    public int ISValue;
    public static int IScurrentLevel;
    public Text ISVal;
    public Text ISim1, ISim2, ISim3, ISim4, ISim5, ISim6, ISim7, ISim8;

    [SerializeField]
    public static float CDtime;
    public int CDValue;
    public static int CDcurrentLevel;
    public Text CDVal;
    public Text CDim1, CDim2, CDim3, CDim4, CDim5, CDim6, CDim7, CDim8;

    // Start is called before the first frame update
    void Start()
    {
        powerup1currentLevel = Player.powerup1currentLevel;
        powerup2currentLevel = Player.powerup2currentLevel;
        FreezecurrentLevel = Player.FreezecurrentLevel;
        ICcurrentLevel = Player.ICcurrentLevel;
        IScurrentLevel = Player.IScurrentLevel;
        CDcurrentLevel = Player.CDcurrentLevel;
        //Debug.Log(powerup1currentLevel);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 9; i++)
        {
            if (powerup1currentLevel == i)
            {
                powerup1Value = 100 + 150 * i;
                powerUp1time = 6f + 3f * i;
                powerUp1Val.text = powerup1Value.ToString();
                PU1Method();
            }
            if (powerup2currentLevel == i)
            {
                powerup2Value = 100 + 150 * i;
                powerUp2time = 6f + 3f * i;
                powerUp2Val.text = powerup2Value.ToString();
                PU2Method();
            }
            if (FreezecurrentLevel == i)
            {
                freezeValue = 100 + 150 * i;
                freezetime = 6f + 3f * i;
                freezeVal.text = freezeValue.ToString();
                FMethod();
            }
            if (ICcurrentLevel == i)
            {
                ICValue = 100 + 150 * i;
                ICtime = 6f + 3f * i;
                ICVal.text = ICValue.ToString();
                ICMethod();
            }
            if (IScurrentLevel == i)
            {
                ISValue = 100 + 150 * i;
                IStime = 6f + 3f * i;
                ISVal.text = ISValue.ToString();
                ISMethod();
            }
            if (CDcurrentLevel == i)
            {
                CDValue = 100 + 150 * i;
                CDtime = 6f + 3f * i;
                CDVal.text = CDValue.ToString();
                CDMethod();
            }
        }
    }
    private void PU1Method()
    {
        if (powerup1currentLevel == 0) {   PU1im1.text = "9s" ; }
        if (powerup1currentLevel == 1) {   PU1im2.text = "12s"; PU1im1.text = "9s"; PU1im1.color = Color.grey; }
        if (powerup1currentLevel == 2) {   PU1im3.text = "15s"; PU1im2.text = "12s"; PU1im1.text = "9s"; PU1im1.color = Color.grey; PU1im2.color = Color.grey; }
        if (powerup1currentLevel == 3) {   PU1im4.text = "18s"; PU1im3.text = "15s"; PU1im2.text = "12s"; PU1im1.text = "9s"; PU1im1.color = Color.grey;
            PU1im2.color = Color.grey; PU1im3.color = Color.grey; }
        if (powerup1currentLevel == 4) {   PU1im5.text = "21s"; PU1im4.text = "18s"; PU1im3.text = "15s"; PU1im2.text = "12s"; PU1im1.text = "9s";
            PU1im1.color = Color.grey; PU1im2.color = Color.grey; PU1im3.color = Color.grey; PU1im4.color = Color.grey; }
        if (powerup1currentLevel == 5) {   PU1im6.text = "24s"; PU1im5.text = "21s"; PU1im4.text = "18s"; PU1im3.text = "15s"; PU1im2.text = "12s";
            PU1im1.text = "9s"; PU1im1.color = Color.grey; PU1im2.color = Color.grey; PU1im3.color = Color.grey; PU1im4.color = Color.grey; PU1im5.color = Color.grey; }
        if (powerup1currentLevel == 6) {   PU1im7.text = "27s"; PU1im6.text = "24s"; PU1im5.text = "21s"; PU1im4.text = "18s"; PU1im3.text = "15s"; PU1im2.text = "12s";
            PU1im1.text = "9s"; PU1im1.color = Color.grey; PU1im2.color = Color.grey; PU1im3.color = Color.grey; PU1im4.color = Color.grey; PU1im5.color = Color.grey; PU1im6.color = Color.grey; }
        if (powerup1currentLevel == 7) {   PU1im8.text = "30s"; PU1im7.text = "27s"; PU1im6.text = "24s"; PU1im5.text = "21s"; PU1im4.text = "18s"; PU1im3.text = "15s"; PU1im2.text = "12s";
            PU1im1.text = "9s"; PU1im1.color = Color.grey; PU1im2.color = Color.grey; PU1im3.color = Color.grey; PU1im4.color = Color.grey; PU1im5.color = Color.grey; PU1im6.color = Color.grey; PU1im7.color = Color.grey; }
        if (powerup1currentLevel == 8) {
            PU1im8.text = "30s"; PU1im7.text = "27s"; PU1im6.text = "24s"; PU1im5.text = "21s"; PU1im4.text = "18s"; PU1im3.text = "15s"; PU1im2.text = "12s"; powerUp1Val.text = "Fully Upgrated";
            PU1im1.text = "9s"; PU1im1.color = Color.grey; PU1im2.color = Color.grey; PU1im3.color = Color.grey; PU1im4.color = Color.grey; PU1im5.color = Color.grey; PU1im6.color = Color.grey; PU1im7.color = Color.grey; PU1im8.color = Color.grey; }

    }
    private void PU2Method()
    {
        if (powerup2currentLevel == 0) { PU2im1.text = "9s"; }
        if (powerup2currentLevel == 1) { PU2im2.text = "12s"; PU2im1.text = "9s"; PU2im1.color = Color.grey; }
        if (powerup2currentLevel == 2) { PU2im3.text = "15s"; PU2im2.text = "12s"; PU2im1.text = "9s"; PU2im1.color = Color.grey; PU2im2.color = Color.grey; }
        if (powerup2currentLevel == 3)
        {
            PU2im4.text = "18s"; PU2im3.text = "15s"; PU2im2.text = "12s"; PU2im1.text = "9s"; PU2im1.color = Color.grey;
            PU2im2.color = Color.grey; PU2im3.color = Color.grey;
        }
        if (powerup2currentLevel == 4)
        {
            PU2im5.text = "21s"; PU2im4.text = "18s"; PU2im3.text = "15s"; PU2im2.text = "12s"; PU2im1.text = "9s";
            PU2im1.color = Color.grey; PU2im2.color = Color.grey; PU2im3.color = Color.grey; PU2im4.color = Color.grey;
        }
        if (powerup2currentLevel == 5)
        {
            PU2im6.text = "24s"; PU2im5.text = "21s"; PU2im4.text = "18s"; PU2im3.text = "15s"; PU2im2.text = "12s";
            PU2im1.text = "9s"; PU2im1.color = Color.grey; PU2im2.color = Color.grey; PU2im3.color = Color.grey; PU2im4.color = Color.grey; PU2im5.color = Color.grey;
        }
        if (powerup2currentLevel == 6)
        {
            PU2im7.text = "27s"; PU2im6.text = "24s"; PU2im5.text = "21s"; PU2im4.text = "18s"; PU2im3.text = "15s"; PU2im2.text = "12s";
            PU2im1.text = "9s"; PU2im1.color = Color.grey; PU2im2.color = Color.grey; PU2im3.color = Color.grey; PU2im4.color = Color.grey; PU2im5.color = Color.grey; PU2im6.color = Color.grey;
        }
        if (powerup2currentLevel == 7)
        {
            PU2im8.text = "30s"; PU2im7.text = "27s"; PU2im6.text = "24s"; PU2im5.text = "21s"; PU2im4.text = "18s"; PU2im3.text = "15s"; PU2im2.text = "12s";
            PU2im1.text = "9s"; PU2im1.color = Color.grey; PU2im2.color = Color.grey; PU2im3.color = Color.grey; PU2im4.color = Color.grey; PU2im5.color = Color.grey; PU2im6.color = Color.grey; PU2im7.color = Color.grey;
        }
        if (powerup2currentLevel == 8)
        {
            PU2im8.text = "30s"; PU2im7.text = "27s"; PU2im6.text = "24s"; PU2im5.text = "21s"; PU2im4.text = "18s"; PU2im3.text = "15s"; PU2im2.text = "12s"; powerUp2Val.text = "Fully Upgrated";
            PU2im1.text = "9s"; PU2im1.color = Color.grey; PU2im2.color = Color.grey; PU2im3.color = Color.grey; PU2im4.color = Color.grey; PU2im5.color = Color.grey; PU2im6.color = Color.grey; PU2im7.color = Color.grey; PU2im8.color = Color.grey;
        }

    }
    private void FMethod()
    {
        if (FreezecurrentLevel == 0) { Fim1.text = "9s"; }
        if (FreezecurrentLevel == 1) { Fim2.text = "12s"; Fim1.text = "9s"; Fim1.color = Color.grey; }
        if (FreezecurrentLevel == 2) { Fim3.text = "15s"; Fim2.text = "12s"; Fim1.text = "9s"; Fim1.color = Color.grey; Fim2.color = Color.grey; }
        if (FreezecurrentLevel == 3)
        {
            Fim4.text = "18s"; Fim3.text = "15s"; Fim2.text = "12s"; Fim1.text = "9s"; Fim1.color = Color.grey;
            Fim2.color = Color.grey; Fim3.color = Color.grey;
        }
        if (FreezecurrentLevel == 4)
        {
            Fim5.text = "21s"; Fim4.text = "18s"; Fim3.text = "15s"; Fim2.text = "12s"; Fim1.text = "9s";
            Fim1.color = Color.grey; Fim2.color = Color.grey; Fim3.color = Color.grey; Fim4.color = Color.grey;
        }
        if (FreezecurrentLevel == 5)
        {
            Fim6.text = "24s"; Fim5.text = "21s"; Fim4.text = "18s"; Fim3.text = "15s"; Fim2.text = "12s";
            Fim1.text = "9s"; Fim1.color = Color.grey; Fim2.color = Color.grey; Fim3.color = Color.grey; Fim4.color = Color.grey; Fim5.color = Color.grey;
        }
        if (FreezecurrentLevel == 6)
        {
            Fim7.text = "27s"; Fim6.text = "24s"; Fim5.text = "21s"; Fim4.text = "18s"; Fim3.text = "15s"; Fim2.text = "12s";
            Fim1.text = "9s"; Fim1.color = Color.grey; Fim2.color = Color.grey; Fim3.color = Color.grey; Fim4.color = Color.grey; Fim5.color = Color.grey; Fim6.color = Color.grey;
        }
        if (FreezecurrentLevel == 7)
        {
            Fim8.text = "30s"; Fim7.text = "27s"; Fim6.text = "24s"; Fim5.text = "21s"; Fim4.text = "18s"; Fim3.text = "15s"; Fim2.text = "12s";
            Fim1.text = "9s"; Fim1.color = Color.grey; Fim2.color = Color.grey; Fim3.color = Color.grey; Fim4.color = Color.grey; Fim5.color = Color.grey; Fim6.color = Color.grey; Fim7.color = Color.grey;
        }
        if (FreezecurrentLevel == 8)
        {
            Fim8.text = "30s"; Fim7.text = "27s"; Fim6.text = "24s"; Fim5.text = "21s"; Fim4.text = "18s"; Fim3.text = "15s"; Fim2.text = "12s"; freezeVal.text = "Fully Upgrated";
            Fim1.text = "9s"; Fim1.color = Color.grey; Fim2.color = Color.grey; Fim3.color = Color.grey; Fim4.color = Color.grey; Fim5.color = Color.grey; Fim6.color = Color.grey; Fim7.color = Color.grey; Fim8.color = Color.grey;
        }

    }
    private void ICMethod()
    {
        if (ICcurrentLevel == 0) { ICim1.text = "9s"; }
        if (ICcurrentLevel == 1) { ICim2.text = "12s"; ICim1.text = "9s"; ICim1.color = Color.grey; }
        if (ICcurrentLevel == 2) { ICim3.text = "15s"; ICim2.text = "12s"; ICim1.text = "9s"; ICim1.color = Color.grey; ICim2.color = Color.grey; }
        if (ICcurrentLevel == 3)
        {
            ICim4.text = "18s"; ICim3.text = "15s"; ICim2.text = "12s"; ICim1.text = "9s"; ICim1.color = Color.grey;
            ICim2.color = Color.grey; ICim3.color = Color.grey;
        }
        if (ICcurrentLevel == 4)
        {
            ICim5.text = "21s"; ICim4.text = "18s"; ICim3.text = "15s"; ICim2.text = "12s"; ICim1.text = "9s";
            ICim1.color = Color.grey; ICim2.color = Color.grey; ICim3.color = Color.grey; ICim4.color = Color.grey;
        }
        if (ICcurrentLevel == 5)
        {
            ICim6.text = "24s"; ICim5.text = "21s"; ICim4.text = "18s"; ICim3.text = "15s"; ICim2.text = "12s";
            ICim1.text = "9s"; ICim1.color = Color.grey; ICim2.color = Color.grey; ICim3.color = Color.grey; ICim4.color = Color.grey; ICim5.color = Color.grey;
        }
        if (ICcurrentLevel == 6)
        {
            ICim7.text = "27s"; ICim6.text = "24s"; ICim5.text = "21s"; ICim4.text = "18s"; ICim3.text = "15s"; ICim2.text = "12s";
            ICim1.text = "9s"; ICim1.color = Color.grey; ICim2.color = Color.grey; ICim3.color = Color.grey; ICim4.color = Color.grey; ICim5.color = Color.grey; ICim6.color = Color.grey;
        }
        if (ICcurrentLevel == 7)
        {
            ICim8.text = "30s"; ICim7.text = "27s"; ICim6.text = "24s"; ICim5.text = "21s"; ICim4.text = "18s"; ICim3.text = "15s"; ICim2.text = "12s";
            ICim1.text = "9s"; ICim1.color = Color.grey; ICim2.color = Color.grey; ICim3.color = Color.grey; ICim4.color = Color.grey; ICim5.color = Color.grey; ICim6.color = Color.grey; ICim7.color = Color.grey;
        }
        if (ICcurrentLevel == 8)
        {
            ICim8.text = "30s"; ICim7.text = "27s"; ICim6.text = "24s"; ICim5.text = "21s"; ICim4.text = "18s"; ICim3.text = "15s"; ICim2.text = "12s"; ICVal.text = "Fully Upgrated";
            ICim1.text = "9s"; Fim1.color = Color.grey; ICim2.color = Color.grey; ICim3.color = Color.grey; ICim4.color = Color.grey; ICim5.color = Color.grey; ICim6.color = Color.grey; ICim7.color = Color.grey; ICim8.color = Color.grey;
        }

    }
    private void ISMethod()
    {
        if (IScurrentLevel == 0) { ISim1.text = "9s"; }
        if (IScurrentLevel == 1) { ISim2.text = "12s"; ISim1.text = "9s"; ISim1.color = Color.grey; }
        if (IScurrentLevel == 2) { ISim3.text = "15s"; ISim2.text = "12s"; ISim1.text = "9s"; ISim1.color = Color.grey; ISim2.color = Color.grey; }
        if (IScurrentLevel == 3)
        {
            ISim4.text = "18s"; ISim3.text = "15s"; ISim2.text = "12s"; ISim1.text = "9s"; ISim1.color = Color.grey;
            ISim2.color = Color.grey; ISim3.color = Color.grey;
        }
        if (IScurrentLevel == 4)
        {
            ISim5.text = "21s"; ISim4.text = "18s"; ISim3.text = "15s"; ISim2.text = "12s"; ISim1.text = "9s";
            ISim1.color = Color.grey; ISim2.color = Color.grey; ISim3.color = Color.grey; ISim4.color = Color.grey;
        }
        if (IScurrentLevel == 5)
        {
            ISim6.text = "24s"; ISim5.text = "21s"; ISim4.text = "18s"; ISim3.text = "15s"; ISim2.text = "12s";
            ISim1.text = "9s"; ISim1.color = Color.grey; ISim2.color = Color.grey; ISim3.color = Color.grey; ISim4.color = Color.grey; ISim5.color = Color.grey;
        }
        if (IScurrentLevel == 6)
        {
            ISim7.text = "27s"; ISim6.text = "24s"; ISim5.text = "21s"; ISim4.text = "18s"; ISim3.text = "15s"; ISim2.text = "12s";
            ISim1.text = "9s"; ISim1.color = Color.grey; ISim2.color = Color.grey; ISim3.color = Color.grey; ISim4.color = Color.grey; ISim5.color = Color.grey; ISim6.color = Color.grey;
        }
        if (IScurrentLevel == 7)
        {
            ISim8.text = "30s"; ISim7.text = "27s"; ISim6.text = "24s"; ISim5.text = "21s"; ISim4.text = "18s"; ISim3.text = "15s"; ISim2.text = "12s";
            ISim1.text = "9s"; ISim1.color = Color.grey; ISim2.color = Color.grey; ISim3.color = Color.grey; ISim4.color = Color.grey; ISim5.color = Color.grey; ISim6.color = Color.grey; ISim7.color = Color.grey;
        }
        if (IScurrentLevel == 8)
        {
            ISim8.text = "30s"; ISim7.text = "27s"; ISim6.text = "24s"; ISim5.text = "21s"; ISim4.text = "18s"; ISim3.text = "15s"; ISim2.text = "12s"; ISVal.text = "Fully Upgrated";
            ISim1.text = "9s"; ISim1.color = Color.grey; ISim2.color = Color.grey; ISim3.color = Color.grey; ISim4.color = Color.grey; ISim5.color = Color.grey; ISim6.color = Color.grey; ISim7.color = Color.grey; ISim8.color = Color.grey;
        }

    }
    private void CDMethod()
    {
        if (CDcurrentLevel == 0) { CDim1.text = "9s"; }
        else if (CDcurrentLevel == 1) { CDim2.text = "12s"; CDim1.text = "9s"; CDim1.color = Color.grey; }
        else if (CDcurrentLevel == 2) { CDim3.text = "15s"; CDim2.text = "12s"; CDim1.text = "9s"; CDim1.color = Color.grey; CDim2.color = Color.grey; }
        else if (CDcurrentLevel == 3)
        {
            CDim4.text = "18s"; CDim3.text = "15s"; CDim2.text = "12s"; CDim1.text = "9s"; CDim1.color = Color.grey;
            CDim2.color = Color.grey; CDim3.color = Color.grey;
        }
        else if (CDcurrentLevel == 4)
        {
            CDim5.text = "21s"; CDim4.text = "18s"; CDim3.text = "15s"; CDim2.text = "12s"; CDim1.text = "9s";
            CDim1.color = Color.grey; CDim2.color = Color.grey; CDim3.color = Color.grey; CDim4.color = Color.grey;
        }
        else if (CDcurrentLevel == 5)
        {
            CDim6.text = "24s"; CDim5.text = "21s"; CDim4.text = "18s"; CDim3.text = "15s"; CDim2.text = "12s";
            CDim1.text = "9s"; CDim1.color = Color.grey; CDim2.color = Color.grey; CDim3.color = Color.grey; CDim4.color = Color.grey; CDim5.color = Color.grey;
        }
        else if (CDcurrentLevel == 6)
        {
            CDim7.text = "27s"; CDim6.text = "24s"; CDim5.text = "21s"; CDim4.text = "18s"; CDim3.text = "15s"; CDim2.text = "12s";
            CDim1.text = "9s"; CDim1.color = Color.grey; CDim2.color = Color.grey; CDim3.color = Color.grey; CDim4.color = Color.grey; CDim5.color = Color.grey; CDim6.color = Color.grey;
        }
        else if (CDcurrentLevel == 7)
        {
            CDim8.text = "30s"; CDim7.text = "27s"; CDim6.text = "24s"; CDim5.text = "21s"; CDim4.text = "18s"; CDim3.text = "15s"; CDim2.text = "12s";
            CDim1.text = "9s"; CDim1.color = Color.grey; CDim2.color = Color.grey; CDim3.color = Color.grey; CDim4.color = Color.grey; CDim5.color = Color.grey; CDim6.color = Color.grey; CDim7.color = Color.grey;
        }
        else if (CDcurrentLevel == 8)
        {
            CDim8.text = "30s"; CDim7.text = "27s"; CDim6.text = "24s"; CDim5.text = "21s"; CDim4.text = "18s"; CDim3.text = "15s"; CDim2.text = "12s"; CDVal.text = "Fully Upgrated";
            CDim1.text = "9s"; CDim1.color = Color.grey; CDim2.color = Color.grey; CDim3.color = Color.grey; CDim4.color = Color.grey; CDim5.color = Color.grey; CDim6.color = Color.grey; CDim7.color = Color.grey; CDim8.color = Color.grey;
        }

    }
    /// <summary>
    /// /////////////////
    /// </summary>
    public void Power1UpButt()
    {
        if (Player.NumbCoins >= powerup1Value)
        {
            Debug.Log("Powerup1");
            powerup1currentLevel++;
            if (powerup1currentLevel >= 8)
            {
                powerup1currentLevel = 8;
            }
            Player.powerup1currentLevel = powerup1currentLevel;
            Player.NumbCoins -= powerup1Value;
        }
        
    }
    public void Power2UpButt()
    {
        if (Player.NumbCoins >= powerup2Value)
        {
            powerup2currentLevel++;
            Player.powerup2currentLevel = powerup2currentLevel;
            if (powerup2currentLevel >= 8)
            {
                powerup2currentLevel = 8;
            }
             Player.NumbCoins -= powerup2Value;
        }

    }
    public void FreezeUpButt()
    {
        if (Player.NumbCoins >= freezeValue)
        {
            FreezecurrentLevel++;
            Player.FreezecurrentLevel = FreezecurrentLevel;
            if (FreezecurrentLevel >= 8)
            {
                FreezecurrentLevel = 8;
            }
             Player.NumbCoins -= freezeValue;
        }

    }
    public void ICUpButt()
    {
        if (Player.NumbCoins >= ICValue)
        {
            ICcurrentLevel++;
            Player.ICcurrentLevel = ICcurrentLevel;
            if (ICcurrentLevel >= 8)
            {
                ICcurrentLevel = 8;
            }
             Player.NumbCoins -= ICValue;
        }

    }
    public void ISUpButt()
    {
        if (Player.NumbCoins >= ISValue)
        {
            IScurrentLevel++;
            if (IScurrentLevel >= 8)
            {
                IScurrentLevel = 8;
            }
            Player.IScurrentLevel = IScurrentLevel;
             Player.NumbCoins -= ISValue;
        }

    }
    public void CDUpButt()
    {
        if (Player.NumbCoins >= CDValue)
        {
            CDcurrentLevel++;
            if(CDcurrentLevel >= 8)
            {
                CDcurrentLevel = 8;
            }
            Player.CDcurrentLevel = CDcurrentLevel;
             Player.NumbCoins -= CDValue;
        }

    }
}
