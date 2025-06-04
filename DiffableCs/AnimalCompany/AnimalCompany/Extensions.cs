namespace AnimalCompany;

[Extension]
public static class Extensions
{

        [Extension]
        public static Vector3 Flatten(Vector3 v)
        {
                // Utility extension that zeroes out the Y component of a
                // vector, effectively projecting it onto the X/Z plane.
                v.y = 0f;
                return v;
        }

}

