using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface IEntity
    {
        int Id { get; set; }
    }

    class Restaurant : IEntity
    {
        public int Id { get; set; }
    }

    class User : IEntity
    {
        public User()
        {

        }

        public User(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public string Name { get; set; }
        public int Id { get; set; }
    }

    internal class PaginatedResult<T>
    {
        public List<T> Results { get; set; }
        public int PageFrom { get; set; }
        public int PageTo { get; set; }
        public int TotalPages { get; set; }
        public int TotalResults { get; set; }
    }
}
