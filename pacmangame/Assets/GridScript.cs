using UnityEngine;
using System.Collections;

public class GridScript : MonoBehaviour {
	
	public Transform cell;
	public Vector3 Size;
	public Transform wall;
	public Transform pellet;
	public int[,] wallGrid = new int[,] {
		{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
		{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
		{1, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1},
		{1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1},
		{1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1},
		{1, 0, 0, 0, 1, 1, 0, 1, 1, 0, 1},
		{1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1},
		{1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 1},
		{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
		{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
	};
	
	void Start() {
		CreateGrid();
	}
	
	void CreateGrid() {
		for(int x = 0; x < Size.x; x++) {
			for(int y = 0; y < Size.y; y++) {
				Instantiate(cell, new Vector3(x, y, 0), Quaternion.identity);
				if(wallGrid[x,y] == 1) {
					Instantiate(wall, new Vector3(x, y, -1), Quaternion.identity);	
				} else {
					Instantiate(pellet, new Vector3(x, y, -1), Quaternion.identity);	
				}
			}
		}
		
	}
}
