using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class TxtEdit
    {
        private TxtDoc _document;
        private Stack<Memento> _history;
        public TxtEdit()
        {
            _document = new TxtDoc();
            _history = new Stack<Memento>();
        }
        public void Write(string content)
        {
            SaveState();
            _document.Content += content;
        }
        public void SaveState()
        {
            _history.Push(new Memento(_document.Content));
        }
        public void Undo()
        {
            if (_history.Count > 0)
            {
                Memento memento = _history.Pop();
                _document.Content = memento.State;
            }
            else
            {
                Console.WriteLine("No more states to undo.");
            }
        }
        public void PrintContent()
        {
            Console.WriteLine(_document);
        }
    }
}
