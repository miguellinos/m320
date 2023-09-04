using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_02
{

    internal class Rectangle
    {
        // 1. Ein Feld mit einem für Felder typischen Zugriffsmodifizierer.
        private int length;

        // 2. Ein Feld, dessen Wert während der Lebensdauer eines Objekts nicht verändert werden kann.
        private readonly int width;

        // 3. Ein Feld, für welches ein Standardwert zugewiesen wird.
        private int height = 0;

        // 4. Eine selber implementierte, read-only Eigenschaft.
        public int Area
        {
            get
            {
                return length * width;
            }
        }

        // 5. Eine selber implementierte, read-write Eigenschaft.
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        // 6. Eine selber implementierte, write-only Eigenschaft.
        private string description;

        public string Description
        {
            set
            {
                description = value;
            }
        }

        // 7. Eine automatisch implementierte, read-only Eigenschaft.
        public int Perimeter { get; }

        // 8. Eine automatisch implementierte, read-write Eigenschaft.
        public int Length { get; set; }

        // 9. Eine automatisch implementierte, write-only Eigenschaft.
        public int Width { private get; set; }

        // 10. Zwei verschiedene Eigenschaften mit jeweils unterschiedlicher Anwendung der expression body Schreibweise.
        public int DoubleArea => 2 * Area;
        public string Info => $"Length: {Length}, Width: {Width}, Height: {Height}, Description: {description}";

        // Konstruktor
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
            Perimeter = 2 * (length + width);
        }
    }
}

    
    
