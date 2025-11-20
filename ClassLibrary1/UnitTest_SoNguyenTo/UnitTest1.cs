using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1; // Gọi thư viện của bạn

namespace UnitTest_SoNguyenTo
{
    [TestClass]
    public class UnitTest1
    {
        // Khởi tạo đối tượng Class1 để test
        Class1 calc = new Class1();

        // --- NHÓM 1: TEST CASE SỐ ĐẶC BIỆT (Không phải nguyên tố) ---

        [TestMethod]
        public void Test_SoAm_LaFalse()
        {
            // Input: -5, -1 -> Mong đợi: False
            bool result = calc.KiemTraNguyenTo(-5);
            Assert.IsFalse(result, "Số âm không phải là số nguyên tố");
        }

        [TestMethod]
        public void Test_So0_LaFalse()
        {
            // Input: 0 -> Mong đợi: False
            bool result = calc.KiemTraNguyenTo(0);
            Assert.IsFalse(result, "Số 0 không phải là số nguyên tố");
        }

        [TestMethod]
        public void Test_So1_LaFalse()
        {
            // Input: 1 -> Mong đợi: False
            bool result = calc.KiemTraNguyenTo(1);
            Assert.IsFalse(result, "Số 1 không phải là số nguyên tố");
        }

        // --- NHÓM 2: TEST CASE SỐ NGUYÊN TỐ ĐÚNG (Phải trả về True) ---

        [TestMethod]
        public void Test_So2_LaTrue()
        {
            // Input: 2 -> Mong đợi: True (Số nguyên tố nhỏ nhất)
            bool result = calc.KiemTraNguyenTo(2);
            Assert.IsTrue(result, "Số 2 LÀ số nguyên tố");
        }

        [TestMethod]
        public void Test_So3_LaTrue()
        {
            // Input: 3 -> Mong đợi: True
            bool result = calc.KiemTraNguyenTo(3);
            Assert.IsTrue(result, "Số 3 LÀ số nguyên tố");
        }

        [TestMethod]
        public void Test_SoNguyenToLon_LaTrue()
        {
            // Input: 13, 17, 19... -> Mong đợi: True
            bool result = calc.KiemTraNguyenTo(17);
            Assert.IsTrue(result, "Số 17 LÀ số nguyên tố");
        }

        // --- NHÓM 3: TEST CASE SỐ HỢP SỐ (Chia hết cho số khác -> False) ---

        [TestMethod]
        public void Test_So4_LaFalse()
        {
            // Input: 4 (chia hết cho 2) -> Mong đợi: False
            bool result = calc.KiemTraNguyenTo(4);
            Assert.IsFalse(result, "Số 4 chia hết cho 2, không phải nguyên tố");
        }

        [TestMethod]
        public void Test_So9_LaFalse()
        {
            // Input: 9 (chia hết cho 3) -> Mong đợi: False
            bool result = calc.KiemTraNguyenTo(9);
            Assert.IsFalse(result, "Số 9 chia hết cho 3, không phải nguyên tố");
        }
    }
}