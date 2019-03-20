using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public class Decorator : LibraryItem
    {
        protected LibraryItem _libraryItem;

        // Constructor
        public Decorator(LibraryItem libraryItem)
        {
            _libraryItem = libraryItem;
        }

        public override void Display()
        {
            _libraryItem.Display();
        }
    }
}
