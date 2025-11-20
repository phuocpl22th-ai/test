using System;

namespace ClassLibrary1
{
    public class Class1
    {
        // Hàm kiểm tra số nguyên tố
        public bool KiemTraNguyenTo(int number)
        {
            if (number <= 1) return false; // 0, 1 và số âm không phải nguyên tố
            if (number == 2) return true;  // 2 là số nguyên tố chẵn duy nhất

            // Tối ưu hóa: chỉ chạy đến căn bậc 2 của n
            int limit = (int)Math.Sqrt(number);
            for (int i = 2; i <= limit; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}