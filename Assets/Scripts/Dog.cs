using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird //Class/Object
    
{
    int wings = 2;
    int legs = 2;

    public void fly()
    {
        Debug.Log("I am flying.");
    }
    public void sing()
    {
        Debug.Log("I am singing.");
    }
}
public class Snake
{
    int scale = 2000; //Attribute
    int tail = 1;

    public void bite() //Method
    {
        Debug.Log("I am biting.");
    }

    public void slither()
    {
        Debug.Log("I am slithering.");
    }
}

public class Crow : Bird //Inheritance
{
    public void steal()
    {
        Debug.Log("I am stealing.");
    }
    Bomb bomb01 = new Bomb();

    public void attack()
    {
        bomb01.explode();
    }
}
public class Bomb
{
    public void explode()
    {
        Debug.Log("Booooooommmmmmm!!!!!");
    }
}

public class Dog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Bird sompong = new Bird();
        sompong.fly();
        Bird somchai = new Bird();
        somchai.sing();
        Snake somying = new Snake();
        somying.bite();
        Snake somrudee = new Snake();
        somrudee.slither();
        Crow somdum = new Crow();
        somdum.fly();
        Crow somdaeng = new Crow();
        somdaeng.steal();
        Crow sombomb = new Crow();
        sombomb.attack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
