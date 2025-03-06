using System.ComponentModel;
using Material_calculation_method;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculation Calc = new Calculation();
        [TestMethod]
        public void GetQuantityForProduct_TrueExecute() //Правильный ответ
        {
            int productType = 1;
            int materialType = 1;
            int count = 10;
            float width = 2;
            float length = 3;
            int otvet = 261;
            int execute = Calc.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(otvet, execute);
        }

        [TestMethod]
        public void GetQuantityForProduct_FalseExecute() //Неправильный ответ
        {
            int productType = 3;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = 45;
            int otvet = 114148;
            int execute = Calc.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreNotEqual(otvet, execute);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType()  //Несуществующий тип продукции
        {
            int productType = 5;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = 45;
            int otvet = -1;
            int execute = Calc.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(otvet, execute);
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterialType()  //Несуществующий тип материала
        {
            int productType = 3;
            int materialType = 0;
            int count = 15;
            float width = 20;
            float length = 45;
            int otvet = -1;
            int execute = Calc.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(otvet, execute);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeCount()  //Отрицательное количество продукции
        {
            int productType = 3;
            int materialType = 1;
            int count = -2;
            float width = 20;
            float length = 45;
            int otvet = -1;
            int execute = Calc.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(otvet, execute);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeWidth()  //Отрицательная ширина
        {
            int productType = 3;
            int materialType = 1;
            int count = 15;
            float width = -20;
            float length = 45;
            int otvet = -1;
            int execute = Calc.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(otvet, execute);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeLength()  //Отрицательная высота
        {
            int productType = 3;
            int materialType = 1;
            int count = 15;
            float width = 20;
            float length = -45;
            int otvet = -1;
            int execute = Calc.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(otvet, execute);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeLengthAndWidth()  //Отрицательная высота и ширина
        {
            int productType = 3;
            int materialType = 1;
            int count = 15;
            float width = -20;
            float length = -45;
            int otvet = -1;
            int execute = Calc.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(otvet, execute);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeLengthAndWidthAndCount()  //Отрицательная высота и ширина и количество продукции
        {
            int productType = 3;
            int materialType = 1;
            int count = -15;
            float width = -20;
            float length = -45;
            int otvet = -1;
            int execute = Calc.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(otvet, execute);
        }

        [TestMethod]
        public void GetQuantityForProduct_NegativeLengthAndWidthAndCountAndNonExistentMaterialType()  //Отрицательная высота и ширина и количество продукции и несуществующий тип материала
        {
            int productType = 3;
            int materialType = 6;
            int count = -15;
            float width = -20;
            float length = -45;
            int otvet = -1;
            int execute = Calc.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(otvet, execute);
        }

        //Все тесты ниже не будут пройдены, так как исключения обработаны внутри библиотеки и исключений не выходит

        [TestMethod]
        public void GetQuantityForProduct_NegativeCount_ThrowsArgumentOutOfRangeException()
        {
            int productType = 1;
            int materialType = 1;
            int count = -1; // Неверное значение
            float width = 2.0f;
            float length = 3.0f;

            var ex = Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
                Calc.GetQuantityForProduct(productType, materialType, count, width, length));
            Assert.AreEqual("Count must be non-negative", ex.Message);
        }

        [TestMethod]
        public void GetQuantityForProduct_ZeroWidth_ThrowsArgumentException()
        {
            int productType = 1;
            int materialType = 1;
            int count = 5;
            float width = 0; // Неверное значение
            float length = 3.0f;

            var ex = Assert.ThrowsException<ArgumentException>(() =>
                Calc.GetQuantityForProduct(productType, materialType, count, width, length));
            Assert.AreEqual("Width must be greater than zero", ex.Message);
        }

        [TestMethod]
        public void GetQuantityForProduct_ZeroLength_ThrowsArgumentException()
        {
            int productType = 1;
            int materialType = 1;
            int count = 5;
            float width = 2.0f;
            float length = 0; // Неверное значение
     
            var ex = Assert.ThrowsException<ArgumentException>(() =>
                Calc.GetQuantityForProduct(productType, materialType, count, width, length));
            Assert.AreEqual("Length must be greater than zero", ex.Message);
        }

        [TestMethod]
        public void GetQuantityForProduct_InvalidProductType_ThrowsArgumentException()
        {
            int productType = -1; // Неверное значение
            int materialType = 1;
            int count = 5;
            float width = 2.0f;
            float length = 3.0f;

            var ex = Assert.ThrowsException<ArgumentException>(() =>
                Calc.GetQuantityForProduct(productType, materialType, count, width, length));
            Assert.AreEqual("Invalid product type", ex.Message);
        }

        [TestMethod]
        public void GetQuantityForProduct_InvalidMaterialType_ThrowsArgumentException()
        {
            int productType = 1;
            int materialType = -1; // Неверное значение
            int count = 5;
            float width = 2.0f;
            float length = 3.0f;

            var ex = Assert.ThrowsException<ArgumentException>(() =>
                Calc.GetQuantityForProduct(productType, materialType, count, width, length));
            Assert.AreEqual("Invalid material type", ex.Message);
        }
    }
}