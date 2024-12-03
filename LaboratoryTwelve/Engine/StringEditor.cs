namespace LaboratoryTwelve.Engine;

public static class StringEditor
{
    public static void ConvertLatinToLowercase(ref string anyString)
    {
        char[] anyStringAsChar = anyString.ToCharArray();

        for (int i = 0; i < anyStringAsChar.Length; i++)
        {
            if (LangCode.LatinUtf8UpperCodes.InRange(Convert.ToInt32(anyStringAsChar[i])))
            {
                anyStringAsChar[i] = char.ToLower(anyStringAsChar[i]);
            }
        }

        anyString = new string(anyStringAsChar);
    }
}