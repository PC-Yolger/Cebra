#pragma strict
var  a : GameObject;
var  b : GameObject;
var  c : GameObject;

function OnTriggerExit2D(col : Collider2D)
    {
        if(col.tag.Equals("Camino"))
        {
            var r : int = Random.Range(1,3);
            if(r==1)
                Instantiate(a ,Vector3(transform.position.x+27,col.transform.position.y,0),Quaternion.identity);
            if(r==2)
                Instantiate(b ,Vector3(transform.position.x+15,col.transform.position.y,0),Quaternion.identity);
            if(r==3)
                Instantiate(c ,Vector3(transform.position.x+10.5f,col.transform.position.y,0),Quaternion.identity);
        }
	
    }
