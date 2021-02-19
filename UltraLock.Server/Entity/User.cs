using System;
using System.Collections.Generic;

namespace UltraLock.Server.Entity
{
    public class User
    {
        public Guid UserGuid { get; set; }
        public bool IsAdmin { get; set; } = false;
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public IEnumerable<Lock> Locks { get; set; } = new List<Lock>();
    }
}
