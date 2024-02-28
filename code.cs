 public static bool TryParse(string version,
        out SemVersion semVersion)
    {
        semVersion = Zero;

        if (string.IsNullOrEmpty(version))
        {
            return false;
        }
//good
        var match = SemVerRegex.Match(version);
        if (!match.Success)
        {
            return false;
        }   public bool Equals(SemVersion other)
    {
        return other is object
               && Major == other.Major
               && Minor == other.Minor
               && Patch == other.Patch
               && string.Equals(PreRelease, other.PreRelease, StringComparison.OrdinalIgnoreCase)
               && string.Equals(Meta, other.Meta, StringComparison.OrdinalIgnoreCase);
    }

          return (string.IsNullOrEmpty(Meta) != string.IsNullOrEmpty(other.Meta))
                    ? string.IsNullOrEmpty(Meta) ? 1 : -1
                    : StringComparer.InvariantCultureIgnoreCase.Compare(Meta, other.Meta);
            }
        }
    }
