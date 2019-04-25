using System;

namespace CollectionViewChallenge.Models
{
    [Flags]
    public enum GamePlatform
    {
        None = 0,
        PS3 = 1 << 0,
        PS4 = 1 << 1,
        VITA = 1 << 2
    }
}
