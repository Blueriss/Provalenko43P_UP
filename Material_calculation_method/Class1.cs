namespace Material_calculation_method
{
    public class Calculation
    {
        public int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            double quantity;
            double quantityWithout;         
            if (count > 0 && width > 0 && length > 0)
            {
                if (productType == 1 && materialType == 1)
                {
                    quantityWithout = (width * length * 4.34 * count);

                    quantity = quantityWithout + (quantityWithout * 0.001);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                if (productType == 1 && materialType == 2)
                {
                    quantityWithout = (width * length * 4.34 * count);

                    quantity = quantityWithout + (quantityWithout * 0.0095);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                if (productType == 1 && materialType == 3)
                {
                    quantityWithout = (width * length * 4.34 * count);

                    quantity = quantityWithout + (quantityWithout * 0.0028);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                if (productType == 1 && materialType == 4)
                {
                    quantityWithout = (width * length * 4.34 * count);

                    quantity = quantityWithout + (quantityWithout * 0.0055);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                if (productType == 1 && materialType == 5)
                {
                    quantityWithout = (width * length * 4.34 * count);

                    quantity = quantityWithout + (quantityWithout * 0.0034);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }

                if (productType == 2 && materialType == 1)
                {
                    quantityWithout = (width * length * 2.35 * count);

                    quantity = quantityWithout + (quantityWithout * 0.001);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                if (productType == 2 && materialType == 2)
                {
                    quantityWithout = (width * length * 2.35 * count);

                    quantity = quantityWithout + (quantityWithout * 0.0095);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                if (productType == 2 && materialType == 3)
                {
                    quantityWithout = (width * length * 2.35 * count);

                    quantity = quantityWithout + (quantityWithout * 0.0028);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                if (productType == 2 && materialType == 4)
                {
                    quantityWithout = (width * length * 2.35 * count);

                    quantity = quantityWithout + (quantityWithout * 0.0055);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                if (productType == 2 && materialType == 5)
                {
                    quantityWithout = (width * length * 2.35 * count);

                    quantity = quantityWithout + (quantityWithout * 0.0034);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }

                if (productType == 3 && materialType == 1)
                {
                    quantityWithout = (width * length * 1.5 * count);

                    quantity = quantityWithout + (quantityWithout * 0.001);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                if (productType == 3 && materialType == 2)
                {
                    quantityWithout = (width * length * 1.5 * count);

                    quantity = quantityWithout + (quantityWithout * 0.0095);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                if (productType == 3 && materialType == 3)
                {
                    quantityWithout = (width * length * 1.5 * count);

                    quantity = quantityWithout + (quantityWithout * 0.0028);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                if (productType == 3 && materialType == 4)
                {
                    quantityWithout = (width * length * 1.5 * count);

                    quantity = quantityWithout + (quantityWithout * 0.0055);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                if (productType == 3 && materialType == 5)
                {
                    quantityWithout = (width * length * 1.5 * count);

                    quantity = quantityWithout + (quantityWithout * 0.0034);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }

                if (productType == 4 && materialType == 1)
                {
                    quantityWithout = (width * length * 5.15 * count);

                    quantity = quantityWithout + (quantityWithout * 0.001);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                if (productType == 4 && materialType == 2)
                {
                    quantityWithout = (width * length * 5.15 * count);

                    quantity = quantityWithout + (quantityWithout * 0.0095);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                if (productType == 4 && materialType == 3)
                {
                    quantityWithout = (width * length * 5.15 * count);

                    quantity = quantityWithout + (quantityWithout * 0.0028);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                if (productType == 4 && materialType == 4)
                {
                    quantityWithout = (width * length * 5.15 * count);

                    quantity = quantityWithout + (quantityWithout * 0.0055);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                if (productType == 4 && materialType == 5)
                {
                    quantityWithout = (width * length * 5.15 * count);

                    quantity = quantityWithout + (quantityWithout * 0.0034);
                    return Convert.ToInt32(Math.Ceiling(quantity));
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Count must be non-negative");
            }

            // Проверка на нулевую ширину
            if (width <= 0)
            {
                throw new ArgumentException("Width must be greater than zero", nameof(width));
            }

            // Проверка на нулевую длину
            if (length <= 0)
            {
                throw new ArgumentException("Length must be greater than zero", nameof(length));
            }

            // Проверка на допустимый тип продукта
            if (productType < 0 || productType > 4)
            {
                throw new ArgumentException("Invalid product type", nameof(productType));
            }

            // Проверка на допустимый тип материала
            if (materialType < 0 || materialType > 5)
            {
                throw new ArgumentException("Invalid material type", nameof(materialType));
            }
        }
    }
}
