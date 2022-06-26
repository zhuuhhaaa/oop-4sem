//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOP_Lab02_3
//{
//    public class Memento
//    {
//        public List<BookFile> bookList = new List<BookFile>();
//        public string State { get; private set; }
//        public Memento(List<BookFile> State)
//        {
//            if (State != null)
//            {
//                foreach (BookFile i in State)
//                {
//                    bookList.Add(i);
//                }
//            }
//            else if (State == null)
//                bookList.Clear();
//        }
//    }
//    public class Caretaker
//    {
//        public Stack<Memento> History { get; private set; }
//        public Caretaker()
//        {
//            History = new Stack<Memento>();
//        }
//    }

//    public class Originator
//    {
//        public List<BookFile> bookList = new List<BookFile>();
//        public string State { get; set; }
//        public void SetMemento(Memento memento)
//        {
//            State = memento.State;
//        }
//        public Memento CreateMemento()
//        {
//            return new Memento(bookList);
//        }

//        public static BookFile SaveState(BookFile book)
//        {
//            return new Memento(bookList);
//        }
//    }
//}
