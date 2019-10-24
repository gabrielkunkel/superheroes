using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Superheroes.Models
{
    public class Superhero
    {
        public int superheroId { get; set; }
        public string name { get; set; }
        public string alterEgo { get; set; }
        public string primaryAbility { get; set; }
        public string catchPhrase { get; set; }

    }
}