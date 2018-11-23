using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PuppetManager : NetworkBehaviour {

    private System.Action _followingAction;

    public Transform PuppetEmpty;
    public Transform PuppetBody;
    public Transform PuppetHead;
    public Transform L_PuppetHand;
    public Transform R_PuppetHand;

    public Transform BodyTarget;
    public Transform HeadTarget;
    public Transform L_HandTarget;
    public Transform R_HandTarget;

    private void Awake()
    {
        _followingAction = FollowingInactive;
    }

    public override void OnStartLocalPlayer()
    {
        //Find Client Side OVR Targets
        BodyTarget = GameObject.Find("OVRPlayerController").transform;
        HeadTarget = GameObject.Find("CenterEyeAnchor").transform;
        L_HandTarget = GameObject.Find("LeftHandAnchor").transform;
        R_HandTarget = GameObject.Find("RightHandAnchor").transform;

        this._followingAction = FollowingActive;

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        _followingAction.Invoke();

	}

    private void FollowingInactive()
    {
        return;
    }

    private void FollowingActive()
    {
        //Update Positions
        PuppetEmpty.position = BodyTarget.position;

        PuppetBody.position = BodyTarget.position;

        PuppetHead.position = HeadTarget.position;
        PuppetHead.rotation = HeadTarget.rotation;

        L_PuppetHand.position = L_HandTarget.position;
        L_PuppetHand.rotation = L_HandTarget.rotation;

        R_PuppetHand.position = R_HandTarget.position;
        R_PuppetHand.rotation = R_HandTarget.rotation;

    }
}
