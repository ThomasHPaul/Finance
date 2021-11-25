namespace Finance
{
    class Program
    {
        static void Main()
        {
            string csvPath = @".\data\testReceipt.csv";
            CsvUtil reader = new CsvUtil(csvPath);

            reader.readColHeaders();
        }
    }
}