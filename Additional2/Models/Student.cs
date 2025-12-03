using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional2.Models
{
    internal class Student : BaseEntity, IComparable<Student>
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        //public Student(int id, string name)
        //{
        //    Id = id;
        //    Name = name;
        //}
        public int CompareTo(object? obj)
        {
            //throw new NotImplementedException();
            var other = obj as Student;
            if (other == null) throw new ArgumentException("Object is not a Student");
            return this.Id.CompareTo(other.Id);

        }

        public int CompareTo(Student? other)
        {
            return this.Id.CompareTo(other.Id); ;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}";
        }


        //public int Id { get; set; }
        //public string Name { get; set; }
        //public int Age { get; set; }

        //private Student[] _items;

        //public Student()
        //{
        //    _items = new Student[0];
        //}

        //public void Add(Student item)
        //{
        //    Array.Resize(ref _items, _items.Length + 1);
        //    _items[_items.Length - 1] = item;

        //}

        //public int Count { get { return _items.Length; } }
        //public void Clear()
        //{
        //    _items = new Student[0];
        //}

        //public void GetAll()
        //{
        //    foreach (var item in _items)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public Student Get(int index)
        //{
        //    if (index < 0 || index >= _items.Length)
        //    {
        //        throw new IndexOutOfRangeException("Index is out of range.");
        //    }
        //    return _items[index];
        //}
    }
}
