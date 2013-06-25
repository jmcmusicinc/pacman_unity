using UnityEngine;
using System.Collections;

public class GridScript : MonoBehaviour {
	
	public Transform cell;
	public Vector2 Size;
	public Transform wall;
	public Transform pellet;
	public Transform pacman;
	public int[,] wallGrid = new int[,] {
		{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
		{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
		{1, 0, 1, 0, 1, 1, 1, 1, 1, 0, 1},
		{1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1},
		{1, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1},
		{1, 0, 0, 0, 1, 1, 0, 1, 1, 0, 1},
		{1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1},
		{1, 0, 1, 1, 0, 1, 1, 1, 1, 0, 1},
		{1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 1},
		{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
	};
	
	void Start() {
		CreateGrid();
	}
	
	void CreateGrid() {
		int rx;
		for(int x = 0; x < Size.x; x++) {
			for(int y = 0; y < Size.y; y++) {
				rx = (int)Size.x - x - 1;
				Draw(cell, rx, y);
				if(wallGrid[x,y] == 0) {
					Draw(pellet, rx, y, -1);	
				} else if(wallGrid[x,y] == 1) {
					Draw(wall, rx, y, -1);	
				} else if(wallGrid[x,y] == 2) {
					Draw(pacman, rx, y, -1);
				}
			}
		}
	}
	
	void Draw(Transform obj, int x = 0, int y = 0, int z = 0) {
		Instantiate(obj, new Vector3(x, y, z), Quaternion.identity);
	}
		
	void Update() {
	}
}
