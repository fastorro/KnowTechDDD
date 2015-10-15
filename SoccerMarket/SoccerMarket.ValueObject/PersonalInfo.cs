using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerMarket.ValueObject
{
    public sealed class PersonalInfo : IEquatable<PersonalInfo>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        private static bool CheckEquality(PersonalInfo a, PersonalInfo b) =>
            a != null && b != null
            && a.Name == b.Name
            && a.LastName == b.LastName
            && a.Age == b.Age;

        public bool Equals(PersonalInfo other) => CheckEquality(this, other);

        public override bool Equals(object obj) => Equals(obj as PersonalInfo);
        
        public static bool operator ==(PersonalInfo a, PersonalInfo b)
            => Equals(a, b);

        public static bool operator !=(PersonalInfo a, PersonalInfo b)
            => !Equals(a, b);

        public override int GetHashCode()
        {
            return (Name + LastName).GetHashCode();
        }
    }
}
