using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    /// <summary>
    /// Represents a standard individual
    /// 6-sided die
    /// </summary>
    class Die
    {
        private static Random rand;

        /// <summary>
        /// Static Constructor - It can’t be called directly. 
        /// It is called automatically to initialize the class before the first instance created.
        /// </summary>
        static Die()
        {
            rand = new Random();
        }

        /// <summary>
        /// Creates the Die with an initial
        /// random value 1 - 6
        /// Remember, this is called a Constructor - A constructor is a special method 
        /// of the class which gets automatically invoked whenever an instance of the class is created. 
        /// Like methods, a constructor also contains the collection of instructions that are executed at the time of Object creation. 
        /// It is used to assign initial values to the data members of the same class.
        /// </summary>
        public Die()
        {
            Roll();
        }

        /// <summary>
        /// Get the face value of the die
        /// When making the set private, it cannot be accessed to be manipulated
        /// </summary>
        public byte Value { get; private set; }

        /// <summary>
        /// Rolls the die, and sets the value
        /// to 1 - 6
        /// </summary>
        public void Roll()
        {
            int result = rand.Next(1, 7);
            Value = (byte)result;
        }
    }
}
