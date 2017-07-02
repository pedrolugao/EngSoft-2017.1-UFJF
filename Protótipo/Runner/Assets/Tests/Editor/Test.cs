using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
public class Test {

	[Test]
	public void CounterAddsGold() {
        // Use the Assert class to test conditions.
        Counter contador = new Counter();
        int ouro = contador.ouroTotal;
        contador.aumentarOuro(1);
        Assert.That(ouro+1 == contador.ouroTotal);
	}   

	
}
