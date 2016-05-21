using UnityEngine;
using System.Collections;

public class spawnItem : MonoBehaviour {

	public Product[] depElectronics;


	// Use this for initialization
	void addProduct (string department, Vector3 location) {
		switch (department) {
		case "electronics":
			var product = depElectronics [Random.Range(0, depElectronics.Length - 1)];
			product.price = 
				product.salePercentage = Random.Range(15, 95);
			Instantiate(product, location);
			break;
		}
	
	}
}
