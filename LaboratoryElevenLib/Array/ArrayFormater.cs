
namespace LaboratoryElevenLib.Array
{
    internal static class ArrayFormater
    {

        public static string[] CreateStringArrayBy(double[][] anyArray)
        {
            string[] strings = new string[anyArray.Length];
            for (int arrayElement = 0; arrayElement < anyArray.Length; arrayElement++)
            {
                strings[arrayElement] = CreateStringArrayBy(anyArray[arrayElement]);
            }
        }

        private static string CreateStringArrayBy(double[] doubles)
        {
            f
        }
    }
}
