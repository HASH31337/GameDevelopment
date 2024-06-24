
using UnityEditor.SceneManagement;
using UnityEngine;

public class Domino : MonoBehaviour

{
    void Start()
    {

        var stage = GameObject.CreatePrimitive(PrimitiveType.Cube);
        stage.transform.localScale = new Vector3(20, 1, 10);
        stage.name = "Stage";
        var startTile = GameObject.CreatePrimitive(PrimitiveType.Cube);
        startTile.transform.localScale = new Vector3(0.25F, 2, 1);
        startTile.transform.position = new Vector3(-5,1.5F,0);
        startTile.transform.eulerAngles = new Vector3(0,0,-10);
        startTile.AddComponent<Rigidbody>();
        startTile.name = "Start Tile";

        for (var i = 0; i < 10; i++)
        {
            var tile = GameObject.CreatePrimitive(PrimitiveType.Cube);
            tile.transform.localScale = new Vector3(0.25F, 2, 1);
            tile.transform.position = new Vector3(-4+i, 1.5F, 0);
            tile.AddComponent<Rigidbody>();
            tile.name = "Tile"+ i ;

        //‰Û‘è1
        /*
        var stage = GameObject.CreatePrimitive(PrimitiveType.Cube);
        stage.transform.localScale = new Vector3(20, 1, 10);
        stage.name = "Stage";
        var startTile = GameObject.CreatePrimitive(PrimitiveType.Cube);
        startTile.transform.localScale = new Vector3(0.25F, 2, 1);
        startTile.transform.position = new Vector3(-5,1.5F,0);
        startTile.transform.eulerAngles = new Vector3(0,0,-10);
        startTile.AddComponent<Rigidbody>();
        startTile.name = "Start Tile";

        for (var i = 0; i < 20; i++)
        {
            var tile = GameObject.CreatePrimitive(PrimitiveType.Cube);
            tile.transform.localScale = new Vector3(0.25F, 2, 1);
            tile.transform.position = new Vector3(-4+0.5F*i, 1.5F, 0);
            tile.AddComponent<Rigidbody>();
            tile.name = "Tile"+ i ;
        */

        //‰Û‘è2
        /*
        var stage = GameObject.CreatePrimitive(PrimitiveType.Cube);
        stage.transform.localScale = new Vector3(20, 1, 10);
        stage.name = "Stage";
        var startTile = GameObject.CreatePrimitive(PrimitiveType.Cube);
        startTile.transform.localScale = new Vector3(0.25F, 2, 1);
        startTile.transform.position = new Vector3(-5, 1.5F, 0);
        startTile.transform.eulerAngles = new Vector3(0, 0, -10);
        startTile.AddComponent<Rigidbody>();
        startTile.name = "Start Tile";

        for (var i = 0; i < 20; i++)
        {
            var tile = GameObject.CreatePrimitive(PrimitiveType.Cube);
            tile.transform.localScale = new Vector3(0.25F, 2 + i, 1);
            tile.transform.position = new Vector3(-4 + 0.5F * i, 1.5F + 0.5F * i, 0);
            tile.AddComponent<Rigidbody>();
            tile.name = "Tile" + i;
        }
        */
        //‰Û‘è3
        /*
        var stage = GameObject.CreatePrimitive(PrimitiveType.Cube);
        stage.transform.localScale = new Vector3(20, 1, 10);
        stage.name = "Stage";
        var startTile = GameObject.CreatePrimitive(PrimitiveType.Cube);
        startTile.transform.localScale = new Vector3(0.25F, 2, 1);
        startTile.transform.position = new Vector3(-5.5F, 1.5F, 0);
        startTile.transform.eulerAngles = new Vector3(0, 0, -10);
        startTile.AddComponent<Rigidbody>();
        startTile.name = "Start Tile";

        for (var i = 0; i < 10; i++)
        {
            var tile = GameObject.CreatePrimitive(PrimitiveType.Cube);
            tile.transform.localScale = new Vector3(0.25F, 1.5F, 1);
            tile.transform.position = new Vector3(-4 + 0.5F * 2 * i, 1.125F, 0);
            tile.AddComponent<Rigidbody>();
            tile.name = "Tile1-" + i;

            var tile2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            tile2.transform.localScale = new Vector3(0.25F, 2, 1);
            tile2.transform.position = new Vector3(-4 + 0.5F * (2 * i - 1), 1.5F, 0);
            tile2.AddComponent<Rigidbody>();
            tile2.name = "Tile2-" + i;
        */
        //‰Û‘èEX
        /*
        var stage = GameObject.CreatePrimitive(PrimitiveType.Cube);
        stage.transform.localScale = new Vector3(20, 1, 10);
        stage.name = "Stage";
        var startTile = GameObject.CreatePrimitive(PrimitiveType.Cube);
        startTile.transform.localScale = new Vector3(0.25F, 2, 1);
        startTile.transform.position = new Vector3(-5, 1.5F, 0);
        startTile.transform.eulerAngles = new Vector3(0, 0, -10);
        startTile.AddComponent<Rigidbody>();
        startTile.name = "Start Tile";

        for (var i = 0; i < 20; i++)
        {
            var tile = GameObject.CreatePrimitive(PrimitiveType.Cube);
            tile.transform.localScale = new Vector3(0.25F, 4F+UnityEngine.Mathf.Sin(UnityEngine.Mathf.PI/6*i)  , 1);
            tile.transform.position = new Vector3(-4 + 0.5F * i, 3F+ UnityEngine.Mathf.Sin(UnityEngine.Mathf.PI/6*i), 0);
            tile.AddComponent<Rigidbody>();
            tile.name = "Tile" + i;
        */
        }

    }
}
