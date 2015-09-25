#pragma strict
var fonarik: Light;

function Start () {

}

function Update () {
	if(Input.GetKeyUp(KeyCode.F)) 
		fonarik.enabled = !fonarik.enabled;

}