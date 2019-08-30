namespace UniqueVectors.Core
{
    public class DataSets
    {
        public float[] Vectors { get; }

        public float[] Ideals { get; }

        public bool IsUnique = false;

        public DataSets(float[] vectors, float[] ideals)
        {
            Vectors = vectors;
            Ideals = ideals;
        }
    }
}
