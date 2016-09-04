namespace CohesionAndCapling.Utils
{
    using System;

    public static class FileUtils
    {
        public static string GetFileExtension(string fileName)
        {
            var indexOfLastDot = fileName.LastIndexOf(".", StringComparison.Ordinal);
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            var extension = fileName.Substring(indexOfLastDot + 1);

            return extension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            var indexOfLastDot = fileName.LastIndexOf(".", StringComparison.Ordinal);
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            var extension = fileName.Substring(0, indexOfLastDot);

            return extension;
        }
    }
}
