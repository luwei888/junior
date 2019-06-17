using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace advanceGrammarDemo
{
    public class student : IEnumerable<student>
    {
        public string name { get; set; }
        public IEnumerator<student> GetEnumerator()
        {
            return new students();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class students : IEnumerator<student>
    {
        private student[] _gathers;
        private int _index = -1;

        public students()
        {
            _gathers = new student[3] { new student() { name = "luwei" }, new student() { name = "xiaolong" },new student() {name = "laozhang" } };
        }

        public object Current => _gathers[_index];

        student IEnumerator<student>.Current => _gathers[_index];

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            _index++;
            return _index < _gathers.Length;
        }

        public void Reset()
        {

        }
    }

}
