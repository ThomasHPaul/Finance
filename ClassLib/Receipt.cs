namespace Finance
{
    public class Receipt
    {
        private readonly int id;
        private int storeId;
        private DateTime txnTime;
        private int receiptTotal;
        private int receiptSubtotal;


        public Receipt(DateTime txnTime, int receiptTotal, int receiptSubtotal)
        {
            this.id = getNextIdFromDataFile();
            this.txnTime = txnTime;
            this.receiptTotal = receiptTotal;
            this.receiptSubtotal = receiptSubtotal;
        }

        private int getNextIdFromDataFile()
        {
            throw new NotImplementedException("Not yet implemented");
        }

        public int getId()
        {
            return this.id;
        }

        public int getStoreId()
        {
            return this.storeId;
        }

        public void setStoreId(int storeId)
        {
            this.storeId = storeId;
        }

        public int getReceiptTotal()
        {
            return this.receiptTotal;
        }

        public void setReceiptTotal(int receiptTotal)
        {
            this.receiptTotal = receiptTotal;
        }

        public int getReceiptSubtotal()
        {
            return this.receiptSubtotal;
        }

        public void setReceiptSubtotal(int receiptSubtotal)
        {
            this.receiptSubtotal = receiptSubtotal;
        }
    }
}