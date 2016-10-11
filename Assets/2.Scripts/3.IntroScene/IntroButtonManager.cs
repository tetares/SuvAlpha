﻿using UnityEngine;
using System.Collections;

public class IntroButtonManager : MonoBehaviour {
	IntroManager _intro;
	int _event;
	// Use this for initialization
	void Start( ) {
		_intro = GameObject.Find( "IntroSystem" ).gameObject.GetComponent<IntroManager>( );
	}
	
	// Update is called once per frame
	void Update( ) {
	
	}
	
	public void YesButton( ) {
        _event = _intro.getEventNum( );
        _intro.setSelect( _intro.getSelect( ) + ( int )Mathf.Pow( 2, _event ) );
		_intro.setEventNum( _intro.getEventNum( ) + 1 );
		_intro.setTimerSwitch( 1 );
	}

	public void NoButton( ) {
		_intro.setEventNum( _intro.getEventNum( ) + 1 );
		_intro.setTimerSwitch( 1 );
	}
}
