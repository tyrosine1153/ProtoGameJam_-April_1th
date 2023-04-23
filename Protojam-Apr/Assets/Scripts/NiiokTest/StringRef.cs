using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringRef : MonoSingleton<StringRef>
{
    // common
    [SerializeField]
    private string ParameterX = "X";
    public int ID_X { get; private set; }
    [SerializeField]
    private string ParameterY = "Y";
    public int ID_Y { get; private set; }
    [SerializeField]
    private string ParameterSidemoving = "SideMoving";
    public int ID_SideMoving { get; private set; }
    [SerializeField]
    private string ParameterDie = "Die";
    public int ID_Die { get; private set; }
    [SerializeField]
    private string ParameterHurt = "Hurt";
    public int ID_Hurt { get; private set; }

    // player
    [SerializeField]
    private string ParameterShoot = "Shoot";
    public int ID_Shoot { get; private set; }
    [SerializeField]
    private string ParameterRoll = "Roll";
    public int ID_Roll { get; private set; }

    // dragon
    [SerializeField]
    private string ParameterGrab = "Grab";
    public int ID_Grab { get; private set; }
    [SerializeField]
    private string ParameterRun = "Run";
    public int ID_Run { get; private set; }

    public const string Horizontal = "Horizontal";
    public const string Vertical = "Vertical";
    public const string Player = "Player";
    public const string Enemy = "Enemy";


    override protected void Awake()
    {
        base.Awake();

        ID_X = Animator.StringToHash(ParameterX);
        ID_Y = Animator.StringToHash(ParameterY);
        ID_SideMoving = Animator.StringToHash(ParameterSidemoving);
        ID_Die = Animator.StringToHash(ParameterDie);
        ID_Hurt = Animator.StringToHash(ParameterHurt);

        ID_Shoot = Animator.StringToHash(ParameterShoot);
        ID_Roll = Animator.StringToHash(ParameterRoll);

        ID_Grab = Animator.StringToHash(ParameterGrab);
        ID_Run = Animator.StringToHash(ParameterRun);
    }
}
