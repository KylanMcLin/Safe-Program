using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Safe
    {

        public Safe(int heightPassed, int widthPassed, int depthPassed, int accessCodePassed)
        {
            height = heightPassed;
            width = widthPassed;
            depth = depthPassed;
            accessCode = accessCodePassed;
        }

        private int height; public int Height { get; set; }

        private int width; public int Width { get; set; }

        private int depth; public int Depth { get; set; }

        private bool isOpen = false;
        public bool IsOpen
        {
            get { return isOpen; }
        }

        private int shelves;
        public int Shelves
        {
            get { return Shelves; }

            set 
            {

                if (value < 0)
                {
                    Console.WriteLine("Value must be above 0");
                }

                else
                {
                    shelves = value;
                }

            }
        }

        private int accessCode;
        public void changeAccessCode(int currentAC, int newAC)
        {
            if (currentAC == accessCode)
            {
                accessCode = newAC;
            }
        }

        public void openSafe(int checkAC)
        {
            if (checkAC == accessCode)
            {
                isOpen = true;
                Console.WriteLine("Safe is open\n");
            }
            
        }

        public void closeSafe(int checkAC)
        {
            if (checkAC == accessCode)
            {
                isOpen = false;
            }
        }

        private ArrayList contents = new ArrayList();

        public string ShowContents()
        {

            if (isOpen)
            {
                string contentsString = "The safe: ";
                for (int index = 0; index < contents.Count; index++)
                {
                    contentsString += contents[index];
                    contentsString += ". ";
                }
                return contentsString;
            }
            return ("Safe is not open");
        }

        public string addContents(string addedContents)
        {
            if (isOpen)
            {
                contents.Add(addedContents);
                return ("Content added to safe");
            }
            else
            {
                return ("Safe is not open");
            }
        }

        public string removeContents(string removedContents)
        {
            if (isOpen)
            {
                contents.Remove(removedContents);
                return ("Content removed from safe");
            }
            else
            {
                return ("Safe is not open");
            }
        }


        static void Main(string[] args)
        {
            Safe mySafe1 = new Safe(55, 35, 45, 1234);
            Safe mySafe2 = new Safe(60, 40, 50, 4321);

            mySafe1.openSafe(1234);
            mySafe2.openSafe(4321);

            //mySafe1.closeSafe(1234);

            
            mySafe1.addContents("Money");
            mySafe1.addContents("Gold");
            mySafe1.addContents("Jewelry");

            
            mySafe2.addContents("Money");
            mySafe2.addContents("Graphics Card");
            mySafe2.addContents("Pictures");

            //mySafe1.removeContents("Pictures");
            //mySafe2.removeContents("Money");

            Console.WriteLine("Safe 1 Height " + mySafe1.height + ", Width " + mySafe1.width + ", Depth " + mySafe1.depth);
            Console.WriteLine(mySafe1.ShowContents() + "\n");

            Console.WriteLine("Safe 2 Height " + mySafe2.height + ", Width " + mySafe2.width + ", Depth " + mySafe2.depth);
            Console.WriteLine(mySafe2.ShowContents());

            Console.ReadLine();
        }
    }
}
