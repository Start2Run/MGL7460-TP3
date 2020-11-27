using System;
using System.Diagnostics.CodeAnalysis;

namespace Persistence.Models
{
    public class DbModel : IEquatable<DbModel>
    {
        public bool Equals([AllowNull] DbModel other)
        {
            throw new NotImplementedException();
        }
    }
}
