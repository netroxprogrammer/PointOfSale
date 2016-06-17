using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Utils.TablesClass
{
    class TableInvoiceData
    {

        private int invoiceDataId;
        private int invoiceId;
        private int productListNumber;
        private String productName;
        private String location;
        private String purpose;
        private String ExpiryDate;
        private int salePrice;
        private int Qty;
        private int Amount;
        private int discount;
        private int netAmount;

        public int InvoiceDataId
        {
            get
            {
                return invoiceDataId;
            }

            set
            {
                invoiceDataId = value;
            }
        }

        public int InvoiceId
        {
            get
            {
                return invoiceId;
            }

            set
            {
                invoiceId = value;
            }
        }

        public int ProductListNumber
        {
            get
            {
                return productListNumber;
            }

            set
            {
                productListNumber = value;
            }
        }

        public string ProductName
        {
            get
            {
                return productName;
            }

            set
            {
                productName = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        public string Purpose
        {
            get
            {
                return purpose;
            }

            set
            {
                purpose = value;
            }
        }

        public string ExpiryDate1
        {
            get
            {
                return ExpiryDate;
            }

            set
            {
                ExpiryDate = value;
            }
        }

        public int SalePrice
        {
            get
            {
                return salePrice;
            }

            set
            {
                salePrice = value;
            }
        }

        public int Qty1
        {
            get
            {
                return Qty;
            }

            set
            {
                Qty = value;
            }
        }

        public int Amount1
        {
            get
            {
                return Amount;
            }

            set
            {
                Amount = value;
            }
        }

        public int Discount
        {
            get
            {
                return discount;
            }

            set
            {
                discount = value;
            }
        }

        public int NetAmount
        {
            get
            {
                return netAmount;
            }

            set
            {
                netAmount = value;
            }
        }
    }
}
