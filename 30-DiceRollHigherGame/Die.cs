using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_DiceRollHigherGame
{
    public class Die
    {
        //create a new instance of the math object Random
        //this will be shared by each instance of Die
        //the instance of the Random object will be created when the
        //first instance of Die is created
        private static Random _rnd = new Random();

        //data member is required for the fully implemented property
        private int _FaceValue;
        public int FaceValue
        {
            get
            {
                //the get is used on the right side of an assignment operate
                // used in an expression
                //this is the sending of a value from the object instance to
                //somewhere else
                return _FaceValue;
            }
            private set
            {
                //the set is used to assign an incoming value to the data memeber
                //it is used on the left side of an assignment operate
                //the key word --> value <-- contains the incoming data value
                //you can do validation within the set to check the domain of
                //your data
                //to indicate an error used throw new Exception(" your message")

                //the set can be private which means that the data member
                //can only recieve a value from within the object instance 
                //itself via a constructor or a method (behaviour)
                _FaceValue = value;
            }
        }

        //auto implemented property
        //no data member is explicitly declared for this property
        //public int FaceValue { get; private set; }


        //constructor
        //optional, if not supplied then the system default contructor
        // is used which will assign a value to your data member that
        //corresponds to the datatype default

        //you may have any number of constructors
        //if you code a constructor, you become responsible for all constructors
        //two typical constructors are the default and greedy

        //NOTE: CONSTRUCTORS DO NOT HAVE A RETURN DATATYPE

        //default constructor mimics the system default
        public Die()
        {
            //this constructor would be used when no values are
            //supplied at the time of instantiation
            // public Die theDice = new Die();

            //you can override the system datatype values by supplying
            //your own default values
            FaceValue = 1;
        }

        //greedy constructor usually is setup to recieve a value for all
        //data members in your the object definition
        public Die(int facevalue)
        {
            //it is a good practice to use the properties to assign
            //values to data members
            // public Die myDie = new Die(1);
            FaceValue = facevalue;
        }

        //Behaviours (methods)

        public void RollDie()
        {
            //will be used to generate a new facevalue for the instance
            //the method in Random called .Next(inclusive lowest range value,
            //                                  exclusive higest range value)
            FaceValue = _rnd.Next(1, 7);
        }
    }
}
