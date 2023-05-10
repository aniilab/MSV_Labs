using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;

namespace NumericMethodsLab1
{
    public class FileDataService:IFileDataService
    {
        string filePath = "D:\\c#\\NumericMethodsLab1\\WindowsFormsApp1\\gaps.txt";

        public (double, double) ReadData()
        {
            string data;
            try
            {
                data = File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                throw new IOException($"Не вдалося прочитати файл за шляхом {filePath}", ex);
            }

            var parts = data.Trim(new char[] { '[', ']' }).Split(',');

            if (parts.Length != 2)
            {
                throw new FormatException("Не вдалося розпізнати дані у файлі. Вони повинні бути у форматі [0,1]");
            }

            if (!double.TryParse(parts[0].Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out double a)
    || !double.TryParse(parts[1].Replace(",", "."), NumberStyles.Any, CultureInfo.InvariantCulture, out double b))
            {
                throw new FormatException("Не вдалося конвертувати дані у файлі в числа з плаваючою комою");
            }


            return (a, b);
        }
    }
}
