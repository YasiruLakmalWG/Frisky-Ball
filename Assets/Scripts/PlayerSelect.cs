using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelect : MonoBehaviour
{
    public static int SelectedPlayerNumb;

    public static bool GrassBallUnlock;
    public int GrassBallValue;
    public Text GrassBallButtonText;
    public Image GrassBall;

    public static bool LeatherBallUnlock;
    public int LeatherBallValue;
    public Text LeatherBallButtonText;
    public Image LeatherBall;

    public static bool PaperBallUnlock;
    public int PaperBallValue;
    public Text PaperBallButtonText;
    public Image PaperBall;

    public static bool SandBallUnlock;
    public int SandBallValue;
    public Text SandBallButtonText;
    public Image SandBall;

    public static bool WoodenBallUnlock;
    public int WoodenBallValue;
    public Text WoodenBallButtonText;
    public Image WoodenBall;

    public static bool DenimBallUnlock;
    public int DenimBallValue;
    public Text DenimBallButtonText;
    public Image DenimBall;

    public static bool StoneBallUnlock;
    public int StoneBallValue;
    public Text StoneBallButtonText;
    public Image StoneBall;

    public static bool SoftBallUnlock;
    public int SoftBallValue;
    public Text SoftBallButtonText;
    public Image SoftBall;

    public static bool TennisBallUnlock;
    public int TennisBallValue;
    public Text TennisBallButtonText;
    public Image TennisBall;

    public static bool ColorBallUnlock;
    public int ColorBallValue;
    public Text ColorBallButtonText;
    public Image ColorBall;

    // Start is called before the first frame update
    void Start()
    {
        SelectedPlayerNumb = Player.SelectedPlayerNumb;
        GrassBallUnlock = Player.GrassBallUnlock;
        LeatherBallUnlock = Player.LeatherBallUnlock;
        PaperBallUnlock = Player.PaperBallUnlock;
        SandBallUnlock = Player.SandBallUnlock;
        WoodenBallUnlock = Player.WoodenBallUnlock;
        DenimBallUnlock = Player.DenimBallUnlock;
        StoneBallUnlock = Player.StoneBallUnlock;
        SoftBallUnlock = Player.SoftBallUnlock;
        TennisBallUnlock = Player.TennisBallUnlock;
        ColorBallUnlock = Player.ColorBallUnlock;
    }

    // Update is called once per frame
    void Update()
    {
        GrassBallMethod();
        LeatherBallMethod();
        PaperBallMethod();
        SandBallMethod();
        WoodenBallMethod();
        DenimBallMethod();
        StoneBallMethod();
        SoftBallMethod();
        TennisBallMethod();
        ColorBallMethod();

    }
    private void GrassBallMethod()
    {
        if (GrassBallUnlock == false)
        {
            GrassBallButtonText.text = "BUY";
            GrassBallButtonText.color = Color.red;
            GrassBall.color = Color.yellow;

        }
        if (GrassBallUnlock == true)
        {
            if (SelectedPlayerNumb != 1)
            {
                GrassBallButtonText.text = "Select";
                GrassBallButtonText.color = Color.blue;
                GrassBall.color = Color.green;
            }
            else
            {
                GrassBallButtonText.text = "Secected";
                GrassBallButtonText.color = Color.green;
                GrassBall.color = Color.black;
            }
        }
    }
    private void LeatherBallMethod()
    {
        if (LeatherBallUnlock == false)
        {
            LeatherBallButtonText.text = "BUY";
            LeatherBallButtonText.color = Color.red;
            LeatherBall.color = Color.yellow;

        }
        if (LeatherBallUnlock == true)
        {
            if (SelectedPlayerNumb != 2)
            {
                LeatherBallButtonText.text = "Select";
                LeatherBallButtonText.color = Color.blue;
                LeatherBall.color = Color.green;
            }
            else
            {
                LeatherBallButtonText.text = "Secected";
                LeatherBallButtonText.color = Color.green;
                LeatherBall.color = Color.black;
            }
        }
    }
    private void PaperBallMethod()
    {
        if (PaperBallUnlock == false)
        {
            PaperBallButtonText.text = "BUY";
            PaperBallButtonText.color = Color.red;
            PaperBall.color = Color.yellow;

        }
        if (PaperBallUnlock == true)
        {
            if (SelectedPlayerNumb != 3)
            {
                PaperBallButtonText.text = "Select";
                PaperBallButtonText.color = Color.blue;
                PaperBall.color = Color.green;
            }
            else
            {
                PaperBallButtonText.text = "Secected";
                PaperBallButtonText.color = Color.green;
                PaperBall.color = Color.black;
            }
        }
    }
    private void SandBallMethod()
    {
        if (SandBallUnlock == false)
        {
            SandBallButtonText.text = "BUY";
            SandBallButtonText.color = Color.red;
            SandBall.color = Color.yellow;

        }
        if (SandBallUnlock == true)
        {
            if (SelectedPlayerNumb != 4)
            {
                SandBallButtonText.text = "Select";
                SandBallButtonText.color = Color.blue;
                SandBall.color = Color.green;
            }
            else
            {
                SandBallButtonText.text = "Secected";
                SandBallButtonText.color = Color.green;
                SandBall.color = Color.black;
            }
        }
    }
    private void WoodenBallMethod()
    {
        if (WoodenBallUnlock == false)
        {
            WoodenBallButtonText.text = "BUY";
            WoodenBallButtonText.color = Color.red;
            WoodenBall.color = Color.yellow;

        }
        if (WoodenBallUnlock == true)
        {
            if (SelectedPlayerNumb != 5)
            {
                WoodenBallButtonText.text = "Select";
                WoodenBallButtonText.color = Color.blue;
                WoodenBall.color = Color.green;
            }
            else
            {
                WoodenBallButtonText.text = "Secected";
                WoodenBallButtonText.color = Color.green;
                WoodenBall.color = Color.black;
            }
        }
    }
    private void DenimBallMethod()
    {
        if (DenimBallUnlock == false)
        {
            DenimBallButtonText.text = "BUY";
            DenimBallButtonText.color = Color.red;
            DenimBall.color = Color.yellow;

        }
        if (DenimBallUnlock == true)
        {
            if (SelectedPlayerNumb != 6)
            {
                DenimBallButtonText.text = "Select";
                DenimBallButtonText.color = Color.blue;
                DenimBall.color = Color.green;
            }
            else
            {
                DenimBallButtonText.text = "Secected";
                DenimBallButtonText.color = Color.green;
                DenimBall.color = Color.black;
            }
        }
    }
    private void StoneBallMethod()
    {
        if (StoneBallUnlock == false)
        {
            StoneBallButtonText.text = "BUY";
            StoneBallButtonText.color = Color.red;
            StoneBall.color = Color.yellow;

        }
        if (StoneBallUnlock == true)
        {
            if (SelectedPlayerNumb != 7)
            {
                StoneBallButtonText.text = "Select";
                StoneBallButtonText.color = Color.blue;
                StoneBall.color = Color.green;
            }
            else
            {
                StoneBallButtonText.text = "Secected";
                StoneBallButtonText.color = Color.green;
                StoneBall.color = Color.black;
            }
        }
    }
    private void SoftBallMethod()
    {
        if (SoftBallUnlock == false)
        {
            SoftBallButtonText.text = "BUY";
            SoftBallButtonText.color = Color.red;
            SoftBall.color = Color.yellow;

        }
        if (SoftBallUnlock == true)
        {
            if (SelectedPlayerNumb != 8)
            {
                SoftBallButtonText.text = "Select";
                SoftBallButtonText.color = Color.blue;
                SoftBall.color = Color.green;
            }
            else
            {
                SoftBallButtonText.text = "Secected";
                SoftBallButtonText.color = Color.green;
                SoftBall.color = Color.black;
            }
        }
    }
    private void TennisBallMethod()
    {
        if (TennisBallUnlock == false)
        {
            TennisBallButtonText.text = "BUY";
            TennisBallButtonText.color = Color.red;
            TennisBall.color = Color.yellow;

        }
        if (TennisBallUnlock == true)
        {
            if (SelectedPlayerNumb != 9)
            {
                TennisBallButtonText.text = "Select";
                TennisBallButtonText.color = Color.blue;
                TennisBall.color = Color.green;
            }
            else
            {
                TennisBallButtonText.text = "Secected";
                TennisBallButtonText.color = Color.green;
                TennisBall.color = Color.black;
            }
        }
    }
    private void ColorBallMethod()
    {
        if (ColorBallUnlock == false)
        {
            ColorBallButtonText.text = "BUY";
            ColorBallButtonText.color = Color.red;
            ColorBall.color = Color.yellow;

        }
        if (ColorBallUnlock == true)
        {
            if (SelectedPlayerNumb != 10)
            {
                ColorBallButtonText.text = "Select";
                ColorBallButtonText.color = Color.blue;
                ColorBall.color = Color.green;
            }
            else
            {
                ColorBallButtonText.text = "Secected";
                ColorBallButtonText.color = Color.green;
                ColorBall.color = Color.black;
            }
        }
    }
    /////////////////////////////////////////////////////////////////////////////////////////////////
    public void GrassBallButton()
    {
        //Buy Ball
        if (GrassBallUnlock == false)
        {
            if (Player.NumbCoins >= GrassBallValue)
            {
                GrassBallUnlock = true;
                Player.NumbCoins -= GrassBallValue;
                GrassBallButtonText.text = "Select";
                GrassBallButtonText.color = Color.blue;
                GrassBall.color = Color.green;
            }
        }
        //select Ball
        else
        {
            if (SelectedPlayerNumb != 1)
            {
                SelectedPlayerNumb = 1;
                GrassBallButtonText.text = "Secected";
                GrassBallButtonText.color = Color.green;
                GrassBall.color = Color.black;
            }
        }

        Player.SelectedPlayerNumb = SelectedPlayerNumb;
        Player.GrassBallUnlock = GrassBallUnlock;
        
    }
    public void LeatherBallButton()
    {
        //Buy Ball
        if (LeatherBallUnlock == false)
        {
            if (Player.NumbCoins >= LeatherBallValue)
            {
                LeatherBallUnlock = true;
                Player.NumbCoins -= LeatherBallValue;
                LeatherBallButtonText.text = "Select";
                LeatherBallButtonText.color = Color.blue;
                LeatherBall.color = Color.green;
            }
        }
        //select Ball
        else
        {
            if (SelectedPlayerNumb != 2)
            {
                SelectedPlayerNumb = 2;
                LeatherBallButtonText.text = "Secected";
                LeatherBallButtonText.color = Color.green;
                LeatherBall.color = Color.black;
            }
        }

        Player.SelectedPlayerNumb = SelectedPlayerNumb;
        Player.LeatherBallUnlock = LeatherBallUnlock;

    }
    public void PaperBallButton()
    {
        //Buy Ball
        if (PaperBallUnlock == false)
        {
            if (Player.NumbCoins >= PaperBallValue)
            {
                PaperBallUnlock = true;
                Player.NumbCoins -= PaperBallValue;
                PaperBallButtonText.text = "Select";
                PaperBallButtonText.color = Color.blue;
                PaperBall.color = Color.green;
            }
        }
        //select Ball
        else
        {
            if (SelectedPlayerNumb != 3)
            {
                SelectedPlayerNumb = 3;
                PaperBallButtonText.text = "Secected";
                PaperBallButtonText.color = Color.green;
                PaperBall.color = Color.black;
            }
        }

        Player.SelectedPlayerNumb = SelectedPlayerNumb;
        Player.PaperBallUnlock = PaperBallUnlock;

    }
    public void SandBallButton()
    {
        //Buy Ball
        if (SandBallUnlock == false)
        {
            if (Player.NumbCoins >= SandBallValue)
            {
                SandBallUnlock = true;
                Player.NumbCoins -= SandBallValue;
                SandBallButtonText.text = "Select";
                SandBallButtonText.color = Color.blue;
                SandBall.color = Color.green;
            }
        }
        //select Ball
        else
        {
            if (SelectedPlayerNumb != 4)
            {
                SelectedPlayerNumb = 4;
                SandBallButtonText.text = "Secected";
                SandBallButtonText.color = Color.green;
                SandBall.color = Color.black;
            }
        }

        Player.SelectedPlayerNumb = SelectedPlayerNumb;
        Player.SandBallUnlock = SandBallUnlock;

    }
    public void WoodenBallButton()
    {
        //Buy Ball
        if (WoodenBallUnlock == false)
        {
            if (Player.NumbCoins >= WoodenBallValue)
            {
                WoodenBallUnlock = true;
                Player.NumbCoins -= WoodenBallValue;
                WoodenBallButtonText.text = "Select";
                WoodenBallButtonText.color = Color.blue;
                WoodenBall.color = Color.green;
            }
        }
        //select Ball
        else
        {
            if (SelectedPlayerNumb != 5)
            {
                SelectedPlayerNumb = 5;
                WoodenBallButtonText.text = "Secected";
                WoodenBallButtonText.color = Color.green;
                WoodenBall.color = Color.black;
            }
        }

        Player.SelectedPlayerNumb = SelectedPlayerNumb;
        Player.WoodenBallUnlock = WoodenBallUnlock;

    }
    public void DenimBallButton()
    {
        //Buy Ball
        if (DenimBallUnlock == false)
        {
            if (Player.NumbCoins >= DenimBallValue)
            {
                DenimBallUnlock = true;
                Player.NumbCoins -= DenimBallValue;
                DenimBallButtonText.text = "Select";
                DenimBallButtonText.color = Color.blue;
                DenimBall.color = Color.green;
            }
        }
        //select Ball
        else
        {
            if (SelectedPlayerNumb != 6)
            {
                SelectedPlayerNumb = 6;
                DenimBallButtonText.text = "Secected";
                DenimBallButtonText.color = Color.green;
                DenimBall.color = Color.black;
            }
        }

        Player.SelectedPlayerNumb = SelectedPlayerNumb;
        Player.DenimBallUnlock = DenimBallUnlock;

    }
    public void StoneBallButton()
    {
        //Buy Ball
        if (StoneBallUnlock == false)
        {
            if (Player.NumbCoins >= StoneBallValue)
            {
                StoneBallUnlock = true;
                Player.NumbCoins -= StoneBallValue;
                StoneBallButtonText.text = "Select";
                StoneBallButtonText.color = Color.blue;
                StoneBall.color = Color.green;
            }
        }
        //select Ball
        else
        {
            if (SelectedPlayerNumb != 7)
            {
                SelectedPlayerNumb = 7;
                StoneBallButtonText.text = "Secected";
                StoneBallButtonText.color = Color.green;
                StoneBall.color = Color.black;
            }
        }

        Player.SelectedPlayerNumb = SelectedPlayerNumb;
        Player.StoneBallUnlock = StoneBallUnlock;

    }
    public void SoftBallButton()
    {
        //Buy Ball
        if (SoftBallUnlock == false)
        {
            if (Player.NumbCoins >= SoftBallValue)
            {
                SoftBallUnlock = true;
                Player.NumbCoins -= SoftBallValue;
                SoftBallButtonText.text = "Select";
                SoftBallButtonText.color = Color.blue;
                SoftBall.color = Color.green;
            }
        }
        //select Ball
        else
        {
            if (SelectedPlayerNumb != 8)
            {
                SelectedPlayerNumb = 8;
                SoftBallButtonText.text = "Secected";
                SoftBallButtonText.color = Color.green;
                SoftBall.color = Color.black;
            }
        }

        Player.SelectedPlayerNumb = SelectedPlayerNumb;
        Player.SoftBallUnlock = SoftBallUnlock;

    }
    public void TennisBallButton()
    {
        //Buy Ball
        if (TennisBallUnlock == false)
        {
            if (Player.NumbCoins >= TennisBallValue)
            {
                TennisBallUnlock = true;
                Player.NumbCoins -= TennisBallValue;
                TennisBallButtonText.text = "Select";
                TennisBallButtonText.color = Color.blue;
                TennisBall.color = Color.green;
            }
        }
        //select Ball
        else
        {
            if (SelectedPlayerNumb != 9)
            {
                SelectedPlayerNumb = 9;
                TennisBallButtonText.text = "Secected";
                TennisBallButtonText.color = Color.green;
                TennisBall.color = Color.black;
            }
        }

        Player.SelectedPlayerNumb = SelectedPlayerNumb;
        Player.TennisBallUnlock = TennisBallUnlock;

    }
    public void ColorBallButton()
    {
        //Buy Ball
        if (ColorBallUnlock == false)
        {
            if (Player.NumbCoins >= ColorBallValue)
            {
                ColorBallUnlock = true;
                Player.NumbCoins -= ColorBallValue;
                ColorBallButtonText.text = "Select";
                ColorBallButtonText.color = Color.blue;
                ColorBall.color = Color.green;
            }
        }
        //select Ball
        else
        {
            if (SelectedPlayerNumb != 10)
            {
                SelectedPlayerNumb = 10;
                ColorBallButtonText.text = "Secected";
                ColorBallButtonText.color = Color.green;
                ColorBall.color = Color.black;
            }
        }

        Player.SelectedPlayerNumb = SelectedPlayerNumb;
        Player.ColorBallUnlock = ColorBallUnlock;

    }
}
